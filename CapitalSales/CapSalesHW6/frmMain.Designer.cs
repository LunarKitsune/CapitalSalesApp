namespace CapitalSales
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddSave = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.ComboBox();
            this.btnRemoveCancel = new System.Windows.Forms.Button();
            this.btnAllSales = new System.Windows.Forms.Button();
            this.btnTotalDisplay = new System.Windows.Forms.Button();
            this.btnIDFind = new System.Windows.Forms.Button();
            this.txtFindID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(73, 70);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidKey_KeyEvent);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(73, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount:";
            // 
            // btnAddSave
            // 
            this.btnAddSave.Location = new System.Drawing.Point(203, 4);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(89, 35);
            this.btnAddSave.TabIndex = 4;
            this.btnAddSave.Text = "&Add";
            this.btnAddSave.UseVisualStyleBackColor = true;
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // txtID
            // 
            this.txtID.FormattingEnabled = true;
            this.txtID.Location = new System.Drawing.Point(73, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 21);
            this.txtID.TabIndex = 0;
            this.txtID.SelectedIndexChanged += new System.EventHandler(this.txtID_SelectedIndexChanged);
            // 
            // btnRemoveCancel
            // 
            this.btnRemoveCancel.Location = new System.Drawing.Point(203, 44);
            this.btnRemoveCancel.Name = "btnRemoveCancel";
            this.btnRemoveCancel.Size = new System.Drawing.Size(89, 35);
            this.btnRemoveCancel.TabIndex = 5;
            this.btnRemoveCancel.Text = "&Remove";
            this.btnRemoveCancel.UseVisualStyleBackColor = true;
            this.btnRemoveCancel.Click += new System.EventHandler(this.btnRemoveCancel_Click);
            // 
            // btnAllSales
            // 
            this.btnAllSales.Location = new System.Drawing.Point(203, 124);
            this.btnAllSales.Name = "btnAllSales";
            this.btnAllSales.Size = new System.Drawing.Size(89, 35);
            this.btnAllSales.TabIndex = 7;
            this.btnAllSales.Text = "All &Sales";
            this.btnAllSales.UseVisualStyleBackColor = true;
            this.btnAllSales.Click += new System.EventHandler(this.btnAllSales_Click);
            // 
            // btnTotalDisplay
            // 
            this.btnTotalDisplay.Location = new System.Drawing.Point(203, 83);
            this.btnTotalDisplay.Name = "btnTotalDisplay";
            this.btnTotalDisplay.Size = new System.Drawing.Size(89, 35);
            this.btnTotalDisplay.TabIndex = 6;
            this.btnTotalDisplay.Text = "Display &Total";
            this.btnTotalDisplay.UseVisualStyleBackColor = true;
            this.btnTotalDisplay.Click += new System.EventHandler(this.btnTotalDisplay_Click);
            // 
            // btnIDFind
            // 
            this.btnIDFind.Location = new System.Drawing.Point(203, 165);
            this.btnIDFind.Name = "btnIDFind";
            this.btnIDFind.Size = new System.Drawing.Size(89, 35);
            this.btnIDFind.TabIndex = 8;
            this.btnIDFind.Text = "&Find ID";
            this.btnIDFind.UseVisualStyleBackColor = true;
            this.btnIDFind.Click += new System.EventHandler(this.btnIDFind_Click);
            // 
            // txtFindID
            // 
            this.txtFindID.Location = new System.Drawing.Point(73, 98);
            this.txtFindID.Name = "txtFindID";
            this.txtFindID.Size = new System.Drawing.Size(100, 20);
            this.txtFindID.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Find ID:";
            // 
            // errProvider
            // 
            this.errProvider.BlinkRate = 0;
            this.errProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProvider.ContainerControl = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 212);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFindID);
            this.Controls.Add(this.btnIDFind);
            this.Controls.Add(this.btnTotalDisplay);
            this.Controls.Add(this.btnAllSales);
            this.Controls.Add(this.btnRemoveCancel);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnAddSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAmount);
            this.Name = "frmMain";
            this.Text = "Capital Sales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfirmClose_FormEvent);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddSave;
        private System.Windows.Forms.ComboBox txtID;
        private System.Windows.Forms.Button btnRemoveCancel;
        private System.Windows.Forms.Button btnAllSales;
        private System.Windows.Forms.Button btnTotalDisplay;
        private System.Windows.Forms.Button btnIDFind;
        private System.Windows.Forms.TextBox txtFindID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errProvider;
    }
}

