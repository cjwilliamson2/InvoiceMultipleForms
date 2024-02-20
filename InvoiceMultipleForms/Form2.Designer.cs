namespace InvoiceMultipleForms
{
    partial class frmSalesTax
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
            lblSalesTaxPercent = new Label();
            txtSalesTaxPercent = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblSalesTaxPercent
            // 
            lblSalesTaxPercent.AutoSize = true;
            lblSalesTaxPercent.Location = new Point(32, 40);
            lblSalesTaxPercent.Name = "lblSalesTaxPercent";
            lblSalesTaxPercent.Size = new Size(75, 15);
            lblSalesTaxPercent.TabIndex = 0;
            lblSalesTaxPercent.Text = "Sales tax pct:";
            // 
            // txtSalesTaxPercent
            // 
            txtSalesTaxPercent.Location = new Point(153, 37);
            txtSalesTaxPercent.Name = "txtSalesTaxPercent";
            txtSalesTaxPercent.Size = new Size(100, 23);
            txtSalesTaxPercent.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(32, 85);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(178, 85);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmSalesTax
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(288, 142);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(txtSalesTaxPercent);
            Controls.Add(lblSalesTaxPercent);
            Name = "frmSalesTax";
            Text = "Sales Tax";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSalesTaxPercent;
        private TextBox txtSalesTaxPercent;
        private Button btnOK;
        private Button btnCancel;
    }
}