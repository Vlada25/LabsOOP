using MyArrayLibrary;
using MyExceptionLibrary;
using System;
using System.Windows.Forms;

namespace ArrayWinFormsApp
{
    public partial class MainForm : Form
    {
        public static MyArray MainArray;
        public MainForm()
        {
            InitializeComponent();
        }

        private void ArrayLenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(arrayLenInput.Text, out int len) || len < 0)
                {
                    throw new MyException("You should input natural number", arrayLenInput.Text);
                }

                MainArray = Service.CreateArrayByRandom(len);

                arrayLabel.Text = $"Массив: {MainArray}";
            }
            catch (MyException error)
            {
                MessageBox.Show($"{error.Message} (Incorrect: {error.Value})", "Error!");
            }
        }

        private void SumBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MainArray == null)
                {
                    throw new MyException("You should generate the main array");
                }

                SumForm sumForm = new SumForm();
                sumForm.Show();
            }
            catch(MyException error)
            {
                MessageBox.Show(error.Message, "Error!");
            }
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MainArray == null)
                {
                    throw new MyException("You should generate the main array");
                }

                double value = Convert.ToDouble(multiplyInput.Text);
                MainArray = MainArray * value;

                arrayLabel.Text = $"Массив: {MainArray}";
            }
            catch (MyException error)
            {
                MessageBox.Show(error.Message, "Error!");
            }
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MainArray == null)
                {
                    throw new MyException("You should generate the main array");
                }

                double value = Convert.ToDouble(divideInput.Text);
                MainArray = MainArray / value;

                arrayLabel.Text = $"Массив: {MainArray}";
            }
            catch (MyException error)
            {
                MessageBox.Show(error.Message, "Error!");
            }
        }
    }
}
