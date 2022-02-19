namespace SupermarioTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Marken = new System.Windows.Forms.PictureBox();
            this.Mario = new System.Windows.Forms.PictureBox();
            this.Block1 = new System.Windows.Forms.PictureBox();
            this.Block2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Marken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Block1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Block2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(3200, 240);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Marken
            // 
            this.Marken.Image = ((System.Drawing.Image)(resources.GetObject("Marken.Image")));
            this.Marken.Location = new System.Drawing.Point(0, 512);
            this.Marken.Name = "Marken";
            this.Marken.Size = new System.Drawing.Size(1928, 128);
            this.Marken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Marken.TabIndex = 4;
            this.Marken.TabStop = false;
            // 
            // Mario
            // 
            this.Mario.Image = ((System.Drawing.Image)(resources.GetObject("Mario.Image")));
            this.Mario.Location = new System.Drawing.Point(48, 226);
            this.Mario.Name = "Mario";
            this.Mario.Size = new System.Drawing.Size(128, 128);
            this.Mario.TabIndex = 5;
            this.Mario.TabStop = false;
            this.Mario.Click += new System.EventHandler(this.Mario_Click);
            // 
            // Block1
            // 
            this.Block1.Image = ((System.Drawing.Image)(resources.GetObject("Block1.Image")));
            this.Block1.Location = new System.Drawing.Point(12, 511);
            this.Block1.Name = "Block1";
            this.Block1.Size = new System.Drawing.Size(157, 64);
            this.Block1.TabIndex = 6;
            this.Block1.TabStop = false;
            // 
            // Block2
            // 
            this.Block2.Image = ((System.Drawing.Image)(resources.GetObject("Block2.Image")));
            this.Block2.Location = new System.Drawing.Point(411, 448);
            this.Block2.Name = "Block2";
            this.Block2.Size = new System.Drawing.Size(190, 64);
            this.Block2.TabIndex = 7;
            this.Block2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 193);
            this.Controls.Add(this.Block2);
            this.Controls.Add(this.Block1);
            this.Controls.Add(this.Mario);
            this.Controls.Add(this.Marken);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Marken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Block1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Block2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Marken;
        private System.Windows.Forms.PictureBox Mario;
        private System.Windows.Forms.PictureBox Block1;
        private System.Windows.Forms.PictureBox Block2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

