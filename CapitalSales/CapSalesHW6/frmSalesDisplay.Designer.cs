namespace CapitalSales
{
    partial class frmSalesDisplay
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
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbOutput
            // 
            this.rtbOutput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOutput.Location = new System.Drawing.Point(12, 12);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(305, 188);
            this.rtbOutput.TabIndex = 0;
            this.rtbOutput.Text = "";
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Location = new System.Drawing.Point(126, 206);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(75, 23);
            this.btnCloseForm.TabIndex = 1;
            this.btnCloseForm.Text = "&Close";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // frmSalesDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 257);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.rtbOutput);
            this.Name = "frmSalesDisplay";
            this.Text = "Sales";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnCloseForm;
    }
}