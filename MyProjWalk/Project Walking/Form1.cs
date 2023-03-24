using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Walking
{
    public partial class MainVoid : Form
    {
        public MainVoid()
        {
            InitializeComponent();
        }
        private void DebugOne_Click(object sender, EventArgs e)
        {
           
        }
        private void MainVoid_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        int lefcounter = 1;
        int rigcounter = 3;
        //int upcounter = 5;
        //int downcounter = 7;
        int uprealcount = 9;
        int downrealcount = 11;

        class MediaPlayer
        {
            System.Media.SoundPlayer soundPlayer;
            public MediaPlayer(byte[] buffer)
            {
                MemoryStream memoryStream = new MemoryStream(buffer, true);
                soundPlayer = new System.Media.SoundPlayer(memoryStream);
            }
            public void Play() { soundPlayer.Play(); }
            public void Play(byte[] buffer)
            {
                soundPlayer.Stream.Seek(0, SeekOrigin.Begin);
                soundPlayer.Stream.Write(buffer, 0, buffer.Length);
                soundPlayer.Play();
            }
        }

        private void MainVoid_KeyDown(object sender, KeyEventArgs e)

        {
            int x = picboxMain.Location.X;
            int y = picboxMain.Location.Y;
            int xc = cacti.Location.X;
            int yc = cacti.Location.Y;

            if (e.KeyCode == Keys.F)
            {
                if ((x <= 1100 && x >= 1030)&&(240 >= y && y >= 210))
                {
                    string cacti = @"..\..\Resources\samcacti.wav";
                    List<byte> soundBytes = new List<byte>(File.ReadAllBytes(cacti));
                    MediaPlayer mPlayer = new MediaPlayer(soundBytes.ToArray());
                    mPlayer.Play();
                }
                else
                {
                    string nothing = @"..\..\Resources\samtalk.wav";
                    List<byte> soundBytes = new List<byte>(File.ReadAllBytes(nothing));
                    MediaPlayer mPlayer = new MediaPlayer(soundBytes.ToArray());
                    mPlayer.Play();
                }
            }

            if (e.KeyCode == Keys.F1)
            {
                string heyy = @"..\..\Resources\samdoesntlike.wav";
                List<byte> soundBytes = new List<byte>(File.ReadAllBytes(heyy));
                MediaPlayer mPlayer = new MediaPlayer(soundBytes.ToArray());
                mPlayer.Play();
                MessageBox.Show("Hey! It's simple tutorial: \nWalk using arrows and you'll be just fine");
            }

            if (e.KeyCode == Keys.Right)
            {
                x += 10;

                if (rigcounter < 5)
                {
                    picboxMain.Image = imageList1.Images[rigcounter];
                    rigcounter++;
                }
                else
                {
                    rigcounter = 3;
                    picboxMain.Image = imageList1.Images[3];
                    picboxMain.Refresh();
                    rigcounter++;
                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                x -= 10;

                if (lefcounter < 3)
                {
                    picboxMain.Image = imageList1.Images[lefcounter];
                    lefcounter++;
                }
                else
                {
                    lefcounter = 1;
                    picboxMain.Image = imageList1.Images[1];
                    picboxMain.Refresh();
                    lefcounter++;
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                y -= 10;

                //if (upcounter < 7)
                //{
                //    picboxMain.Image = imageList1.Images[upcounter];
                //    upcounter++;
                //}
                //else
                //{
                //    upcounter = 5;
                //    picboxMain.Image = imageList1.Images[5];
                //    picboxMain.Refresh();
                //    upcounter++;
                //}

                if (uprealcount < 11)
                {
                    picboxMain.Image = imageList1.Images[uprealcount];
                    uprealcount++;
                }
                else
                {
                    uprealcount = 9;
                    picboxMain.Image = imageList1.Images[uprealcount];
                    picboxMain.Refresh();
                    uprealcount++;
                }

            }
            else if (e.KeyCode == Keys.Down)
            {
                y += 10;

                //if (downcounter < 9)
                //{
                //    picboxMain.Image = imageList1.Images[downcounter];
                //    downcounter++;
                //}
                //else
                //{
                //    downcounter = 7;
                //    picboxMain.Image = imageList1.Images[7];
                //    picboxMain.Refresh();
                //    downcounter++;
                //}

                if (downrealcount < 13)
                {
                    picboxMain.Image = imageList1.Images[downrealcount];
                    downrealcount++;
                }
                else
                {
                    downrealcount = 11;
                    picboxMain.Image = imageList1.Images[downrealcount];
                    picboxMain.Refresh();
                    downrealcount++;
                }
            }

            picboxMain.Location = new Point(x, y);
            
            if (x < 0)
            {
                picboxMain.Location = new Point(1240, y);
            }
            if (x > 1240)
            {
                picboxMain.Location = new Point(0, y);
            }
            if (y < 0)
            {
                picboxMain.Location = new Point(x, 520);
            }
            if (y > 520)
            {
                picboxMain.Location = new Point(x, 0);
            }
            
        }


        private void picboxMain_LocationChanged(object sender, EventArgs e)
        {
            int x = picboxMain.Location.X;
            int y = picboxMain.Location.Y;
            label1.Text = "X is " + Convert.ToString(x) + " " + "Y is " + Convert.ToString(y);
        }
        private void MainVoid_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            int x = picboxMain.Location.X;
            int y = picboxMain.Location.Y;
            label1.Text = "X is " + Convert.ToString(x) + " " + "Y is " + Convert.ToString(y);
            string launch = @"..\..\Resources\samhello.wav";
            List<byte> soundBytes = new List<byte>(File.ReadAllBytes(launch));
            MediaPlayer mPlayer = new MediaPlayer(soundBytes.ToArray());
            mPlayer.Play();
        }

        private void MainVoid_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }
    }
}
