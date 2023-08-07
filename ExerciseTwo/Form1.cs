namespace ExerciseTwo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            string strNumOne = InputOne.Text;
            string strNumTwo = InputTwo.Text;
            string strNumThree = InputThree.Text;

            int numOne = int.Parse(strNumOne);
            int numTwo = int.Parse(strNumTwo);
            int numThree = int.Parse(strNumThree);

            float promedio = (numOne + numThree + numTwo) / 3;

            MessageBox.Show($"El promedio de los tres es:{promedio}");
        }
    }
}