using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace NisargAssignment2
{
    public partial class TotalSales : Form
    {
        public TotalSales()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// the method will read all the data of the file line by line and would store that into an array of decimal type.
        /// the method also counts the total of the values in the array and it adds the values of the array as items in the result list box as well as it adds the value of total.
        /// </summary>
        private void CountTotals()
        {
            //creating an array with the size of 7 to save all the 7 values provided in the file.
            decimal[] salesvalue = new decimal[7];

            //creating a new object of StreamReader in order to read a file.
            StreamReader inputDataFile;
            //using the object created above to read the file "Sales.txt".
            inputDataFile = File.OpenText("Sales.txt");

            //creating and initializing a variable named total which we will use to count the totals later.
            decimal total = 0.0m;

            //using for loop in order to add all the arrays to get the value of total.
            for (int j = 0; j < salesvalue.Length && !inputDataFile.EndOfStream; j++)
            {
                salesvalue[j] = decimal.Parse(inputDataFile.ReadLine());
                total += salesvalue[j]; 
            }

            //adding the values of the array to the list box as items.
            for (int i = 0; i < salesvalue.Length; i++)
            {
                resultListBox.Items.Add(salesvalue[i]);
            }

            //adding the value of total to the list box as items.
            resultListBox.Items.Add("Total Sales Value: " + total);
            //closing the file using the object we created above.
            inputDataFile.Close();
        }

        /// <summary>
        /// the method performs the average, minimum and maximum of all the sales value and adds them to the list box as items.
        /// </summary>
        private void PerformMathOprations()
        {
            decimal[] salesvalue = new decimal[7];
            StreamReader inputDataFile;
            inputDataFile = File.OpenText("Sales.txt");
            decimal total = 0.0m;

            //counting the totals again in order to use it later to find the average of the sales.
            for (int index = 0; index < salesvalue.Length && !inputDataFile.EndOfStream; index++)
            {
                salesvalue[index] = decimal.Parse(inputDataFile.ReadLine());
                total += salesvalue[index];
            }

            //counting the average by dividing the total by the length of salesvalue.
            decimal averagevalue = total / (salesvalue.Length);
            //using the round function in Math to round the average upto 2 points.
            decimal roundedaverage = Math.Round(averagevalue, 2);
            //using Min() function in System.Linq to get the minimum value.
            decimal minimumvalue = salesvalue.Min();
            //using Max() function in System.Linq to get the maximum value.
            decimal maximumvalue = salesvalue.Max();

            //adding the rounded average, minimum value and maximum value to the list box.
            resultListBox.Items.Add("Average Sales Value: " + roundedaverage);
            resultListBox.Items.Add("Minimum Sales Value: " + minimumvalue);
            resultListBox.Items.Add("Maximum Sales Value: " + maximumvalue);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes the form.
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //cleas the items everytime the button is clicked.
            resultListBox.Items.Clear();
            //calling CountTotals method.
            CountTotals();
            //calling PerformMathOperations method.
            PerformMathOprations();
        }
    }
}
