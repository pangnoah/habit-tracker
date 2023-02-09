using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Habit_Tracker
{
    public partial class HabitLog : Form
    {
        List<ChangeHabit> changeHabits = new List<ChangeHabit>();
        public HabitLog()
        {
            InitializeComponent();
            habitFoundListBox.DataSource = changeHabits;
            habitFoundListBox.DisplayMember = "FullInfo";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            changeHabits = db.GetHabit(habitTextBox.Text);
            habitFoundListBox.DataSource = changeHabits;
            habitFoundListBox.DisplayMember = "FullInfo";
        }

        private void habitTrackerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HabitTracker menu = new HabitTracker();
            menu.ShowDialog();
            this.Close();
        }

        private void habitStatsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HabitStatistics menu = new HabitStatistics();
            menu.ShowDialog();
            this.Close();
        }

        private void allHabitsButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            changeHabits = db.GetAllHabits();
            habitFoundListBox.DataSource = changeHabits;
            habitFoundListBox.DisplayMember = "FullInfo";
        }
    }
}

