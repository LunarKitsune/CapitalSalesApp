/*
 *  Ken Macneal 
 *  10/26/2019
 *  Capital Sales App V2 Alpha
 * 
*/   

using System;
using System.Windows.Forms;

namespace CapitalSales
{
    public partial class frmMain : Form
    {
        //instantiating a saleslist object, a file reader/writer
        //and having a true/false for a form state
        SalesCollection salesList = new SalesCollection();
        fileProcessor dataProcessor = new fileProcessor();
        public bool isSaveState = false;

        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            //loads the data from a file to the salesList object where its stored
            //in a dictionary collection
            dataProcessor.readSalesFile(salesList);

            //gets all IDs in the comboBox
            foreach(SalesPerson saleItem in salesList.GetSalesPeople)
            {
                txtID.Items.Add(saleItem.ID);
            }
        }

        #region Form Buttons

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            errProvider.Clear();

            //use save state to determine what happpens with the form
            if (isSaveState)
            {
                if (ValidateData())
                {
                    SalesPerson person = new SalesPerson()
                    { ID = txtID.Text, Name = txtName.Text, Amount = double.Parse(txtAmount.Text) };

                    try
                    {
                        //add the record an clear necessary fields
                        salesList.AddRecord(person);
                        txtID.Items.Add(person.ID);
                        txtName.Text = string.Empty;
                        txtAmount.Text = string.Empty;

                        isSaveState = SwitchState(isSaveState);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
            }
            else
            {
                //switch to save state if not in save mode
                isSaveState = SwitchState(isSaveState);
                clearFields();
            }
        }

        private void btnRemoveCancel_Click(object sender, EventArgs e)
        {
            //validates removal of record
            bool validRemoval = txtID.Items.Count > 0 && txtID.Text != string.Empty;

            if (!isSaveState)
            {
                if (validRemoval)
                {
                    //dialog for record removal
                    DialogResult removeResult = MessageBox.Show("Remove salesperson?", "Sale Record", MessageBoxButtons.YesNo);

                    if (removeResult == DialogResult.Yes)
                    {
                        //if removing record remove at the index of the dictionary
                        //and clear the fields
                        salesList.DeleteRecord(txtID.Text);
                        txtID.Items.RemoveAt(txtID.SelectedIndex);
                        clearFields();
                    }
                }
                else
                {
                    MessageBox.Show("No sale to remove!", "Error");
                }
            }
            else
            {
                //clears the error provider and reverts the state
                //of the form
                errProvider.Clear();
                isSaveState = SwitchState(isSaveState);
            }
        }

        private void btnTotalDisplay_Click(object sender, EventArgs e)
        {
            double total = salesList.RecordTotal();
            MessageBox.Show($"Total of all sales is: {total:C}","Sales Total");
        }

        private void btnAllSales_Click(object sender, EventArgs e)
        {
            frmSalesDisplay salesDisplay = new frmSalesDisplay();
            salesDisplay.DisplaySales(salesList);

            salesDisplay.Show();
        }

        private void btnIDFind_Click(object sender, EventArgs e)
        {
            errProvider.Clear();

            if (txtFindID.Text == string.Empty)
            {
                errProvider.SetError(txtFindID, "Input Required");
            }
            else
            {
                SalesPerson person = salesList.FindSale(txtFindID.Text);
                if (person != null)
                {
                    txtID.Text = person.ID;
                    txtName.Text = person.Name;
                    txtAmount.Text = $"{person.Amount}";
                }
                else
                {
                    MessageBox.Show("Record not found", "Find");
                }
            }
        }

        #endregion Form Buttons

        #region General Form Methods

        public bool ValidateData()
        {
            if(txtID.Text == string.Empty)
            {
                errProvider.SetError(txtID, "Input Required");
                txtID.Focus();
                return false;
            }
            else
            {
                if(txtName.Text == string.Empty)
                {
                    errProvider.SetError(txtName, "Input Required");
                    txtName.Focus();
                    return false;
                }
                else
                {
                    if(txtAmount.Text == string.Empty)
                    {
                        errProvider.SetError(txtAmount, "Input Required");
                        txtAmount.Focus();
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }

        //switches thee state of the form
        public bool SwitchState(bool state)
        {
            if(state == false)
            {
                btnAddSave.Text = "Save";
                btnRemoveCancel.Text = "Cancel";
                clearFields();
                txtAmount.Enabled = true;
                txtAmount.ReadOnly = false;
                txtName.Enabled = true;
                txtName.ReadOnly = false;
                txtFindID.Enabled = false;
                btnIDFind.Enabled = false;
                return true;
            }
            else
            {
                btnAddSave.Text = "Add";
                btnRemoveCancel.Text = "Remove";
                txtAmount.Enabled = false;
                txtName.Enabled = false;
                txtFindID.Enabled = true;
                txtFindID.ReadOnly = false;
                btnIDFind.Enabled = true;
                return false;
            }
        }

        //clears necessary fields
        public void clearFields()
        {
            txtID.Text = string.Empty;
            txtAmount.Text = string.Empty;
            txtName.Text = string.Empty;
        }
            
        #endregion General Form Methods

        #region General Form Events

        //validates keystrokes caused by a user
        public void ValidKey_KeyEvent(object sender, KeyPressEventArgs e)
        {
            //grabs the ascii key by implicitly converting a char value to an integer
            //then the ascii key is verified within a range or a certain set of numbers
            //to filter certain characters
            int asciiKey = (int)e.KeyChar;
            bool isValid = asciiKey >= 48 && asciiKey <= 57 || (asciiKey == 8 || asciiKey == 46);

            //if false, keystroke is put into a control, else keystroke doesn't go through
            e.Handled = isValid ? false : true;
        }

        public void ConfirmClose_FormEvent(object sender, FormClosingEventArgs e)
        {
            DialogResult appCloseResult = MessageBox.Show("Exit Application?", "Exit", MessageBoxButtons.YesNo);

            if(appCloseResult == DialogResult.Yes)
            {
                dataProcessor.LogSales(salesList);
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void txtID_SelectedIndexChanged(object sender, EventArgs e)
        {
            SalesPerson personItem = salesList.FindSale(txtID.Text);

            txtAmount.Text = $"{personItem.Amount}";
            txtName.Text = personItem.Name;
        }

        #endregion General Form Events

    }
}
