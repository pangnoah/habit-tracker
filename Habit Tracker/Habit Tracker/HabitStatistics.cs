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
    public partial class HabitStatistics : Form
    {
        public HabitStatistics()
        {
            InitializeComponent();
        }

        private void habitTrackerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HabitTracker menu = new HabitTracker();
            menu.ShowDialog();
            this.Close();
        }

        private void habitLogButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HabitLog log = new HabitLog();
            log.ShowDialog();
            this.Close();
        }

        private void statsSearchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            totalDurationTextBox.Text = db.Statistics(habitStatsTextBox.Text, "Total Duration");
            avgDurationTextBox.Text = db.Statistics(habitStatsTextBox.Text, "Average Duration");
            totalAmountTextBox.Text = db.Statistics(habitStatsTextBox.Text, "Total Amount");
            avgAmountTextBox.Text = db.Statistics(habitStatsTextBox.Text, "Average Amount");
            entriesTextBox.Text = db.Statistics(habitStatsTextBox.Text, "Number of Entries");
            totalEntriesTextBox.Text = db.Statistics(habitStatsTextBox.Text, "Total Entries");
        }
    }
}
