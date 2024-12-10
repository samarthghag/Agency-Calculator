namespace Angeny_Calculator
{
    partial class Tax_Calculator
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
            label1 = new Label();
            label2 = new Label();
            txtBaseAmount = new TextBox();
            label3 = new Label();
            txtTaxPercentage = new TextBox();
            lblTaxAmount = new TextBox();
            lblTotalAmount = new TextBox();
            btnCalculateTax = new Button();
            btnClear = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(101, 40);
            label1.Name = "label1";
            label1.Size = new Size(244, 43);
            label1.TabIndex = 0;
            label1.Text = "Tax Calculator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 116);
            label2.Name = "label2";
            label2.Size = new Size(268, 38);
            label2.TabIndex = 1;
            label2.Text = "Base Amount (₹) :";
            // 
            // txtBaseAmount
            // 
            txtBaseAmount.Location = new Point(298, 116);
            txtBaseAmount.Name = "txtBaseAmount";
            txtBaseAmount.Size = new Size(157, 42);
            txtBaseAmount.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 181);
            label3.Name = "label3";
            label3.Size = new Size(303, 38);
            label3.TabIndex = 3;
            label3.Text = "Tax Percentage (%) :";
            // 
            // txtTaxPercentage
            // 
            txtTaxPercentage.Location = new Point(330, 181);
            txtTaxPercentage.Name = "txtTaxPercentage";
            txtTaxPercentage.Size = new Size(125, 42);
            txtTaxPercentage.TabIndex = 4;
            // 
            // lblTaxAmount
            // 
            lblTaxAmount.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTaxAmount.Location = new Point(24, 273);
            lblTaxAmount.Name = "lblTaxAmount";
            lblTaxAmount.Size = new Size(431, 46);
            lblTaxAmount.TabIndex = 5;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.Location = new Point(24, 353);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(431, 46);
            lblTotalAmount.TabIndex = 6;
            // 
            // btnCalculateTax
            // 
            btnCalculateTax.Location = new Point(24, 438);
            btnCalculateTax.Name = "btnCalculateTax";
            btnCalculateTax.Size = new Size(214, 40);
            btnCalculateTax.TabIndex = 7;
            btnCalculateTax.Text = "Calculate Tax";
            btnCalculateTax.UseVisualStyleBackColor = true;
            btnCalculateTax.Click += btnCalculateTax_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(284, 438);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(147, 40);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(164, 510);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(153, 42);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Tax_Calculator
            // 
            AutoScaleDimensions = new SizeF(17F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(467, 583);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnCalculateTax);
            Controls.Add(lblTotalAmount);
            Controls.Add(lblTaxAmount);
            Controls.Add(txtTaxPercentage);
            Controls.Add(label3);
            Controls.Add(txtBaseAmount);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Tax_Calculator";
            Text = "Tax_Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBaseAmount;
        private Label label3;
        private TextBox txtTaxPercentage;
        private TextBox lblTaxAmount;
        private TextBox lblTotalAmount;
        private Button btnCalculateTax;
        private Button btnClear;
        private Button btnBack;
    }
}