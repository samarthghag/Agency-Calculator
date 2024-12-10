namespace Angeny_Calculator
{
    partial class DigitalAdBudgetCalculator
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
            txtPlatformName = new TextBox();
            label3 = new Label();
            txtBudgetAmount = new TextBox();
            label4 = new Label();
            txtBudgetPercentage = new TextBox();
            lstPlatformDetails = new ListBox();
            btnAddPlatform = new Button();
            button1 = new Button();
            btnClear = new Button();
            btnBack = new Button();
            lblTotalAdBudget = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(35, 29);
            label1.Name = "label1";
            label1.Size = new Size(440, 38);
            label1.TabIndex = 0;
            label1.Text = "Digital Ad Budget Calculator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 115);
            label2.Name = "label2";
            label2.Size = new Size(226, 35);
            label2.TabIndex = 1;
            label2.Text = "Platform Name :";
            // 
            // txtPlatformName
            // 
            txtPlatformName.Location = new Point(255, 112);
            txtPlatformName.Name = "txtPlatformName";
            txtPlatformName.Size = new Size(233, 42);
            txtPlatformName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 181);
            label3.Name = "label3";
            label3.Size = new Size(276, 35);
            label3.TabIndex = 3;
            label3.Text = "Budget Amount (₹) :";
            // 
            // txtBudgetAmount
            // 
            txtBudgetAmount.Location = new Point(305, 181);
            txtBudgetAmount.Name = "txtBudgetAmount";
            txtBudgetAmount.Size = new Size(183, 42);
            txtBudgetAmount.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 249);
            label4.Name = "label4";
            label4.Size = new Size(331, 35);
            label4.TabIndex = 5;
            label4.Text = "Budget Percentage (%) :";
            // 
            // txtBudgetPercentage
            // 
            txtBudgetPercentage.Location = new Point(360, 249);
            txtBudgetPercentage.Name = "txtBudgetPercentage";
            txtBudgetPercentage.Size = new Size(128, 42);
            txtBudgetPercentage.TabIndex = 6;
            // 
            // lstPlatformDetails
            // 
            lstPlatformDetails.FormattingEnabled = true;
            lstPlatformDetails.ItemHeight = 35;
            lstPlatformDetails.Location = new Point(23, 311);
            lstPlatformDetails.Name = "lstPlatformDetails";
            lstPlatformDetails.Size = new Size(465, 109);
            lstPlatformDetails.TabIndex = 7;
            // 
            // btnAddPlatform
            // 
            btnAddPlatform.Location = new Point(23, 450);
            btnAddPlatform.Name = "btnAddPlatform";
            btnAddPlatform.Size = new Size(226, 39);
            btnAddPlatform.TabIndex = 8;
            btnAddPlatform.Text = "Add Platform";
            btnAddPlatform.UseVisualStyleBackColor = true;
            btnAddPlatform.Click += btnAddPlatform_Click;
            // 
            // button1
            // 
            button1.Location = new Point(23, 506);
            button1.Name = "button1";
            button1.Size = new Size(334, 43);
            button1.TabIndex = 9;
            button1.Text = "Calculate Total Budget";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(274, 450);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(96, 39);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(363, 506);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 43);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblTotalAdBudget
            // 
            lblTotalAdBudget.Location = new Point(23, 582);
            lblTotalAdBudget.Name = "lblTotalAdBudget";
            lblTotalAdBudget.Size = new Size(465, 42);
            lblTotalAdBudget.TabIndex = 12;
            // 
            // DigitalAdBudgetCalculator
            // 
            AutoScaleDimensions = new SizeF(18F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(510, 639);
            Controls.Add(lblTotalAdBudget);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(button1);
            Controls.Add(btnAddPlatform);
            Controls.Add(lstPlatformDetails);
            Controls.Add(txtBudgetPercentage);
            Controls.Add(label4);
            Controls.Add(txtBudgetAmount);
            Controls.Add(label3);
            Controls.Add(txtPlatformName);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(7, 5, 7, 5);
            Name = "DigitalAdBudgetCalculator";
            Text = "DigitalAdBudgetCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPlatformName;
        private Label label3;
        private TextBox txtBudgetAmount;
        private Label label4;
        private TextBox txtBudgetPercentage;
        private ListBox lstPlatformDetails;
        private Button btnAddPlatform;
        private Button button1;
        private Button btnClear;
        private Button btnBack;
        private TextBox lblTotalAdBudget;
    }
}