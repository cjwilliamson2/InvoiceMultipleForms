namespace InvoiceMultipleForms
{
    partial class frmInvoiceTotal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblProductTotal = new Label();
            lblDiscountAmount = new Label();
            lblSubtotal = new Label();
            lblTax = new Label();
            lblTotal = new Label();
            txtProductTotal = new TextBox();
            txtDiscountAmount = new TextBox();
            txtSubtotal = new TextBox();
            txtTax = new TextBox();
            txtTotal = new TextBox();
            btnChangePercent = new Button();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblProductTotal
            // 
            lblProductTotal.AutoSize = true;
            lblProductTotal.Location = new Point(29, 37);
            lblProductTotal.Name = "lblProductTotal";
            lblProductTotal.Size = new Size(79, 15);
            lblProductTotal.TabIndex = 0;
            lblProductTotal.Text = "Product total:";
            // 
            // lblDiscountAmount
            // 
            lblDiscountAmount.AutoSize = true;
            lblDiscountAmount.Location = new Point(29, 78);
            lblDiscountAmount.Name = "lblDiscountAmount";
            lblDiscountAmount.Size = new Size(102, 15);
            lblDiscountAmount.TabIndex = 1;
            lblDiscountAmount.Text = "Discount amount:";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(29, 124);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(54, 15);
            lblSubtotal.TabIndex = 2;
            lblSubtotal.Text = "Subtotal:";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(29, 166);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(69, 15);
            lblTax.TabIndex = 3;
            lblTax.Text = "Tax (7.75%):";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(29, 209);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(35, 15);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total:";
            // 
            // txtProductTotal
            // 
            txtProductTotal.Location = new Point(145, 34);
            txtProductTotal.Name = "txtProductTotal";
            txtProductTotal.Size = new Size(100, 23);
            txtProductTotal.TabIndex = 5;
            // 
            // txtDiscountAmount
            // 
            txtDiscountAmount.Location = new Point(145, 78);
            txtDiscountAmount.Name = "txtDiscountAmount";
            txtDiscountAmount.ReadOnly = true;
            txtDiscountAmount.Size = new Size(100, 23);
            txtDiscountAmount.TabIndex = 6;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(145, 124);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(100, 23);
            txtSubtotal.TabIndex = 7;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(145, 166);
            txtTax.Name = "txtTax";
            txtTax.ReadOnly = true;
            txtTax.Size = new Size(100, 23);
            txtTax.TabIndex = 8;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(145, 209);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 9;
            // 
            // btnChangePercent
            // 
            btnChangePercent.Location = new Point(279, 165);
            btnChangePercent.Name = "btnChangePercent";
            btnChangePercent.Size = new Size(105, 23);
            btnChangePercent.TabIndex = 10;
            btnChangePercent.Text = "Change Percent";
            btnChangePercent.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(33, 268);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 11;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(161, 268);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 12;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // frmInvoiceTotal
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(418, 325);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(btnChangePercent);
            Controls.Add(txtTotal);
            Controls.Add(txtTax);
            Controls.Add(txtSubtotal);
            Controls.Add(txtDiscountAmount);
            Controls.Add(txtProductTotal);
            Controls.Add(lblTotal);
            Controls.Add(lblTax);
            Controls.Add(lblSubtotal);
            Controls.Add(lblDiscountAmount);
            Controls.Add(lblProductTotal);
            Name = "frmInvoiceTotal";
            Text = "Invoice Total";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductTotal;
        private Label lblDiscountAmount;
        private Label lblSubtotal;
        private Label lblTax;
        private Label lblTotal;
        private TextBox txtProductTotal;
        private TextBox txtDiscountAmount;
        private TextBox txtSubtotal;
        private TextBox txtTax;
        private TextBox txtTotal;
        private Button btnChangePercent;
        private Button btnCalculate;
        private Button btnExit;
    }
}