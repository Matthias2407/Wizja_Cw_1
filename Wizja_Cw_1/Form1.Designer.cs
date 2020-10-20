namespace Wizja_Cw_1
{
    partial class CW1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.graphBox1 = new System.Windows.Forms.PictureBox();
            this.graphBox2 = new System.Windows.Forms.PictureBox();
            this.button_Graphic1 = new System.Windows.Forms.Button();
            this.button_fromFile1 = new System.Windows.Forms.Button();
            this.button_Camera1 = new System.Windows.Forms.Button();
            this.button_Graphic2 = new System.Windows.Forms.Button();
            this.button_fromFile2 = new System.Windows.Forms.Button();
            this.button_Camera2 = new System.Windows.Forms.Button();
            this.button_Clear1 = new System.Windows.Forms.Button();
            this.button_Clear2 = new System.Windows.Forms.Button();
            this.button_doGraph1 = new System.Windows.Forms.Button();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.textBox_Y = new System.Windows.Forms.TextBox();
            this.label_X = new System.Windows.Forms.Label();
            this.label_Y = new System.Windows.Forms.Label();
            this.label_Listing = new System.Windows.Forms.Label();
            this.textBox_R = new System.Windows.Forms.TextBox();
            this.textBox_G = new System.Windows.Forms.TextBox();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.button_pic1to2 = new System.Windows.Forms.Button();
            this.button_pic2to1 = new System.Windows.Forms.Button();
            this.button_toMono = new System.Windows.Forms.Button();
            this.button_doGraph2 = new System.Windows.Forms.Button();
            this.checkBox_R = new System.Windows.Forms.CheckBox();
            this.checkBox_G = new System.Windows.Forms.CheckBox();
            this.checkBox_B = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(21, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(459, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(320, 240);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // graphBox1
            // 
            this.graphBox1.BackColor = System.Drawing.Color.Black;
            this.graphBox1.Location = new System.Drawing.Point(21, 417);
            this.graphBox1.Name = "graphBox1";
            this.graphBox1.Size = new System.Drawing.Size(320, 100);
            this.graphBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.graphBox1.TabIndex = 2;
            this.graphBox1.TabStop = false;
            this.graphBox1.Click += new System.EventHandler(this.graphBox1_Click);
            // 
            // graphBox2
            // 
            this.graphBox2.BackColor = System.Drawing.Color.Black;
            this.graphBox2.Location = new System.Drawing.Point(459, 417);
            this.graphBox2.Name = "graphBox2";
            this.graphBox2.Size = new System.Drawing.Size(320, 100);
            this.graphBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.graphBox2.TabIndex = 3;
            this.graphBox2.TabStop = false;
            this.graphBox2.Click += new System.EventHandler(this.graphBox2_Click);
            // 
            // button_Graphic1
            // 
            this.button_Graphic1.Location = new System.Drawing.Point(21, 12);
            this.button_Graphic1.Name = "button_Graphic1";
            this.button_Graphic1.Size = new System.Drawing.Size(88, 35);
            this.button_Graphic1.TabIndex = 4;
            this.button_Graphic1.Text = "Grafika";
            this.button_Graphic1.UseVisualStyleBackColor = true;
            this.button_Graphic1.Click += new System.EventHandler(this.button_Graphic1_Click);
            // 
            // button_fromFile1
            // 
            this.button_fromFile1.Location = new System.Drawing.Point(115, 12);
            this.button_fromFile1.Name = "button_fromFile1";
            this.button_fromFile1.Size = new System.Drawing.Size(82, 35);
            this.button_fromFile1.TabIndex = 5;
            this.button_fromFile1.Text = "Z pliku";
            this.button_fromFile1.UseVisualStyleBackColor = true;
            this.button_fromFile1.Click += new System.EventHandler(this.button_fromFile1_Click);
            // 
            // button_Camera1
            // 
            this.button_Camera1.Location = new System.Drawing.Point(203, 12);
            this.button_Camera1.Name = "button_Camera1";
            this.button_Camera1.Size = new System.Drawing.Size(81, 36);
            this.button_Camera1.TabIndex = 6;
            this.button_Camera1.Text = "Kamera";
            this.button_Camera1.UseVisualStyleBackColor = true;
            this.button_Camera1.Click += new System.EventHandler(this.button_Camera1_Click);
            // 
            // button_Graphic2
            // 
            this.button_Graphic2.Location = new System.Drawing.Point(459, 12);
            this.button_Graphic2.Name = "button_Graphic2";
            this.button_Graphic2.Size = new System.Drawing.Size(92, 35);
            this.button_Graphic2.TabIndex = 7;
            this.button_Graphic2.Text = "Grafika";
            this.button_Graphic2.UseVisualStyleBackColor = true;
            this.button_Graphic2.Click += new System.EventHandler(this.button_Graphic2_Click);
            // 
            // button_fromFile2
            // 
            this.button_fromFile2.Location = new System.Drawing.Point(557, 12);
            this.button_fromFile2.Name = "button_fromFile2";
            this.button_fromFile2.Size = new System.Drawing.Size(87, 36);
            this.button_fromFile2.TabIndex = 8;
            this.button_fromFile2.Text = "Z pliku";
            this.button_fromFile2.UseVisualStyleBackColor = true;
            this.button_fromFile2.Click += new System.EventHandler(this.button_fromFile2_Click);
            // 
            // button_Camera2
            // 
            this.button_Camera2.Location = new System.Drawing.Point(650, 12);
            this.button_Camera2.Name = "button_Camera2";
            this.button_Camera2.Size = new System.Drawing.Size(83, 36);
            this.button_Camera2.TabIndex = 9;
            this.button_Camera2.Text = "Kamera";
            this.button_Camera2.UseVisualStyleBackColor = true;
            this.button_Camera2.Click += new System.EventHandler(this.button_Camera2_Click);
            // 
            // button_Clear1
            // 
            this.button_Clear1.Location = new System.Drawing.Point(21, 364);
            this.button_Clear1.Name = "button_Clear1";
            this.button_Clear1.Size = new System.Drawing.Size(76, 33);
            this.button_Clear1.TabIndex = 10;
            this.button_Clear1.Text = "Czyść";
            this.button_Clear1.UseVisualStyleBackColor = true;
            this.button_Clear1.Click += new System.EventHandler(this.button_Clear1_Click);
            // 
            // button_Clear2
            // 
            this.button_Clear2.Location = new System.Drawing.Point(459, 364);
            this.button_Clear2.Name = "button_Clear2";
            this.button_Clear2.Size = new System.Drawing.Size(77, 33);
            this.button_Clear2.TabIndex = 11;
            this.button_Clear2.Text = "Czyść";
            this.button_Clear2.UseVisualStyleBackColor = true;
            this.button_Clear2.Click += new System.EventHandler(this.button_Clear2_Click);
            // 
            // button_doGraph1
            // 
            this.button_doGraph1.Location = new System.Drawing.Point(224, 378);
            this.button_doGraph1.Name = "button_doGraph1";
            this.button_doGraph1.Size = new System.Drawing.Size(117, 33);
            this.button_doGraph1.TabIndex = 12;
            this.button_doGraph1.Text = "Wykres linii";
            this.button_doGraph1.UseVisualStyleBackColor = true;
            this.button_doGraph1.Click += new System.EventHandler(this.button_doGraph1_Click);
            // 
            // textBox_X
            // 
            this.textBox_X.Location = new System.Drawing.Point(47, 53);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(62, 22);
            this.textBox_X.TabIndex = 13;
            // 
            // textBox_Y
            // 
            this.textBox_Y.Location = new System.Drawing.Point(47, 81);
            this.textBox_Y.Name = "textBox_Y";
            this.textBox_Y.Size = new System.Drawing.Size(62, 22);
            this.textBox_Y.TabIndex = 14;
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Location = new System.Drawing.Point(20, 56);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(21, 17);
            this.label_X.TabIndex = 15;
            this.label_X.Text = "X:";
            // 
            // label_Y
            // 
            this.label_Y.AutoSize = true;
            this.label_Y.Location = new System.Drawing.Point(20, 84);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(21, 17);
            this.label_Y.TabIndex = 17;
            this.label_Y.Text = "Y:";
            // 
            // label_Listing
            // 
            this.label_Listing.AutoSize = true;
            this.label_Listing.Location = new System.Drawing.Point(188, 58);
            this.label_Listing.Name = "label_Listing";
            this.label_Listing.Size = new System.Drawing.Size(96, 17);
            this.label_Listing.TabIndex = 19;
            this.label_Listing.Text = "Listing koloru:";
            // 
            // textBox_R
            // 
            this.textBox_R.BackColor = System.Drawing.Color.Red;
            this.textBox_R.Location = new System.Drawing.Point(191, 84);
            this.textBox_R.Name = "textBox_R";
            this.textBox_R.Size = new System.Drawing.Size(31, 22);
            this.textBox_R.TabIndex = 20;
            // 
            // textBox_G
            // 
            this.textBox_G.BackColor = System.Drawing.Color.Lime;
            this.textBox_G.Location = new System.Drawing.Point(228, 84);
            this.textBox_G.Name = "textBox_G";
            this.textBox_G.Size = new System.Drawing.Size(31, 22);
            this.textBox_G.TabIndex = 21;
            // 
            // textBox_B
            // 
            this.textBox_B.BackColor = System.Drawing.Color.Blue;
            this.textBox_B.Location = new System.Drawing.Point(265, 84);
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.Size = new System.Drawing.Size(31, 22);
            this.textBox_B.TabIndex = 22;
            // 
            // button_pic1to2
            // 
            this.button_pic1to2.Location = new System.Drawing.Point(365, 273);
            this.button_pic1to2.Name = "button_pic1to2";
            this.button_pic1to2.Size = new System.Drawing.Size(75, 32);
            this.button_pic1to2.TabIndex = 23;
            this.button_pic1to2.Text = "==>";
            this.button_pic1to2.UseVisualStyleBackColor = true;
            this.button_pic1to2.Click += new System.EventHandler(this.button_pic1to2_Click);
            // 
            // button_pic2to1
            // 
            this.button_pic2to1.Location = new System.Drawing.Point(365, 236);
            this.button_pic2to1.Name = "button_pic2to1";
            this.button_pic2to1.Size = new System.Drawing.Size(75, 31);
            this.button_pic2to1.TabIndex = 24;
            this.button_pic2to1.Text = "<==";
            this.button_pic2to1.UseVisualStyleBackColor = true;
            this.button_pic2to1.Click += new System.EventHandler(this.button_pic2to1_Click);
            // 
            // button_toMono
            // 
            this.button_toMono.Location = new System.Drawing.Point(353, 327);
            this.button_toMono.Name = "button_toMono";
            this.button_toMono.Size = new System.Drawing.Size(100, 31);
            this.button_toMono.TabIndex = 25;
            this.button_toMono.Text = "MONO: ==>";
            this.button_toMono.UseVisualStyleBackColor = true;
            this.button_toMono.Click += new System.EventHandler(this.button_toMono_Click);
            // 
            // button_doGraph2
            // 
            this.button_doGraph2.Location = new System.Drawing.Point(670, 378);
            this.button_doGraph2.Name = "button_doGraph2";
            this.button_doGraph2.Size = new System.Drawing.Size(109, 33);
            this.button_doGraph2.TabIndex = 26;
            this.button_doGraph2.Text = "Wykres linii";
            this.button_doGraph2.UseVisualStyleBackColor = true;
            this.button_doGraph2.Click += new System.EventHandler(this.button_doGraph2_Click);
            // 
            // checkBox_R
            // 
            this.checkBox_R.AutoSize = true;
            this.checkBox_R.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.checkBox_R.Location = new System.Drawing.Point(365, 156);
            this.checkBox_R.Name = "checkBox_R";
            this.checkBox_R.Size = new System.Drawing.Size(40, 21);
            this.checkBox_R.TabIndex = 27;
            this.checkBox_R.Text = "R";
            this.checkBox_R.UseVisualStyleBackColor = false;
            // 
            // checkBox_G
            // 
            this.checkBox_G.AutoSize = true;
            this.checkBox_G.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.checkBox_G.Location = new System.Drawing.Point(365, 183);
            this.checkBox_G.Name = "checkBox_G";
            this.checkBox_G.Size = new System.Drawing.Size(41, 21);
            this.checkBox_G.TabIndex = 28;
            this.checkBox_G.Text = "G";
            this.checkBox_G.UseVisualStyleBackColor = false;
            // 
            // checkBox_B
            // 
            this.checkBox_B.AutoSize = true;
            this.checkBox_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.checkBox_B.Location = new System.Drawing.Point(366, 209);
            this.checkBox_B.Name = "checkBox_B";
            this.checkBox_B.Size = new System.Drawing.Size(39, 21);
            this.checkBox_B.TabIndex = 29;
            this.checkBox_B.TabStop = false;
            this.checkBox_B.Text = "B";
            this.checkBox_B.UseVisualStyleBackColor = false;
            // 
            // CW1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.checkBox_B);
            this.Controls.Add(this.checkBox_G);
            this.Controls.Add(this.checkBox_R);
            this.Controls.Add(this.button_doGraph2);
            this.Controls.Add(this.button_toMono);
            this.Controls.Add(this.button_pic2to1);
            this.Controls.Add(this.button_pic1to2);
            this.Controls.Add(this.textBox_B);
            this.Controls.Add(this.textBox_G);
            this.Controls.Add(this.textBox_R);
            this.Controls.Add(this.label_Listing);
            this.Controls.Add(this.label_Y);
            this.Controls.Add(this.label_X);
            this.Controls.Add(this.textBox_Y);
            this.Controls.Add(this.textBox_X);
            this.Controls.Add(this.button_doGraph1);
            this.Controls.Add(this.button_Clear2);
            this.Controls.Add(this.button_Clear1);
            this.Controls.Add(this.button_Camera2);
            this.Controls.Add(this.button_fromFile2);
            this.Controls.Add(this.button_Graphic2);
            this.Controls.Add(this.button_Camera1);
            this.Controls.Add(this.button_fromFile1);
            this.Controls.Add(this.button_Graphic1);
            this.Controls.Add(this.graphBox2);
            this.Controls.Add(this.graphBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CW1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox graphBox1;
        private System.Windows.Forms.PictureBox graphBox2;
        private System.Windows.Forms.Button button_Graphic1;
        private System.Windows.Forms.Button button_fromFile1;
        private System.Windows.Forms.Button button_Camera1;
        private System.Windows.Forms.Button button_Graphic2;
        private System.Windows.Forms.Button button_fromFile2;
        private System.Windows.Forms.Button button_Camera2;
        private System.Windows.Forms.Button button_Clear1;
        private System.Windows.Forms.Button button_Clear2;
        private System.Windows.Forms.Button button_doGraph1;
        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.TextBox textBox_Y;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Label label_Y;
        private System.Windows.Forms.Label label_Listing;
        private System.Windows.Forms.TextBox textBox_R;
        private System.Windows.Forms.TextBox textBox_G;
        private System.Windows.Forms.TextBox textBox_B;
        private System.Windows.Forms.Button button_pic1to2;
        private System.Windows.Forms.Button button_pic2to1;
        private System.Windows.Forms.Button button_toMono;
        private System.Windows.Forms.Button button_doGraph2;
        private System.Windows.Forms.CheckBox checkBox_R;
        private System.Windows.Forms.CheckBox checkBox_G;
        private System.Windows.Forms.CheckBox checkBox_B;
    }
}

