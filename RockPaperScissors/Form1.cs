using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NisargAssignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rpsGameButton_Click(object sender, EventArgs e)
        {
            //creating a new object of RockPaperScissors class that we are using for our new form with the same name.
            RockPaperScissors rpsform = new RockPaperScissors();
            //shows the form using the object we created above.
            rpsform.Show();
        }

        private void totalSalesButton_Click(object sender, EventArgs e)
        {
            //creating a new object of TotalSales class that we are using for our new form with the same name.
            TotalSales salesform = new TotalSales();
            //shows the form using the object we created above.
            salesform.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closing the current form.
            this.Close();
        }
    }
}
