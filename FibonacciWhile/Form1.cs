namespace FibonacciWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            // Analiza los dos primeros numeros en la secuencia
            int oldNumber = 0;
            int currentNumber = 1;
            int n = int.Parse(intNumber.Text);
            int resultado;


            while (currentNumber < n)
            {
                //Calcula el siguient enumero agregando la valor actual al numero anterior
                resultado = currentNumber + oldNumber;
                oldNumber = currentNumber;
                currentNumber = resultado;
                MessageBox.Show(currentNumber.ToString());
            }

        }
    }
}