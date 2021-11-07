using MyArrayLibrary;
using System;
using System.Windows.Forms;

namespace ArrayWinFormsApp
{
    public partial class SumForm : Form
    {
        public SumForm()
        {
            InitializeComponent();
        }

        private void SumForm_Load(object sender, EventArgs e)
        {
            MyArray newArray = Service.CreateArrayByRandom(MainForm.MainArray.ArrLenght);

            labelArr1.Text = $"Массив 1: {MainForm.MainArray}";
            labelArr2.Text = $"Массив 2: {newArray}";

            labelSum.Text = $"Сумма: {MainForm.MainArray + newArray}";
        }
    }
}
