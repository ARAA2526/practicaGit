namespace ejercicioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = 'o';  // Por defecto ordinario
            int numPalabras = 0;
            double coste = 0;

            //Leo el telegrama 
            textoTelegrama = txtTelegrama.Text;

            //Comprobación del tipo de telegrama usando los radiobuttons
            if (rdiUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }
            else if (rdiOrdinario.Checked)
            {
                tipoTelegrama = 'o';
            }

            //Obtengo el número de palabras que forma el telegrama 
            string[] palabras = textoTelegrama.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            numPalabras = palabras.Length;

            //Si el telegrama es ordinario 
            if (tipoTelegrama == 'o')
            {
                if (numPalabras <= 10)
                {
                    coste = 2.5;
                }
                else
                {
                    coste = 2.5 + 0.5 * (numPalabras - 10);
                }
            }
            //Si el telegrama es urgente 
            else if (tipoTelegrama == 'u')
            {
                if (numPalabras <= 10)
                {
                    coste = 5;
                }
                else
                {
                    coste = 5 + 0.75 * (numPalabras - 10);
                }
            }

            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}
