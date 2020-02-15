namespace DuckHuntV04
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblSeviye = new System.Windows.Forms.Label();
            this.pbBullet5 = new System.Windows.Forms.PictureBox();
            this.pbBullet4 = new System.Windows.Forms.PictureBox();
            this.pbBullet3 = new System.Windows.Forms.PictureBox();
            this.pbBullet2 = new System.Windows.Forms.PictureBox();
            this.pbBullet1 = new System.Windows.Forms.PictureBox();
            this.tmrHareket = new System.Windows.Forms.Timer(this.components);
            this.tmrOrdekOlustur = new System.Windows.Forms.Timer(this.components);
            this.tmrIyıKopek = new System.Windows.Forms.Timer(this.components);
            this.tmrKotuKopek = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbBullet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBullet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBullet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBullet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBullet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(4, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Level:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScore.Location = new System.Drawing.Point(93, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(27, 29);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "0";
            // 
            // lblSeviye
            // 
            this.lblSeviye.AutoSize = true;
            this.lblSeviye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeviye.Location = new System.Drawing.Point(93, 49);
            this.lblSeviye.Name = "lblSeviye";
            this.lblSeviye.Size = new System.Drawing.Size(27, 29);
            this.lblSeviye.TabIndex = 1;
            this.lblSeviye.Text = "1";
            // 
            // pbBullet5
            // 
            this.pbBullet5.Image = global::DuckHuntV04.Properties.Resources.bullet;
            this.pbBullet5.Location = new System.Drawing.Point(317, 332);
            this.pbBullet5.Name = "pbBullet5";
            this.pbBullet5.Size = new System.Drawing.Size(57, 164);
            this.pbBullet5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBullet5.TabIndex = 2;
            this.pbBullet5.TabStop = false;
            // 
            // pbBullet4
            // 
            this.pbBullet4.Image = global::DuckHuntV04.Properties.Resources.bullet;
            this.pbBullet4.Location = new System.Drawing.Point(237, 332);
            this.pbBullet4.Name = "pbBullet4";
            this.pbBullet4.Size = new System.Drawing.Size(57, 164);
            this.pbBullet4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBullet4.TabIndex = 2;
            this.pbBullet4.TabStop = false;
            // 
            // pbBullet3
            // 
            this.pbBullet3.Image = global::DuckHuntV04.Properties.Resources.bullet;
            this.pbBullet3.Location = new System.Drawing.Point(159, 332);
            this.pbBullet3.Name = "pbBullet3";
            this.pbBullet3.Size = new System.Drawing.Size(57, 164);
            this.pbBullet3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBullet3.TabIndex = 2;
            this.pbBullet3.TabStop = false;
            // 
            // pbBullet2
            // 
            this.pbBullet2.Image = global::DuckHuntV04.Properties.Resources.bullet;
            this.pbBullet2.Location = new System.Drawing.Point(84, 332);
            this.pbBullet2.Name = "pbBullet2";
            this.pbBullet2.Size = new System.Drawing.Size(57, 164);
            this.pbBullet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBullet2.TabIndex = 2;
            this.pbBullet2.TabStop = false;
            // 
            // pbBullet1
            // 
            this.pbBullet1.Image = global::DuckHuntV04.Properties.Resources.bullet;
            this.pbBullet1.Location = new System.Drawing.Point(9, 332);
            this.pbBullet1.Name = "pbBullet1";
            this.pbBullet1.Size = new System.Drawing.Size(57, 164);
            this.pbBullet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBullet1.TabIndex = 2;
            this.pbBullet1.TabStop = false;
            // 
            // tmrHareket
            // 
            this.tmrHareket.Interval = 10;
            this.tmrHareket.Tick += new System.EventHandler(this.tmrHareket_Tick);
            // 
            // tmrOrdekOlustur
            // 
            this.tmrOrdekOlustur.Interval = 10;
            this.tmrOrdekOlustur.Tick += new System.EventHandler(this.tmrOrdekOlustur_Tick);
            // 
            // tmrIyıKopek
            // 
            this.tmrIyıKopek.Interval = 1000;
            
            // 
            // tmrKotuKopek
            // 
            this.tmrKotuKopek.Interval = 1000;
           
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 508);
            this.Controls.Add(this.pbBullet5);
            this.Controls.Add(this.pbBullet4);
            this.Controls.Add(this.pbBullet3);
            this.Controls.Add(this.pbBullet2);
            this.Controls.Add(this.pbBullet1);
            this.Controls.Add(this.lblSeviye);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pbBullet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBullet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBullet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBullet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBullet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblSeviye;
        private System.Windows.Forms.PictureBox pbBullet1;
        private System.Windows.Forms.PictureBox pbBullet2;
        private System.Windows.Forms.PictureBox pbBullet3;
        private System.Windows.Forms.PictureBox pbBullet4;
        private System.Windows.Forms.PictureBox pbBullet5;
        private System.Windows.Forms.Timer tmrHareket;
        private System.Windows.Forms.Timer tmrOrdekOlustur;
        private System.Windows.Forms.Timer tmrIyıKopek;
        private System.Windows.Forms.Timer tmrKotuKopek;
    }
}

