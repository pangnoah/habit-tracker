namespace Habit_Tracker
{
    public partial class HabitTracker : Form
    {
        public HabitTracker()
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.ModifyHabit(habitChangeTextBox.Text, dateChangeTextBox.Text, durationChangeTextBox.Text, amountChangeTextBox.Text, "Insert");
        }

        private void habitLogButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HabitLog log = new HabitLog();
            log.ShowDialog();
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.ModifyHabit(habitChangeTextBox.Text, dateChangeTextBox.Text, durationChangeTextBox.Text, amountChangeTextBox.Text, "Delete");

        }

        private void habitStatsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HabitStatistics menu = new HabitStatistics();
            menu.ShowDialog();
            this.Close();
        }
    }
}