namespace Angeny_Calculator
{
    partial class Hourly_Rate_Calculator_Form
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
            HourWorktextBox = new TextBox();
            label3 = new Label();
            HRsratetextBox = new TextBox();
            Cal_button = new Button();
            Back_button = new Button();
            lblTotalPayment = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label1.Location = new Point(129, 34);
            label1.Name = "label1";
            label1.Size = new Size(359, 38);
            label1.TabIndex = 0;
            label1.Text = "Hourly Rate Calculator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 134);
            label2.Name = "label2";
            label2.Size = new Size(190, 32);
            label2.TabIndex = 1;
            label2.Text = "Hours Worked";
            // 
            // HourWorktextBox
            // 
            HourWorktextBox.Location = new Point(316, 131);
            HourWorktextBox.Name = "HourWorktextBox";
            HourWorktextBox.Size = new Size(205, 39);
            HourWorktextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 201);
            label3.Name = "label3";
            label3.Size = new Size(162, 32);
            label3.TabIndex = 3;
            label3.Text = "Hourly Rate";
            // 
            // HRsratetextBox
            // 
            HRsratetextBox.Location = new Point(316, 198);
            HRsratetextBox.Name = "HRsratetextBox";
            HRsratetextBox.Size = new Size(205, 39);
            HRsratetextBox.TabIndex = 4;
            // 
            // Cal_button
            // 
            Cal_button.Location = new Point(68, 372);
            Cal_button.Name = "Cal_button";
            Cal_button.Size = new Size(146, 44);
            Cal_button.TabIndex = 5;
            Cal_button.Text = "Calculate";
            Cal_button.UseVisualStyleBackColor = true;
            Cal_button.Click += Cal_button_Click;
            // 
            // Back_button
            // 
            Back_button.Location = new Point(316, 372);
            Back_button.Name = "Back_button";
            Back_button.Size = new Size(147, 44);
            Back_button.TabIndex = 6;
            Back_button.Text = "Back";
            Back_button.UseVisualStyleBackColor = true;
            Back_button.Click += Back_button_Click;
            // 
            // lblTotalPayment
            // 
            lblTotalPayment.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPayment.Location = new Point(50, 271);
            lblTotalPayment.Name = "lblTotalPayment";
            lblTotalPayment.Size = new Size(438, 42);
            lblTotalPayment.TabIndex = 7;
            // 
            // Hourly_Rate_Calculator_Form
            // 
            AutoScaleDimensions = new SizeF(16F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(542, 461);
            Controls.Add(lblTotalPayment);
            Controls.Add(Back_button);
            Controls.Add(Cal_button);
            Controls.Add(HRsratetextBox);
            Controls.Add(label3);
            Controls.Add(HourWorktextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.Highlight;
            Margin = new Padding(6, 5, 6, 5);
            Name = "Hourly_Rate_Calculator_Form";
            Text = "Hourly_Rate_Calculator_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox HourWorktextBox;
        private Label label3;
        private TextBox HRsratetextBox;
        private Button Cal_button;
        private Button Back_button;
        private TextBox lblTotalPayment;
    }
}