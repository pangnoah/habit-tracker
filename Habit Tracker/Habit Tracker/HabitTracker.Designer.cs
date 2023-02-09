namespace Habit_Tracker
{
    partial class HabitTracker
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
            this.habitChangeLabel = new System.Windows.Forms.Label();
            this.dateChangeLabel = new System.Windows.Forms.Label();
            this.durationChangeLabel = new System.Windows.Forms.Label();
            this.amountChangeLabel = new System.Windows.Forms.Label();
            this.habitChangeTextBox = new System.Windows.Forms.TextBox();
            this.dateChangeTextBox = new System.Windows.Forms.TextBox();
            this.durationChangeTextBox = new System.Windows.Forms.TextBox();
            this.amountChangeTextBox = new System.Windows.Forms.TextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.habitLogButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.habitStatsButton = new System.Windows.Forms.Button();
            this.habitTrackerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // habitChangeLabel
            // 
            this.habitChangeLabel.AutoSize = true;
            this.habitChangeLabel.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.habitChangeLabel.ForeColor = System.Drawing.Color.Black;
            this.habitChangeLabel.Location = new System.Drawing.Point(223, 129);
            this.habitChangeLabel.Name = "habitChangeLabel";
            this.habitChangeLabel.Size = new System.Drawing.Size(54, 21);
            this.habitChangeLabel.TabIndex = 0;
            this.habitChangeLabel.Text = "Habit";
            // 
            // dateChangeLabel
            // 
            this.dateChangeLabel.AutoSize = true;
            this.dateChangeLabel.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateChangeLabel.ForeColor = System.Drawing.Color.Black;
            this.dateChangeLabel.Location = new System.Drawing.Point(223, 179);
            this.dateChangeLabel.Name = "dateChangeLabel";
            this.dateChangeLabel.Size = new System.Drawing.Size(181, 21);
            this.dateChangeLabel.TabIndex = 1;
            this.dateChangeLabel.Text = "Date (MM/DD/YYYY)";
            // 
            // durationChangeLabel
            // 
            this.durationChangeLabel.AutoSize = true;
            this.durationChangeLabel.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.durationChangeLabel.ForeColor = System.Drawing.Color.Black;
            this.durationChangeLabel.Location = new System.Drawing.Point(223, 229);
            this.durationChangeLabel.Name = "durationChangeLabel";
            this.durationChangeLabel.Size = new System.Drawing.Size(163, 21);
            this.durationChangeLabel.TabIndex = 2;
            this.durationChangeLabel.Text = "Duration (Minutes)";
            // 
            // amountChangeLabel
            // 
            this.amountChangeLabel.AutoSize = true;
            this.amountChangeLabel.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amountChangeLabel.ForeColor = System.Drawing.Color.Black;
            this.amountChangeLabel.Location = new System.Drawing.Point(223, 279);
            this.amountChangeLabel.Name = "amountChangeLabel";
            this.amountChangeLabel.Size = new System.Drawing.Size(73, 21);
            this.amountChangeLabel.TabIndex = 3;
            this.amountChangeLabel.Text = "Amount";
            // 
            // habitChangeTextBox
            // 
            this.habitChangeTextBox.Location = new System.Drawing.Point(447, 126);
            this.habitChangeTextBox.Name = "habitChangeTextBox";
            this.habitChangeTextBox.Size = new System.Drawing.Size(125, 27);
            this.habitChangeTextBox.TabIndex = 4;
            // 
            // dateChangeTextBox
            // 
            this.dateChangeTextBox.Location = new System.Drawing.Point(447, 176);
            this.dateChangeTextBox.Name = "dateChangeTextBox";
            this.dateChangeTextBox.Size = new System.Drawing.Size(125, 27);
            this.dateChangeTextBox.TabIndex = 5;
            // 
            // durationChangeTextBox
            // 
            this.durationChangeTextBox.Location = new System.Drawing.Point(447, 226);
            this.durationChangeTextBox.Name = "durationChangeTextBox";
            this.durationChangeTextBox.Size = new System.Drawing.Size(125, 27);
            this.durationChangeTextBox.TabIndex = 6;
            // 
            // amountChangeTextBox
            // 
            this.amountChangeTextBox.Location = new System.Drawing.Point(447, 276);
            this.amountChangeTextBox.Name = "amountChangeTextBox";
            this.amountChangeTextBox.Size = new System.Drawing.Size(125, 27);
            this.amountChangeTextBox.TabIndex = 7;
            // 
            // insertButton
            // 
            this.insertButton.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insertButton.ForeColor = System.Drawing.Color.Black;
            this.insertButton.Location = new System.Drawing.Point(87, 360);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(127, 29);
            this.insertButton.TabIndex = 8;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // habitLogButton
            // 
            this.habitLogButton.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.habitLogButton.ForeColor = System.Drawing.Color.Black;
            this.habitLogButton.Location = new System.Drawing.Point(419, 360);
            this.habitLogButton.Name = "habitLogButton";
            this.habitLogButton.Size = new System.Drawing.Size(127, 29);
            this.habitLogButton.TabIndex = 9;
            this.habitLogButton.Text = "Habit Log";
            this.habitLogButton.UseVisualStyleBackColor = true;
            this.habitLogButton.Click += new System.EventHandler(this.habitLogButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.ForeColor = System.Drawing.Color.Black;
            this.deleteButton.Location = new System.Drawing.Point(253, 360);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(127, 29);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // habitStatsButton
            // 
            this.habitStatsButton.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.habitStatsButton.ForeColor = System.Drawing.Color.Black;
            this.habitStatsButton.Location = new System.Drawing.Point(584, 360);
            this.habitStatsButton.Name = "habitStatsButton";
            this.habitStatsButton.Size = new System.Drawing.Size(129, 29);
            this.habitStatsButton.TabIndex = 11;
            this.habitStatsButton.Text = "Habit Stats";
            this.habitStatsButton.UseVisualStyleBackColor = true;
            this.habitStatsButton.Click += new System.EventHandler(this.habitStatsButton_Click);
            // 
            // habitTrackerLabel
            // 
            this.habitTrackerLabel.AutoSize = true;
            this.habitTrackerLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.habitTrackerLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.habitTrackerLabel.Location = new System.Drawing.Point(304, 39);
            this.habitTrackerLabel.Name = "habitTrackerLabel";
            this.habitTrackerLabel.Size = new System.Drawing.Size(191, 35);
            this.habitTrackerLabel.TabIndex = 12;
            this.habitTrackerLabel.Text = "Habit Tracker";
            // 
            // HabitTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.habitTrackerLabel);
            this.Controls.Add(this.habitStatsButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.habitLogButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.amountChangeTextBox);
            this.Controls.Add(this.durationChangeTextBox);
            this.Controls.Add(this.dateChangeTextBox);
            this.Controls.Add(this.habitChangeTextBox);
            this.Controls.Add(this.amountChangeLabel);
            this.Controls.Add(this.durationChangeLabel);
            this.Controls.Add(this.dateChangeLabel);
            this.Controls.Add(this.habitChangeLabel);
            this.Name = "HabitTracker";
            this.Text = "Habit Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label habitChangeLabel;
        private Label dateChangeLabel;
        private Label durationChangeLabel;
        private Label amountChangeLabel;
        private TextBox habitChangeTextBox;
        private TextBox dateChangeTextBox;
        private TextBox durationChangeTextBox;
        private TextBox amountChangeTextBox;
        private Button insertButton;
        private Button habitLogButton;
        private Button deleteButton;
        private Button habitStatsButton;
        private Label habitTrackerLabel;
    }
}