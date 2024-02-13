namespace resim_ornek
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
            this.ppResim = new System.Windows.Forms.PictureBox();
            this.btnRenk = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.rbtMesaj = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ppResim)).BeginInit();
            this.SuspendLayout();
            // 
            // ppResim
            // 
            this.ppResim.Location = new System.Drawing.Point(33, 153);
            this.ppResim.Name = "ppResim";
            this.ppResim.Size = new System.Drawing.Size(203, 209);
            this.ppResim.TabIndex = 0;
            this.ppResim.TabStop = false;
            // 
            // btnRenk
            // 
            this.btnRenk.Location = new System.Drawing.Point(33, 64);
            this.btnRenk.Name = "btnRenk";
            this.btnRenk.Size = new System.Drawing.Size(119, 48);
            this.btnRenk.TabIndex = 1;
            this.btnRenk.Text = "renk seç";
            this.btnRenk.UseVisualStyleBackColor = true;
            this.btnRenk.Click += new System.EventHandler(this.btnRenk_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(316, 64);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(119, 48);
            this.btnDegistir.TabIndex = 2;
            this.btnDegistir.Text = "renk değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // rbtMesaj
            // 
            this.rbtMesaj.Location = new System.Drawing.Point(316, 153);
            this.rbtMesaj.Name = "rbtMesaj";
            this.rbtMesaj.Size = new System.Drawing.Size(234, 209);
            this.rbtMesaj.TabIndex = 4;
            this.rbtMesaj.Text = "irem\nyasemin\nceren\nnazlı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtMesaj);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnRenk);
            this.Controls.Add(this.ppResim);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ppResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ppResim;
        private System.Windows.Forms.Button btnRenk;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.RichTextBox rbtMesaj;
    }
}

