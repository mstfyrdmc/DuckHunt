using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace DuckHuntV04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        PictureBox pbordek = new PictureBox();
        int yatayhiz=5;
        int dikeyhiz=5;
        int Kursun = 6;
        int skor = 0;
        int level = 1;
        bool vurulduMu = false;
       
       
        void OrdekOlustur()
        {
            pbordek.Height = pbordek.Width = 100;  //yeni
            pbordek.Image = Properties.Resources.ordek; 
            pbordek.SizeMode = PictureBoxSizeMode.Zoom;
            pbordek.BackColor = Color.Transparent; //pbnin arka planını beyaz yapmadık.

            pbordek.Left = rnd.Next(50, (this.Width - pbordek.Width - 200));
            pbordek.Top = rnd.Next(50, (this.Height - pbordek.Height - 200));
            this.Controls.Add(pbordek);
            
            pbordek.Visible = true;
            vurulduMu = false;
            yatayhiz = 10 + level;
            dikeyhiz = 10 + level;
        }
        void OrdekUcur()
        {
            if (pbordek.Right >= this.Width -15)
            {
                yatayhiz = -10-level;
                pbordek.Image = DuckHuntV04.Properties.Resources.ters_ordek;
            }
            else if (pbordek.Left <= 0)
            {
            pbordek.Image = DuckHuntV04.Properties.Resources.ordek;
                yatayhiz = 10+level;
            }
            else if (pbordek.Top <= 0)
            {
                dikeyhiz = 10 + level;

            }
            else if (pbordek.Bottom >= 445 && vurulduMu == false)
            {
                dikeyhiz = - (10 + level);
                

            }
            else if (pbordek.Bottom >= 445 && vurulduMu == true)
            {
                tmrHareket.Stop();
                // Köpek göster
               
                OrdekOlustur();
                tmrHareket.Start();
            }

            pbordek.Top += dikeyhiz;
            pbordek.Left += yatayhiz;
        }
        void Kursun_Sayisi()
        {
            Kursun--;
            if (Kursun == 5)
            {
                pbBullet5.Visible = false;
            }
            else if (Kursun == 4)
            {
                pbBullet4.Visible = false;
            }
            else if (Kursun == 3)
            {
                pbBullet3.Visible = false;
            }
            else if (Kursun == 2)
            {
                pbBullet2.Visible = false;
            }
            else if (Kursun == 1)
            {
                pbBullet1.Visible = false;
            }
            else if (Kursun == 0)
            {
                pbBullet1.Visible = pbBullet2.Visible = pbBullet3.Visible = pbBullet4.Visible = pbBullet5.Visible = false;
            }
        }
        void Ates()
        {
            SoundPlayer atessesi = new SoundPlayer(); //Sound player nesnesi oluşturduk.
            atessesi.SoundLocation = @"C:\ses_ates.wav"; //intro sesini ekledik
            atessesi.Play(); //sesi formun başlangıcında çalıştırdık.
            if (Kursun <= 0)
            {
                atessesi.Stop();
            }
        }
        void SkorHesapla()
        {
            skor += 100;
            lblScore.Text = skor.ToString();
        }
        void LevelHesapla()
        {
            if (skor == 100)
            {
                level=2;
                lblSeviye.Text = $"{level}";
            }
            else if (skor == 200)
            {
                level = 3;
                lblSeviye.Text = $"{level}";
            }
            else if (skor == 300)
            {
                level = 4;
                lblSeviye.Text = $"{level}";
            }
            else if (skor == 400)
            {
                level = 5;
                lblSeviye.Text = $"{level}";
            }
            else if (skor == 500)
            {
                level = 6;
                lblSeviye.Text = $"{level}";
            }
        }
        void TersOrdek()
        {
            tmrHareket.Stop();
            if (yatayhiz > 0)
            {
                pbordek.Image = DuckHuntV04.Properties.Resources.olu_ordek_sag;
            }
            else if (yatayhiz < 0)
            {
                pbordek.Image = DuckHuntV04.Properties.Resources.olu_ordek_sol;
            }
            yatayhiz = 0;
            dikeyhiz = 10;
            tmrHareket.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; //formu tam ekran açar.
            this.BackgroundImage = Properties.Resources.bg;
            this.BackgroundImageLayout = ImageLayout.Stretch;// form resmini bir bütün yapar.
            pbordek.SizeMode = PictureBoxSizeMode.Zoom;
            pbordek.BackColor = Color.Transparent; //pbnin arka planını beyaz yapmadık.
            pbBullet1.Top = 550; //bulletın konumu 
            pbBullet1.Left = 50;

            pbBullet2.Top = 550; //bulletın konumu 
            pbBullet2.Left = 100;

            pbBullet3.Top = 550; //bulletın konumu 
            pbBullet3.Left = 150;

            pbBullet4.Top = 550; //bulletın konumu 
            pbBullet4.Left = 200;

            pbBullet5.Top = 550; //bulletın konumu 
            pbBullet5.Left = 250;
            lblScore.BackColor = Color.Transparent;
            lblSeviye.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            pbBullet1.BackColor = Color.Transparent;
            pbBullet2.BackColor = Color.Transparent;
            pbBullet3.BackColor = Color.Transparent;
            pbBullet4.BackColor = Color.Transparent;
            pbBullet5.BackColor = Color.Transparent;
            pbordek.MouseClick += pbordek_MouseClick;
            SoundPlayer player = new SoundPlayer();//Sound player nesnesi oluşturduk.
            player.SoundLocation = @"C:\ses_intro.wav";//intro sesini ekledik
            player.Play();//sesi formun başlangıcında çalıştırdık.
            OrdekOlustur();
            tmrHareket.Start();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Ates();
            Kursun_Sayisi();
            
        }
       private void pbordek_MouseClick(object sender, MouseEventArgs e)
        {
            vurulduMu = true;
            SkorHesapla();
            LevelHesapla();
            Kursun_Sayisi();
            Ates();
            TersOrdek();
        }

        private void tmrHareket_Tick(object sender, EventArgs e)
        {
            OrdekUcur();
            //Vurus();
        }
        private void tmrOrdekOlustur_Tick(object sender, EventArgs e)
        {
            
            if (!Controls.Contains(pbordek))
              {
                OrdekOlustur();
                //tmrHareket.Start();
               
            }
              pbordek.Visible = true;
              OrdekUcur();
        }

      /*  private void tmrIyıKopek_Tick(object sender, EventArgs e)
        {
            PictureBox pbKopek2 = new PictureBox(); //yeni
            pbKopek2.Image = Properties.Resources.kopek2;
            pbKopek2.Height = pbKopek2.Width = 100;
            pbKopek2.SizeMode = PictureBoxSizeMode.Zoom;
            pbKopek2.BackColor = Color.Transparent;

            pbKopek2.Top = pbordek.Top;
            pbKopek2.Left = pbordek.Left;
            this.Controls.Add(pbKopek2);
        } */

        /*private void tmrKotuKopek_Tick(object sender, EventArgs e)
        {
            pbordek.Visible = false;    //yeni
            PictureBox pbKopek1 = new PictureBox();
            pbKopek1.Image = Properties.Resources.kopek1;
            pbKopek1.Height = pbKopek1.Width = 100;
            pbKopek1.SizeMode = PictureBoxSizeMode.Zoom;
            pbKopek1.BackColor = Color.Transparent;

            pbKopek1.Top = 400;
            pbKopek1.Left = 550;
            this.Controls.Add(pbKopek1);
        } */
    }
  }
