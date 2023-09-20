

namespace Esaldiak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Esaldia esaldia = new Esaldia();

        private void Esaldi1_Click(object sender, EventArgs e)
        {
            esaldia.EsaldiaBatu(textBoxa.Text);
            Esaldi1.Enabled = false;
            Esaldi2.Enabled = true;
            textBoxa.Text = string.Empty;
        }

        private void Esaldi3_Click(object sender, EventArgs e)
        {
            esaldia.EsaldiaBatu(textBoxa.Text);
            Esaldi3.Enabled = false;
            Esaldi4.Enabled = true;
            textBoxa.Text = string.Empty;

        }

        private void Esaldi4_Click(object sender, EventArgs e)
        {
            esaldia.EsaldiaBatu(textBoxa.Text);
            Esaldi4.Enabled = false;
            Esaldi5.Enabled = true;
            textBoxa.Text = string.Empty;
        }

        private void Esaldi2_Click(object sender, EventArgs e)
        {
            esaldia.EsaldiaBatu(textBoxa.Text);
            Esaldi2.Enabled = false;
            Esaldi3.Enabled = true;
            textBoxa.Text = string.Empty;
        }

        private void Esaldi5_Click(object sender, EventArgs e)
        {
            esaldia.EsaldiaBatu(textBoxa.Text);
            Esaldi5.Enabled = false;
            Lotu.Enabled = true;
            textBoxa.Text = string.Empty;
        }

        private void Lotu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(esaldia.EsaldiaBatuta);
            textBoxa.Text = string.Empty;
         }
        private void Ezabatu_Click(object sender, EventArgs e)
        {
            esaldia.EsaldiaBatuta = "";
            Lotu.Enabled=false;
            Esaldi1.Enabled = true;
        }
        private void Itxi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}