namespace Kalkulagailua
{
    public partial class Form1 : Form
    {
        Kalkulagailua k = new Kalkulagailua();
        public Form1()
        {
            InitializeComponent();
            /*this.ForeColor = Color.White;
            this.BackColor = Color.LightGray;*/
        }

        private void btnGehitu_Click(object sender, EventArgs e)
        {
            try{
                Balidazioa();
                MessageBox.Show(k.Gehiketa().ToString());
            }
            catch (Exception ex){
                MessageBox.Show("Sartutako zenbakiak ez dute formatu zuzena");
            }
        }

        private void btnKendu_Click(object sender, EventArgs e)
        {
            try
            {
                Balidazioa();
                MessageBox.Show(k.Gehiketa().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sartutako zenbakiak ez dute formatu zuzena");
            }
        }

        private void btnBiderkatu_Click(object sender, EventArgs e)
        {
            try
            {
                Balidazioa();
                MessageBox.Show(k.Gehiketa().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sartutako zenbakiak ez dute formatu zuzena");
            }
        }

        private void btnZatitu_Click(object sender, EventArgs e)
        {
            try
            {
                Balidazioa();
                MessageBox.Show(k.Gehiketa().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sartutako zenbakiak ez dute formatu zuzena");
            }
        }

        public void Balidazioa()
        {
            k.Zbk1 = float.Parse(txtzbk1.Text);
            k.Zbk2 = float.Parse(txtzbk2.Text);
        }

    }
}