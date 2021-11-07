using MyArrayLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayWinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ArrayLenBtn_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(arrayLenInput.Text, out int len) || len < 0)
            {
                throw new Exception("You should input natural number");
            }

            MyArray mainArray = new MyArray(new double[len]);
        }
    }
}
