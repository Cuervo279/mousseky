using System.Drawing.Imaging;
using System.Net;
using System.Windows.Forms;
using Utilitarios;
using YoutubeExplode;
using YoutubeExplode.Videos;

namespace Mousseky
{
    public partial class frmYoutube : Form
    {
        private readonly System.Windows.Forms.Timer _animTimer = new();
        private Size _originalSize;
        private bool _zoomIn;
        private const int MaxIncrease = 5;
        private const int Step = 2;

        private bool isDarkTheme = true;

        public frmYoutube()
        {
            InitializeComponent();

            imgTheme.EnableHoverZoom();               // padrão: +5 px, step 2
            btnX.EnableHoverZoom(8, 3);            // exemplo com outro tamanho
            pictureBox1.EnableHoverZoom(maxIncrease: 7);

            TrocaCursor();
            SelecionaTema();
            ResetContainer();
        }

        private async Task YoutubeAPI(string url)
        {
            try
            {
                var youtube = new YoutubeClient();

                var videoUrl = url;
                var video = await youtube.Videos.GetAsync(videoUrl);

                var title = video.Title; // "Collections - Blender 2.80 Fundamentals"
                var author = video.Author.ChannelTitle; // "Blender"
                var duration = video.Duration; // 00:07:20
                var thumbnails = video.Thumbnails[0].Url;


                await SaveImageAsync(thumbnails, imgMiniatura);

                PreencheCard(title, author, duration);




            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private async void txtUrl_TextChanged(object sender, EventArgs e)
        {
            var url = txtUrl.Text;

            if (url.Contains("https://www.youtube.com/watch?v="))
            {
                await YoutubeAPI(url);
            }
        }

        private void PreencheCard(string titulo, string autor, TimeSpan? duracao)
        {

            lblNomeVideo.Text = titulo;
            lblDuracaoVideo.Text = duracao.ToString();
        }


        private async Task SaveImageAsync(string url, PictureBox pictureBox)
        {
            using var http = new HttpClient();
            http.Timeout = TimeSpan.FromSeconds(10);

            try
            {
                int index = url.IndexOf(".jpg", StringComparison.OrdinalIgnoreCase);
                string cleanUrl = index >= 0 ? url.Substring(0, index + 4) : url;

                var bytes = await http.GetByteArrayAsync(cleanUrl);

                using var ms = new MemoryStream(bytes);
                var img = Image.FromStream(ms);

                if (pictureBox.Image != null)
                    pictureBox.Image.Dispose();

                pictureBox.Image = img;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar imagem: {ex.Message}");
            }
        }

        private void imgTheme_MouseEnter(object sender, EventArgs e)
        {

        }


        private void TrocaCursor()
        {
            imgTheme.Cursor = Cursors.Hand;
            btnX.Cursor = Cursors.Hand;
            btnAddLista.Cursor = Cursors.Hand;
            btnDownload.Cursor = Cursors.Hand;
        }

        private void imgTheme_MouseClick(object sender, MouseEventArgs e)
        {
            SelecionaTema();
        }

        private void SelecionaTema()
        {
            if (isDarkTheme)
            {
                imgTheme.Image = Properties.Resources.sun;
                icoTempo.Image = Properties.Resources.wall_clock_dark;
                btnX.Image = Properties.Resources.close_dark;

                isDarkTheme = false;
                this.BackColor = Color.FromArgb(40, 40, 40);

                SetCor(this, "pnl", Color.FromArgb(50, 50, 50));

            }
            else
            {
                imgTheme.Image = Properties.Resources.moon;
                icoTempo.Image = Properties.Resources.wall_clock_light;
                btnX.Image = Properties.Resources.close_light;

                isDarkTheme = true;
                this.BackColor = SystemColors.Control;

                SetCor(this, "pnl", SystemColors.ControlLight);
            }
        }


        /// <summary>
        /// Altera a cor de fundo de todos os elementos cujo nome começa com "pnl", de forma recursiva.
        /// </summary>
        /// <param name="pai">O controle pai (geralmente o formulário ou um container).</param>
        /// <param name="tipo">Nome do elemento (geralmente uma sigla).</param>
        /// <param name="corDesejada">A cor que será aplicada como fundo.</param>

        private void SetCor(Control pai, string tipo, Color corDesejada)
        {
            foreach (Control ctl in pai.Controls)
            {
                if (ctl is Panel && ctl.Name.StartsWith(tipo, StringComparison.OrdinalIgnoreCase))
                    ctl.BackColor = corDesejada;

                if (ctl.HasChildren)
                    SetCor(ctl, tipo, corDesejada);
            }
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNomeVideo_TextChanged(object sender, EventArgs e)
        {
            if(txtUrl.Text.Contains("youtube"))
            {
                imgIconVideo.Image = Properties.Resources.youtube;
            }

            else if (txtUrl.Text.Contains("spotify"))
            {
                imgIconVideo.Image = Properties.Resources.spotify;
            }

            else
            {
                imgIconVideo.Image = null;
            }
        }


        private async Task ResetContainer()
        {
            lblNomeVideo.Text = "";
            lblDuracaoVideo.Text = "";

            icoTempo.Visible = false;
        }

    }
}
