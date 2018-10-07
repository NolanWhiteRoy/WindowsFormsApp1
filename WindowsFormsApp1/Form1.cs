using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.Threading;

/// Created By: Nolan White-Roy
/// Date created: 2018-09-21
/// Description: A birthday card that meets all criteria listed on the ISC3U assigment post.

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            //Decalre graphics
            Refresh();
            Graphics gForm = this.CreateGraphics();
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush blueBrush = new SolidBrush(Color.SteelBlue);
            Pen blackPen = new Pen(Color.Black, 2);
            Pen bluePen = new Pen(Color.SteelBlue, 2);
            Pen whitePen = new Pen(Color.White, 5);
            Font timesFont = new Font("TimesNewRoman", 20, FontStyle.Underline);

            //Happy birthday text disappears when clicked
            happyBirthdayLabel.Visible = false;
          
            //Yay Sound plays
            SoundPlayer Yayplayer = new SoundPlayer(Properties.Resources.Yay);
            Yayplayer.Play();

            //Confetti Gif is visable for 3 seconds
            confettiGifPictureBox.Visible = true;
            confettiGifPictureBox.Refresh();
            Thread.Sleep(3000);
            confettiGifPictureBox.Visible = false;
            confettiGifPictureBox.Refresh();
           
            //Message appears with underline
            gForm.DrawString("I hope your special day is wonderful!", timesFont, whiteBrush, 70, 50);

            //Ballon changes colours
            gForm.FillEllipse(redBrush, 500, 150, 60, 80);
            gForm.DrawLine(blackPen, 530, 230, 530, 390);
            Thread.Sleep(500);
            gForm.FillEllipse(yellowBrush, 500, 150, 60, 80);
            Thread.Sleep(500);
            gForm.FillEllipse(redBrush, 500, 150, 60, 80);
            Thread.Sleep(500);
            gForm.FillEllipse(yellowBrush, 500, 150, 60, 80);
            Thread.Sleep(500);
            gForm.FillEllipse(redBrush, 500, 150, 60, 80);
            Thread.Sleep(500);
            gForm.FillEllipse(yellowBrush, 500, 150, 60, 80);
            Thread.Sleep(500);
            gForm.FillEllipse(redBrush, 500, 150, 60, 80);
            Thread.Sleep(500);
            gForm.FillEllipse(yellowBrush, 500, 150, 60, 80);
            Thread.Sleep(500);
            gForm.FillEllipse(redBrush, 500, 150, 60, 80);

            //Red ballon floats upwwards 
            gForm.FillEllipse(blueBrush, 500, 150, 60, 80);
            gForm.DrawLine(bluePen, 530, 230, 530, 390);
            gForm.FillEllipse(redBrush, 500, 140, 60, 80);
            gForm.DrawLine(blackPen, 530, 220, 530, 380);
            Thread.Sleep(100);

            gForm.FillEllipse(blueBrush, 500, 140, 60, 80);
            gForm.DrawLine(bluePen, 530, 220, 530, 380);
            gForm.FillEllipse(redBrush, 500, 130, 60, 80);
            gForm.DrawLine(blackPen, 530, 210, 530, 370);
            Thread.Sleep(100);

            gForm.FillEllipse(blueBrush, 500, 130, 60, 80);
            gForm.DrawLine(bluePen, 530, 210, 530, 370);
            gForm.FillEllipse(redBrush, 500, 120, 60, 80);
            gForm.DrawLine(blackPen, 530, 200, 530, 360);
            Thread.Sleep(100);

            gForm.FillEllipse(blueBrush, 500, 120, 60, 80);
            gForm.DrawLine(bluePen, 530, 210, 530, 360);
            gForm.FillEllipse(redBrush, 500, 110, 60, 80);
            gForm.DrawLine(blackPen, 530, 190, 530, 350);
            Thread.Sleep(100);

            gForm.FillEllipse(blueBrush, 500, 110, 60, 80);
            gForm.DrawLine(bluePen, 530, 190, 530, 370);
            gForm.FillEllipse(redBrush, 500, 100, 60, 80);
            gForm.DrawLine(blackPen, 530, 180, 530, 340);
            Thread.Sleep(100);

            gForm.FillEllipse(blueBrush, 500, 100, 60, 80);
            gForm.DrawLine(bluePen, 530, 180, 530, 360);
            gForm.FillEllipse(redBrush, 500, 90, 60, 80);
            gForm.DrawLine(blackPen, 530, 170, 530, 330);
            Thread.Sleep(100);

            gForm.FillEllipse(blueBrush, 500, 90, 60, 80);
            gForm.DrawLine(bluePen, 530, 170, 530, 350);
            gForm.FillEllipse(redBrush, 500, 80, 60, 80);
            gForm.DrawLine(blackPen, 530, 160, 530, 320);
            Thread.Sleep(100);

            //Ballon disappears when it hits the underline
            gForm.FillEllipse(blueBrush, 500, 80, 60, 80);

            //Pop sound while ballon disappears
            SoundPlayer Popplayer = new SoundPlayer(Properties.Resources.Pop);
            Popplayer.Play();
           
            Thread.Sleep(3000);
          
            //Run Again Button Appears
            happyBirthdayLabel.Text = "";
            happyBirthdayLabel.Visible = true;        
            happyBirthdayLabel.BackColor = Color.White;
            happyBirthdayLabel.Width = this.Width / 6;
            happyBirthdayLabel.Height = this.Height / 15;
            happyBirthdayLabel.Location = new Point(250, 350);
            confettiGifPictureBox.Visible = false;
            gForm.DrawString("I hope your special day is wonderful!", timesFont, whiteBrush, 70, 50);

            happyBirthdayLabel.Refresh();

            Graphics gHappyBirthdayLabel = happyBirthdayLabel.CreateGraphics();
            Font arialFont = new Font("Arial", 15, FontStyle.Bold);
            SolidBrush blackBrush = new SolidBrush(Color.Black);

            gHappyBirthdayLabel.DrawString("Run Again", arialFont, blackBrush, 0, 0);
        }
    }
} 
