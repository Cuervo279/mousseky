namespace Mousseky
{
    partial class frmYoutube
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYoutube));
            txtUrl = new TextBox();
            btnAddLista = new Button();
            btnDownload = new Button();
            pnlMain = new Panel();
            imgIconVideo = new PictureBox();
            comboBox1 = new ComboBox();
            btnX = new PictureBox();
            imgMiniatura = new PictureBox();
            lblDuracaoVideo = new Label();
            lblNomeVideo = new Label();
            pnlListaContainer = new Panel();
            pnlLista1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            vScrollBar1 = new VScrollBar();
            imgTheme = new PictureBox();
            lblLink = new Label();
            imageList1 = new ImageList(components);
            icoTempo = new PictureBox();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgIconVideo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgMiniatura).BeginInit();
            pnlListaContainer.SuspendLayout();
            pnlLista1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgTheme).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icoTempo).BeginInit();
            SuspendLayout();
            // 
            // txtUrl
            // 
            txtUrl.BorderStyle = BorderStyle.None;
            txtUrl.Location = new Point(45, 34);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(680, 16);
            txtUrl.TabIndex = 0;
            txtUrl.TextChanged += txtUrl_TextChanged;
            // 
            // btnAddLista
            // 
            btnAddLista.BackColor = Color.FromArgb(29, 29, 29);
            btnAddLista.FlatStyle = FlatStyle.Flat;
            btnAddLista.ForeColor = SystemColors.Control;
            btnAddLista.Location = new Point(517, 70);
            btnAddLista.Name = "btnAddLista";
            btnAddLista.Size = new Size(75, 23);
            btnAddLista.TabIndex = 1;
            btnAddLista.Text = "+ Lista";
            btnAddLista.UseVisualStyleBackColor = false;
            // 
            // btnDownload
            // 
            btnDownload.BackColor = Color.Red;
            btnDownload.FlatAppearance.BorderColor = Color.Red;
            btnDownload.FlatAppearance.BorderSize = 0;
            btnDownload.FlatStyle = FlatStyle.Flat;
            btnDownload.ForeColor = SystemColors.Control;
            btnDownload.Location = new Point(598, 71);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(75, 23);
            btnDownload.TabIndex = 2;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = false;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = SystemColors.ControlLight;
            pnlMain.Controls.Add(icoTempo);
            pnlMain.Controls.Add(imgIconVideo);
            pnlMain.Controls.Add(comboBox1);
            pnlMain.Controls.Add(btnX);
            pnlMain.Controls.Add(imgMiniatura);
            pnlMain.Controls.Add(lblDuracaoVideo);
            pnlMain.Controls.Add(lblNomeVideo);
            pnlMain.Controls.Add(btnAddLista);
            pnlMain.Controls.Add(btnDownload);
            pnlMain.Location = new Point(45, 67);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(680, 104);
            pnlMain.TabIndex = 3;
            pnlMain.Paint += pnlMain_Paint;
            // 
            // imgIconVideo
            // 
            imgIconVideo.Image = Properties.Resources.youtube;
            imgIconVideo.Location = new Point(208, 14);
            imgIconVideo.Name = "imgIconVideo";
            imgIconVideo.Size = new Size(15, 15);
            imgIconVideo.SizeMode = PictureBoxSizeMode.StretchImage;
            imgIconVideo.TabIndex = 5;
            imgIconVideo.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "MP3", "MP4" });
            comboBox1.Location = new Point(208, 72);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // btnX
            // 
            btnX.Image = Properties.Resources.close_dark;
            btnX.Location = new Point(658, 7);
            btnX.Name = "btnX";
            btnX.Size = new Size(15, 15);
            btnX.SizeMode = PictureBoxSizeMode.StretchImage;
            btnX.TabIndex = 3;
            btnX.TabStop = false;
            // 
            // imgMiniatura
            // 
            imgMiniatura.BackColor = SystemColors.ActiveCaptionText;
            imgMiniatura.Location = new Point(9, 7);
            imgMiniatura.Name = "imgMiniatura";
            imgMiniatura.Size = new Size(172, 88);
            imgMiniatura.SizeMode = PictureBoxSizeMode.StretchImage;
            imgMiniatura.TabIndex = 2;
            imgMiniatura.TabStop = false;
            // 
            // lblDuracaoVideo
            // 
            lblDuracaoVideo.AutoSize = true;
            lblDuracaoVideo.Location = new Point(229, 38);
            lblDuracaoVideo.Name = "lblDuracaoVideo";
            lblDuracaoVideo.Size = new Size(97, 15);
            lblDuracaoVideo.TabIndex = 1;
            lblDuracaoVideo.Text = "{{DuracaoVideo}}";
            // 
            // lblNomeVideo
            // 
            lblNomeVideo.AutoSize = true;
            lblNomeVideo.Location = new Point(229, 14);
            lblNomeVideo.Name = "lblNomeVideo";
            lblNomeVideo.Size = new Size(86, 15);
            lblNomeVideo.TabIndex = 0;
            lblNomeVideo.Text = "{{NomeVideo}}";
            lblNomeVideo.TextChanged += lblNomeVideo_TextChanged;
            // 
            // pnlListaContainer
            // 
            pnlListaContainer.BackColor = SystemColors.ControlLight;
            pnlListaContainer.Controls.Add(pnlLista1);
            pnlListaContainer.Location = new Point(45, 204);
            pnlListaContainer.Name = "pnlListaContainer";
            pnlListaContainer.Size = new Size(680, 300);
            pnlListaContainer.TabIndex = 4;
            // 
            // pnlLista1
            // 
            pnlLista1.BackColor = SystemColors.ControlLight;
            pnlLista1.Controls.Add(pictureBox3);
            pnlLista1.Controls.Add(pictureBox1);
            pnlLista1.Controls.Add(label2);
            pnlLista1.Controls.Add(label3);
            pnlLista1.Location = new Point(0, 3);
            pnlLista1.Name = "pnlLista1";
            pnlLista1.Size = new Size(673, 126);
            pnlLista1.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.close_dark;
            pictureBox3.Location = new Point(658, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(15, 15);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(9, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 38);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(208, 14);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(728, 67);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 435);
            vScrollBar1.TabIndex = 0;
            // 
            // imgTheme
            // 
            imgTheme.Image = Properties.Resources.moon;
            imgTheme.Location = new Point(727, 12);
            imgTheme.Name = "imgTheme";
            imgTheme.Size = new Size(15, 15);
            imgTheme.SizeMode = PictureBoxSizeMode.StretchImage;
            imgTheme.TabIndex = 5;
            imgTheme.TabStop = false;
            imgTheme.MouseClick += imgTheme_MouseClick;
            imgTheme.MouseEnter += imgTheme_MouseEnter;
            // 
            // lblLink
            // 
            lblLink.AutoSize = true;
            lblLink.Location = new Point(45, 16);
            lblLink.Name = "lblLink";
            lblLink.Size = new Size(81, 15);
            lblLink.TabIndex = 6;
            lblLink.Text = "Link do video:";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "moon.png");
            imageList1.Images.SetKeyName(1, "sun.png");
            // 
            // icoTempo
            // 
            icoTempo.Image = Properties.Resources.wall_clock_light;
            icoTempo.Location = new Point(208, 38);
            icoTempo.Name = "icoTempo";
            icoTempo.Size = new Size(15, 15);
            icoTempo.SizeMode = PictureBoxSizeMode.StretchImage;
            icoTempo.TabIndex = 6;
            icoTempo.TabStop = false;
            // 
            // frmYoutube
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 524);
            Controls.Add(lblLink);
            Controls.Add(vScrollBar1);
            Controls.Add(imgTheme);
            Controls.Add(pnlListaContainer);
            Controls.Add(pnlMain);
            Controls.Add(txtUrl);
            Name = "frmYoutube";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgIconVideo).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnX).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgMiniatura).EndInit();
            pnlListaContainer.ResumeLayout(false);
            pnlLista1.ResumeLayout(false);
            pnlLista1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgTheme).EndInit();
            ((System.ComponentModel.ISupportInitialize)icoTempo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUrl;
        private Button btnAddLista;
        private Button btnDownload;
        private Panel pnlMain;
        private Panel pnlListaContainer;
        private VScrollBar vScrollBar1;
        private Label lblDuracaoVideo;
        private Label lblNomeVideo;
        private PictureBox imgMiniatura;
        private PictureBox imgTheme;
        private Label lblLink;
        private Panel pnlLista1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private PictureBox btnX;
        private PictureBox pictureBox3;
        private ImageList imageList1;
        private ComboBox comboBox1;
        private PictureBox imgIconVideo;
        private PictureBox icoTempo;
    }
}
