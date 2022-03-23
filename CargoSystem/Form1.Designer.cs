namespace GMapDeneme
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.txt_Lat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetRouteInfo = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_musteri_id = new System.Windows.Forms.TextBox();
            this.txt_KargoID = new System.Windows.Forms.TextBox();
            this.btn_remote = new System.Windows.Forms.Button();
            this.btn_kuryeKaydet = new System.Windows.Forms.Button();
            this.txt_teslim = new System.Windows.Forms.TextBox();
            this.label_enlem = new System.Windows.Forms.Label();
            this.label_boylam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(739, 615);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(12, 12);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 18;
            this.map.MinZoom = 5;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(714, 591);
            this.map.TabIndex = 1;
            this.map.Zoom = 0D;
            this.map.Load += new System.EventHandler(this.map_Load);
            this.map.MouseClick += new System.Windows.Forms.MouseEventHandler(this.map_MouseClick);
            // 
            // txt_Lat
            // 
            this.txt_Lat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Lat.AutoSize = true;
            this.txt_Lat.Location = new System.Drawing.Point(827, 33);
            this.txt_Lat.Name = "txt_Lat";
            this.txt_Lat.Size = new System.Drawing.Size(47, 17);
            this.txt_Lat.TabIndex = 2;
            this.txt_Lat.Text = "Enlem";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(827, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Boylam";
            // 
            // btnGetRouteInfo
            // 
            this.btnGetRouteInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetRouteInfo.Location = new System.Drawing.Point(850, 355);
            this.btnGetRouteInfo.Name = "btnGetRouteInfo";
            this.btnGetRouteInfo.Size = new System.Drawing.Size(115, 75);
            this.btnGetRouteInfo.TabIndex = 9;
            this.btnGetRouteInfo.Text = "Rotayı Göster";
            this.btnGetRouteInfo.UseVisualStyleBackColor = true;
            this.btnGetRouteInfo.Click += new System.EventHandler(this.btnGetRouteInfo_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_kaydet.Location = new System.Drawing.Point(777, 518);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(125, 42);
            this.btn_kaydet.TabIndex = 11;
            this.btn_kaydet.Text = "Kargo Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(774, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Musteri_id";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(935, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "KargoID";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(774, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "teslimdurumu";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(902, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 16;
            // 
            // txt_musteri_id
            // 
            this.txt_musteri_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_musteri_id.Location = new System.Drawing.Point(766, 196);
            this.txt_musteri_id.Name = "txt_musteri_id";
            this.txt_musteri_id.Size = new System.Drawing.Size(100, 22);
            this.txt_musteri_id.TabIndex = 17;
            // 
            // txt_KargoID
            // 
            this.txt_KargoID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_KargoID.Location = new System.Drawing.Point(910, 196);
            this.txt_KargoID.Name = "txt_KargoID";
            this.txt_KargoID.Size = new System.Drawing.Size(100, 22);
            this.txt_KargoID.TabIndex = 18;
            // 
            // btn_remote
            // 
            this.btn_remote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_remote.Location = new System.Drawing.Point(872, 451);
            this.btn_remote.Name = "btn_remote";
            this.btn_remote.Size = new System.Drawing.Size(75, 44);
            this.btn_remote.TabIndex = 20;
            this.btn_remote.Text = "Geri Al";
            this.btn_remote.UseVisualStyleBackColor = true;
            this.btn_remote.Click += new System.EventHandler(this.btn_remote_Click);
            // 
            // btn_kuryeKaydet
            // 
            this.btn_kuryeKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_kuryeKaydet.Location = new System.Drawing.Point(929, 518);
            this.btn_kuryeKaydet.Name = "btn_kuryeKaydet";
            this.btn_kuryeKaydet.Size = new System.Drawing.Size(125, 42);
            this.btn_kuryeKaydet.TabIndex = 21;
            this.btn_kuryeKaydet.Text = "Kurye Kaydet";
            this.btn_kuryeKaydet.UseVisualStyleBackColor = true;
            this.btn_kuryeKaydet.Click += new System.EventHandler(this.btn_kuryekaydet_Click);
            // 
            // txt_teslim
            // 
            this.txt_teslim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_teslim.Location = new System.Drawing.Point(910, 246);
            this.txt_teslim.Name = "txt_teslim";
            this.txt_teslim.Size = new System.Drawing.Size(100, 22);
            this.txt_teslim.TabIndex = 22;
            // 
            // label_enlem
            // 
            this.label_enlem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_enlem.AutoSize = true;
            this.label_enlem.Location = new System.Drawing.Point(907, 33);
            this.label_enlem.Name = "label_enlem";
            this.label_enlem.Size = new System.Drawing.Size(0, 17);
            this.label_enlem.TabIndex = 23;
            // 
            // label_boylam
            // 
            this.label_boylam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_boylam.AutoSize = true;
            this.label_boylam.Location = new System.Drawing.Point(907, 71);
            this.label_boylam.Name = "label_boylam";
            this.label_boylam.Size = new System.Drawing.Size(0, 17);
            this.label_boylam.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 615);
            this.Controls.Add(this.label_boylam);
            this.Controls.Add(this.label_enlem);
            this.Controls.Add(this.txt_teslim);
            this.Controls.Add(this.btn_kuryeKaydet);
            this.Controls.Add(this.btn_remote);
            this.Controls.Add(this.txt_KargoID);
            this.Controls.Add(this.txt_musteri_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.btnGetRouteInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Lat);
            this.Controls.Add(this.map);
            this.Controls.Add(this.splitter1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Label txt_Lat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetRouteInfo;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_musteri_id;
        private System.Windows.Forms.TextBox txt_KargoID;
        private System.Windows.Forms.Button btn_remote;
        private System.Windows.Forms.Button btn_kuryeKaydet;
        private System.Windows.Forms.TextBox txt_teslim;
        private System.Windows.Forms.Label label_enlem;
        private System.Windows.Forms.Label label_boylam;
    }
}

