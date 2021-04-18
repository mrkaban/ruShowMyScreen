/************************************************************************
ShowMyScreen - simple screen sharing utility
Copyright (C) 2011  Lazar Laszlo

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.

http://showmyscreen.sourceforge.net/
mailto:laszlolazar@yahoo.com
************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Configuration;

using xWebServ;

namespace ShowMyScreen
{
    public partial class Form1 : Form
    {
        private WebServ Server;
        private bool exiting;
        private byte[] lastScreen;

        public Form1()
        {
            InitializeComponent();
            lastScreen = new Byte[1];
            for (int i = 0; i < Screen.AllScreens.Length; i++)
                cbScreens.Items.Add(Screen.AllScreens[i].DeviceName);
            cbScreens.SelectedIndex = 0;

            tbUser.Text = ReadSettingString("DefaultUser");
            tbPassword.Text = ReadSettingString("DefaultPassword");

        }

        private static int ReadSettingInt(string key)
        {
            int ret = -1;
            try
            {
                string val = ConfigurationSettings.AppSettings[key];
                ret = Int32.Parse(val);
            }
            catch { };
            return ret;
        }

        private static String ReadSettingString(string key)
        {
            String ret = "";
            try
            {
                ret = ConfigurationSettings.AppSettings[key];
            }
            catch { };
            return ret;
        }


        private void btStart_Click(object sender, EventArgs e)
        {
            int port = 0;
            try
            {
                port = int.Parse(tbPort.Text);
            }
            catch
            {
                MessageBox.Show("Пожалуйста, укажите порт!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            Server = new WebServ(port);
            Server.RootDir = ".\\";
            Server.UseFiles = false;
            Server.AddProcessor("/screen.jpg", screen);
            Server.AddProcessor("/screen.html", html);
            Server.Start();
            btStart.Enabled = false;
            btStop.Enabled = true;
            tbURL.Text = "http://" + System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).HostName + ":" + tbPort.Text + "/screen.html";
            timer1.Interval = ReadSettingInt("ScreenShotInterval");
            if (timer1.Interval == -1)
                timer1.Interval = 1000;
            timer1.Start();
        }


        private  bool CheckAuth(string p)
        {
            int poz = p.IndexOf("Basic ");
            if (poz >= 0)
            {
                string data = base64Decode(p.Substring(6));

                if (data.Equals(tbUser.Text+":"+tbPassword.Text))
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        private byte[] Gethtml()
        {
            string html = "<html dir=ltr lang=ru-ru><head><title> " + tbURL.Text + "</title>";
            html+="<style type=\"text/css\">\n";
            html += "body { background:steelblue}\n";
            html += "h1 {color:white}\n";
            html += "img {border:2px solid black;}\n";
            html += "</style>\n";
            html+="<script language=\"JavaScript\">\n"+
                    "var oldw=640,oldh=480;"+
                    "function refreshIt() {\n"+
                    "if (!document.images) return;\n"+
                        "document.images['screen'].src = 'screen.jpg?' + Math.random();\n"+
                        "e= document.getElementById(\"scale\");" +
                        "if(e.checked){"+
                        "document.images['screen'].width=document.body.clientWidth;" +
                        "document.images['screen'].height=document.body.clientHeight;} else{" +
                        "document.images['screen'].width=oldw;" +
                        "document.images['screen'].height=oldh;} " +
                        "e = document.getElementById(\"time\");" +
                    "setTimeout('refreshIt()',e.value); // refresh every 5 secs\n"+
                    "}</script>\n";

            html += "</head><body onLoad=\" setTimeout('refreshIt()',500)\">\n";
            html += "<h3 align='center'>Refresh: <select  id=\"time\" > <option value=\"100\">100 ms</option> <option value=\"300\">300 ms</option> <option value=\"500\">500 ms</option> <option value=\"1000\" selected=\"selected\">1 second</option>\n";
            html += "<option value=\"2000\">2 seconds</option> <option value=\"3000\">3 seconds</option><option value=\"4000\">4 seconds</option>\n";
            html += "<option value=\"5000\">5 seconds</option> <option value=\"10000\">10 seconds</option><option value=\"30000\">30 seconds</option>\n";
            html += "</select>\n";
            html += "ms&nbsp;&nbsp;Scale: <input type=\"checkbox\" name=\"scale\" id=\"scale\" value=\"1\" /></h3><br>\n";
            html += "<img name=\"screen\" src=\"screen.jpg\"></img>\n";
            html += "<script language=\"JavaScript\">\n";
            html += "document.images['screen'].onload=function(){ oldw = document.images['screen'].width;" +
                        "oldh=document.images['screen'].height;document.images['screen'].onload=null};</script>";

            html += "</body></html>";
            return ASCIIEncoding.ASCII.GetBytes(html);
        }

        private byte[] html(Uri path, Dictionary<string, string> vars, ref string head)
        {
            //if (vars.ContainsKey("Authorization") && CheckAuth(vars["Authorization"]))
            //{
                head += "Content-Type: text/html\r\n";
                return Gethtml();
            //}
            //else
            //{
            //    head = head.Replace("200 OK", "401 Authorization Required");
            //    head += "Content-Type: Image/JPG\r\n";
            //    head += "WWW-Authenticate: Basic realm=\"Ooops...\"\r\n";
            //    return new byte[1];
            //}
        }

        private byte[] screen(Uri path, Dictionary<string, string> vars, ref string head)
        {
            if (vars.ContainsKey("Authorization") && CheckAuth(vars["Authorization"]))
            {
                head += "Content-Type: Image/JPG\r\n";
                return lastScreen;
            }
            else
            {
                head = head.Replace("200 OK", "401 Authorization Required");
                head += "Content-Type: Image/JPG\r\n";
                head += "WWW-Authenticate: Basic realm=\"Ooops...\"\r\n";
                return new byte[1];
            }
        }
        public string base64Encode(string data)
        {
            try
            {
                byte[] encData_byte = new byte[data.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(data);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch 
            {

                return "";
            }
        }
        public  string base64Decode(string data)
        {
            try
            {
                System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
                System.Text.Decoder utf8Decode = encoder.GetDecoder();

                byte[] todecode_byte = Convert.FromBase64String(data);
                int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
                char[] decoded_char = new char[charCount];
                utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
                string result = new String(decoded_char);
                return result;
            }
            catch 
            {

                return "";
            }
        }


        public  byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        public byte[] GetRegion()
        {
            System.Drawing.Rectangle screenRegiion = System.Windows.Forms.Screen.AllScreens[cbScreens.SelectedIndex].Bounds;

            //System.Drawing.Rectangle screenRegiion = Screen.PrimaryScreen.WorkingArea;
            System.Drawing.Bitmap screenBitmap = new System.Drawing.Bitmap(screenRegiion.Width, screenRegiion.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            System.Drawing.Graphics screenGraphics = System.Drawing.Graphics.FromImage(screenBitmap);
            screenGraphics.CopyFromScreen(screenRegiion.Left, screenRegiion.Top, 0, 0, screenRegiion.Size);

            Point crs = Cursor.Position;

            crs.X = crs.X - screenRegiion.Left;
            crs.Y = crs.Y - screenRegiion.Top;

            int CScale = cbBigCursor.Checked?2:1;
            if(cbShowCursor.Checked)
                Cursor.DrawStretched(screenGraphics, new Rectangle(crs.X - Cursor.Size.Width / 2, crs.Y - Cursor.Size.Height / 2, Cursor.Size.Width * CScale, Cursor.Size.Height * CScale));

            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
            pictureBox1.Image = screenBitmap;

            byte[] imgbytes = imageToByteArray(screenBitmap);

            //screenBitmap.Dispose();
            screenBitmap = null;
            screenGraphics.Dispose();
            screenGraphics = null;

            return imgbytes;
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Server.Stop();
            btStop.Enabled = false;
            btStart.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!exiting)
            {
                this.Hide();
                e.Cancel = true;
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new About().ShowDialog();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exiting = true;
            if (Server != null) Server.Stop();
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void cbShowCursor_CheckedChanged(object sender, EventArgs e)
        {
            cbBigCursor.Enabled = cbShowCursor.Checked;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lastScreen = GetRegion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (ReadSettingString("ShowCursor").ToLower() == "y")
                cbShowCursor.Checked = true;
            if (ReadSettingString("BigCursor").ToLower() == "y")
                cbBigCursor.Checked = true;
            tbPort.Text = ReadSettingString("DefaultPort");

            if (ReadSettingString("Autostart").ToLower() == "y")
                btStart_Click(null, null);
        }


    }
}