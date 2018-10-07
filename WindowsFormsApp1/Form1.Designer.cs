namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.happyBirthdayLabel = new System.Windows.Forms.Label();
            this.confettiGifPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.confettiGifPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // happyBirthdayLabel
            // 
            this.happyBirthdayLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.happyBirthdayLabel.Font = new System.Drawing.Font("NSimSun", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.happyBirthdayLabel.ForeColor = System.Drawing.Color.White;
            this.happyBirthdayLabel.Location = new System.Drawing.Point(1, 1);
            this.happyBirthdayLabel.Name = "happyBirthdayLabel";
            this.happyBirthdayLabel.Size = new System.Drawing.Size(600, 420);
            this.happyBirthdayLabel.TabIndex = 0;
            this.happyBirthdayLabel.Text = "Happy Birthday";
            this.happyBirthdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.happyBirthdayLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // confettiGifPictureBox
            // 
            this.confettiGifPictureBox.Image = global::WindowsFormsApp1.Properties.Resources.imageedit_1_7802775017;
            this.confettiGifPictureBox.Location = new System.Drawing.Point(-21, -13);
            this.confettiGifPictureBox.Name = "confettiGifPictureBox";
            this.confettiGifPictureBox.Size = new System.Drawing.Size(643, 497);
            this.confettiGifPictureBox.TabIndex = 1;
            this.confettiGifPictureBox.TabStop = false;
            this.confettiGifPictureBox.Visible = false;
            this.confettiGifPictureBox.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(604, 419);
            this.Controls.Add(this.confettiGifPictureBox);
            this.Controls.Add(this.happyBirthdayLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BirthdayCard";
            ((System.ComponentModel.ISupportInitialize)(this.confettiGifPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label happyBirthdayLabel;
        private System.Windows.Forms.PictureBox confettiGifPictureBox;
    }
}

