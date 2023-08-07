namespace Exercise_mayor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string strNumOne = InputNum1.Text;
            string strNumTwo = InputNum2.Text;
            string strNumThree = InputNum3.Text;

            double numOne = double.Parse(strNumOne);
            double numTwo = double.Parse(strNumTwo);
            double numThree = double.Parse(strNumThree);

            double numMayor = numThree;
            double numMenor = numOne;

            if (numOne > numMayor) numMayor= numOne;
            if (numTwo > numMayor) numMayor = numTwo;

            MessageBox.Show($"El numero mayor es:{numMayor}");

            if (numTwo < numMenor) numMenor= numOne;
            if(numThree <numMenor) numMenor= numThree;
            
            MessageBox.Show($"El numero menor es:{numMenor}");
        }
    }
}