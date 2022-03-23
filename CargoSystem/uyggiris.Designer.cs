namespace GMapDeneme
{
    partial class uyggiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtkullaniciadi = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_hesapolustur = new System.Windows.Forms.Button();
            this.btn_sifreguncelle = new System.Windows.Forms.Button();
            this.btn_girisyap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // txtkullaniciadi
            // 
            this.txtkullaniciadi.Location = new System.Drawing.Point(397, 115);
            this.txtkullaniciadi.Name = "txtkullaniciadi";
            this.txtkullaniciadi.Size = new System.Drawing.Size(100, 22);
            this.txtkullaniciadi.TabIndex = 1;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(397, 212);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(100, 22);
            this.txtsifre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // btn_hesapolustur
            // 
            this.btn_hesapolustur.Location = new System.Drawing.Point(164, 275);
            this.btn_hesapolustur.Name = "btn_hesapolustur";
            this.btn_hesapolustur.Size = new System.Drawing.Size(145, 46);
            this.btn_hesapolustur.TabIndex = 4;
            this.btn_hesapolustur.Text = "Hesap Oluştur";
            this.btn_hesapolustur.UseVisualStyleBackColor = true;
            this.btn_hesapolustur.Click += new System.EventHandler(this.btn_hesapolustur_Click_1);
            // 
            // btn_sifreguncelle
            // 
            this.btn_sifreguncelle.Location = new System.Drawing.Point(333, 275);
            this.btn_sifreguncelle.Name = "btn_sifreguncelle";
            this.btn_sifreguncelle.Size = new System.Drawing.Size(132, 46);
            this.btn_sifreguncelle.TabIndex = 5;
            this.btn_sifreguncelle.Text = "Şifremi Güncelle";
            this.btn_sifreguncelle.UseVisualStyleBackColor = true;
            this.btn_sifreguncelle.Click += new System.EventHandler(this.btn_sifreguncelle_Click_1);
            // 
            // btn_girisyap
            // 
            this.btn_girisyap.Location = new System.Drawing.Point(488, 275);
            this.btn_girisyap.Name = "btn_girisyap";
            this.btn_girisyap.Size = new System.Drawing.Size(112, 46);
            this.btn_girisyap.TabIndex = 6;
            this.btn_girisyap.Text = "Giriş";
            this.btn_girisyap.UseVisualStyleBackColor = true;
            this.btn_girisyap.Click += new System.EventHandler(this.btn_girisyap_Click_1);
            // 
            // uyggiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_girisyap);
            this.Controls.Add(this.btn_sifreguncelle);
            this.Controls.Add(this.btn_hesapolustur);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtkullaniciadi);
            this.Controls.Add(this.label1);
            this.Name = "uyggiris";
            this.Text = "uyggiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkullaniciadi;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_hesapolustur;
        private System.Windows.Forms.Button btn_sifreguncelle;
        private System.Windows.Forms.Button btn_girisyap;
    }
}