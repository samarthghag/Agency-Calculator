namespace Angeny_Calculator
{
    partial class Project_Cost_Estimator
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
            txtTaskName = new TextBox();
            label3 = new Label();
            txtTaskRate = new TextBox();
            label4 = new Label();
            txtNumberOfTasks = new TextBox();
            label5 = new Label();
            txtAdditionalCosts = new TextBox();
            lstTasks = new ListBox();
            btnAddTask = new Button();
            btnCalculate = new Button();
            btnClear = new Button();
            button1 = new Button();
            lblTotalCost = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(144, 40);
            label1.Name = "label1";
            label1.Size = new Size(350, 38);
            label1.TabIndex = 0;
            label1.Text = "Project Cost Estimator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 126);
            label2.Name = "label2";
            label2.Size = new Size(180, 35);
            label2.TabIndex = 1;
            label2.Text = "Task Name  :";
            // 
            // txtTaskName
            // 
            txtTaskName.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTaskName.Location = new Point(305, 123);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.Size = new Size(263, 42);
            txtTaskName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(69, 187);
            label3.Name = "label3";
            label3.Size = new Size(174, 35);
            label3.TabIndex = 3;
            label3.Text = "Task Rate   :";
            // 
            // txtTaskRate
            // 
            txtTaskRate.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTaskRate.Location = new Point(305, 184);
            txtTaskRate.Name = "txtTaskRate";
            txtTaskRate.Size = new Size(263, 42);
            txtTaskRate.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(69, 254);
            label4.Name = "label4";
            label4.Size = new Size(262, 35);
            label4.TabIndex = 5;
            label4.Text = "Number of Tasks   :";
            // 
            // txtNumberOfTasks
            // 
            txtNumberOfTasks.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNumberOfTasks.Location = new Point(348, 251);
            txtNumberOfTasks.Name = "txtNumberOfTasks";
            txtNumberOfTasks.Size = new Size(220, 42);
            txtNumberOfTasks.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(69, 320);
            label5.Name = "label5";
            label5.Size = new Size(262, 35);
            label5.TabIndex = 7;
            label5.Text = "Additional Costs   :";
            // 
            // txtAdditionalCosts
            // 
            txtAdditionalCosts.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAdditionalCosts.Location = new Point(348, 320);
            txtAdditionalCosts.Name = "txtAdditionalCosts";
            txtAdditionalCosts.Size = new Size(220, 42);
            txtAdditionalCosts.TabIndex = 8;
            // 
            // lstTasks
            // 
            lstTasks.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstTasks.FormattingEnabled = true;
            lstTasks.ItemHeight = 35;
            lstTasks.Location = new Point(35, 391);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(618, 214);
            lstTasks.TabIndex = 9;
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.Lime;
            btnAddTask.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTask.Location = new Point(99, 640);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(144, 46);
            btnAddTask.TabIndex = 10;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Lime;
            btnCalculate.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = Color.Black;
            btnCalculate.Location = new Point(281, 640);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(257, 46);
            btnCalculate.TabIndex = 11;
            btnCalculate.Text = "Calculate Total";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Chartreuse;
            btnClear.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(99, 721);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(144, 48);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.GreenYellow;
            button1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(281, 721);
            button1.Name = "button1";
            button1.Size = new Size(100, 48);
            button1.TabIndex = 13;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblTotalCost
            // 
            lblTotalCost.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCost.Location = new Point(99, 802);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(499, 45);
            lblTotalCost.TabIndex = 14;
            // 
            // Project_Cost_Estimator
            // 
            AutoScaleDimensions = new SizeF(16F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(680, 859);
            Controls.Add(lblTotalCost);
            Controls.Add(button1);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(btnAddTask);
            Controls.Add(lstTasks);
            Controls.Add(txtAdditionalCosts);
            Controls.Add(label5);
            Controls.Add(txtNumberOfTasks);
            Controls.Add(label4);
            Controls.Add(txtTaskRate);
            Controls.Add(label3);
            Controls.Add(txtTaskName);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Project_Cost_Estimator";
            Text = "Project_Cost_Estimator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTaskName;
        private Label label3;
        private TextBox txtTaskRate;
        private Label label4;
        private TextBox txtNumberOfTasks;
        private Label label5;
        private TextBox txtAdditionalCosts;
        private ListBox lstTasks;
        private Button btnAddTask;
        private Button btnCalculate;
        private Button btnClear;
        private Button button1;
        private TextBox lblTotalCost;
    }
}