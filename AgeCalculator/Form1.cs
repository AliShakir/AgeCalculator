using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Display();
        }
        public void Display()
        {
            DateTime date = DateTime.Now;
           // DateTime BirthDate = new DateTime(1985, 2, 11, 0, 0, 0);
            TimeSpan diffResult = date.Subtract(dtpDob.Value);
            string Months = ((diffResult.Days) % 365).ToString();
            string RemainingMonths = (Convert.ToInt32(Months) / 31).ToString();
            string RemainginYears = ((diffResult.Days) / 365).ToString();
            string RemainingDays = (Convert.ToInt32(Months) % 31).ToString();
            lblYears.Text = RemainginYears.ToString()+" Years";
            lblMonths.Text = RemainingMonths.ToString() + " Months";
            lblDays.Text = RemainingDays.ToString() + " Days old";
            //MessageBox.Show(RemainginYears + "-" + RemainingMonths + "-" + RemainingDays);
        }
    }
}
