namespace Aprendiendo_C__1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string stringPeso = InputPeso.Text;
            double peso = double.Parse(stringPeso);
            string stringAltura = InputAltura.Text;
            double altura = double.Parse(stringAltura);

            double imc = (peso / (altura * altura)) * 10000;

            MessageBox.Show($"Tu imc es:{imc}");
        }
    }
}