using System;
using System.Windows.Forms;
using Google.Apis.Urlshortener.v1;

namespace URLShortner
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        UrlshortenerService shorten = new UrlshortenerService();

        private void btnClipboard_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetText() == "")
                MessageBox.Show("Please copy the long URL to the clipboard first.");
            else
                txtLink.Text = Clipboard.GetText();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLink.Clear();
        }

        private void btnShorten_Click(object sender, EventArgs e)
        {
            bool linkcheck = txtLink.Text.StartsWith("http://");
            if (linkcheck != true)
                MessageBox.Show("Check the link and try again.");
            else
            {
                string shortenedlink = "";

                //
                //Code To Parse The Link Using Goo.gl URL Shorten Service
                //

                Clipboard.SetText(shortenedlink);
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new AboutFrm().ShowDialog();
        }
    }
}