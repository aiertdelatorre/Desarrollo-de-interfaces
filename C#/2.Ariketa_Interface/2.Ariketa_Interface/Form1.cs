using System.Windows.Forms.VisualStyles;

namespace _2.Ariketa_Interface
{
    public partial class Form1 : Form
    {

        public int counter = 1;
        public Kalkulatu k = new Kalkulatu();
        public float[] zenbakiak = new float[4];
        public List<Ariketa2> objektuak = new List<Ariketa2>();

        public Form1()
        {
            InitializeComponent();
        }

        public void Garbitu_OnClick(object sender, EventArgs e)
        {

        }

        public void Hurrengoa_OnClick(object sender, EventArgs e)
        {
           

            switch (counter)
            {
                case 1:
                    zenbakiak[0] = int.Parse(textBox1.Text);
                    objektuak.Add(new Ariketa2("Zenbakia1",zenbakiak[0]));
                    textBox1.Text = string.Empty;
                    counter++;
                    break;
                case 2:
                    zenbakiak[1] = int.Parse(textBox1.Text);
                    objektuak.Add(new Ariketa2("Zenbakia2", zenbakiak[1]));
                    textBox1.Text = string.Empty;
                    counter++;
                    break;
                case 3:
                    zenbakiak[2] = int.Parse(textBox1.Text);
                    objektuak.Add(new Ariketa2("Zenbakia3", zenbakiak[2]));
                    textBox1.Text = string.Empty;
                    counter++;
                    break;
                case 4:
                    zenbakiak[3] = int.Parse(textBox1.Text);
                    objektuak.Add(new Ariketa2("Zenbakia4", zenbakiak[3]));
                    textBox1.Text = zenbakiak[0] + "·1 + " + zenbakiak[1] + "·2 + " + zenbakiak[2]+ "·3 + " + zenbakiak[3] + "·4 = " + Kalkulatu.Eragiketa(objektuak).ToString();
                    break;
                    
            }
 

        }

        public void Irten_OnClick(object sender, EventArgs e)
        {

        }



    }
}