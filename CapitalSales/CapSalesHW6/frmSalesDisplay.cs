using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapitalSales
{
    public partial class frmSalesDisplay : Form
    {
        public frmSalesDisplay()
        {
            InitializeComponent();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void DisplaySales(SalesCollection salesCollection)
        {
            rtbOutput.Text = salesCollection.ToString();
        }
    }
}
