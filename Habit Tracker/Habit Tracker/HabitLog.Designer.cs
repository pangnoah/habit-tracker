namespace Habit_Tracker
{
    partial class HabitLog
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
            this.habitFoundListBox = new System.Windows.Forms.ListBox();
            this.habitTextBox = new System.Windows.Forms.TextBox();
            this.habitLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.habitTrackerButton = new System.Windows.Forms.Button();
            this.habitStatsButton = new System.Windows.Forms.Button();
            this.allHabitsButton = new System.Windows.Forms.Button();
            this.habitLogLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // habitFoundListBox
            // 
            this.habitFoundListBox.FormattingEnabled = true;
            this.habitFoundListBox.ItemHeight = 20;
            this.habitFoundListBox.Location = new System.Drawing.Point(190, 162);
            this.habitFoundListBox.Name = "habitFoundListBox";
            this.habitFoundListBox.Size = new System.Drawing.Size(420, 164);
            this.habitFoundListBox.TabIndex = 0;
            // 
            // habitTextBox
            // 
            this.habitTextBox.Location = new System.Drawing.Point(337, 102);
            this.habitTextBox.Name = "habitTextBox";
            this.habitTextBox.Size = new System.Drawing.Size(125, 27);
            this.habitTextBox.TabIndex = 1;
            // 
            // habitLabel
            // 
            this.habitLabel.AutoSize = true;
            this.habitLabel.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.habitLabel.Location = new System.Drawing.Point(268, 105);
            this.habitLabel.Name = "habitLabel";
            this.habitLabel.Size = new System.Drawing.Size(54, 21);
            this.habitLabel.TabIndex = 2;
            this.habitLabel.Text = "Habit";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchButton.Location = new System.Drawing.Point(482, 101);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(74, 29);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // habitTrackerButton
            // 
            this.habitTrackerButton.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.habitTrackerButton.Location = new System.Drawing.Point(330, 360);
            this.habitTrackerButton.Name = "habitTrackerButton";
            this.habitTrackerButton.Size = new System.Drawing.Size(140, 29);
            this.habitTrackerButton.TabIndex = 4;
            this.habitTrackerButton.Text = "Habit Tracker";
            this.habitTrackerButton.UseVisualStyleBackColor = true;
            this.habitTrackerButton.Click += new System.EventHandler(this.habitTrackerButton_Click);
            // 
            // habitStatsButton
            // 
            this.habitStatsButton.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.habitStatsButton.Location = new System.Drawing.Point(520, 360);
            this.habitStatsButton.Name = "habitStatsButton";
            this.habitStatsButton.Size = new System.Drawing.Size(140, 29);
            this.habitStatsButton.TabIndex = 12;
            this.habitStatsButton.Text = "Habit Stats";
            this.habitStatsButton.UseVisualStyleBackColor = true;
            this.habitStatsButton.Click += new System.EventHandler(this.habitStatsButton_Click);
            // 
            // allHabitsButton
            // 
            this.allHabitsButton.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.allHabitsButton.Location = new System.Drawing.Point(140, 360);
            this.allHabitsButton.Name = "allHabitsButton";
            this.allHabitsButton.Size = new System.Drawing.Size(140, 29);
            this.allHabitsButton.TabIndex = 13;
            this.allHabitsButton.Text = "All Habits";
            this.allHabitsButton.UseVisualStyleBackColor = true;
            this.allHabitsButton.Click += new System.EventHandler(this.allHabitsButton_Click);
            // 
            // habitLogLabel
            // 
            this.habitLogLabel.AutoSize = true;
            this.habitLogLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.habitLogLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.habitLogLabel.Location = new System.Drawing.Point(327, 39);
            this.habitLogLabel.Name = "habitLogLabel";
            this.habitLogLabel.Size = new System.Drawing.Size(145, 35);
            this.habitLogLabel.TabIndex = 14;
            this.habitLogLabel.Text = "Habit Log";
            // 
            // HabitLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.habitLogLabel);
            this.Controls.Add(this.allHabitsButton);
            this.Controls.Add(this.habitStatsButton);
            this.Controls.Add(this.habitTrackerButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.habitLabel);
            this.Controls.Add(this.habitTextBox);
            this.Controls.Add(this.habitFoundListBox);
            this.Name = "HabitLog";
            this.Text = "Habit Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox habitFoundListBox;
        private TextBox habitTextBox;
        private Label habitLabel;
        private Button searchButton;
        private Button habitTrackerButton;
        private Button habitStatsButton;
        private Button allHabitsButton;
        private Label habitLogLabel;
    }
}