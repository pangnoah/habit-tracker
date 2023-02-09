using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Habit_Tracker
{
    public class DataAccess
    {
        public List<ChangeHabit> GetHabit(string habit)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("HabitTrackerDB")))
            {
                var output = connection.Query<ChangeHabit>("dbo.HabitInfo_GetByHabit @Habit", new { Habit = habit }).ToList();
                return output;
            }
        }

        public void ModifyHabit(string habit, string date, string duration, string amount, string action)
        {
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("HabitTrackerDB")))
            {
                SqlCommand command = new SqlCommand("dbo.HabitInfo_Log", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Action", action);
                command.Parameters.AddWithValue("@Habit", habit);
                command.Parameters.AddWithValue("@Date", date);
                command.Parameters.AddWithValue("@Duration", duration);
                command.Parameters.AddWithValue("@Amount", amount);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public string Statistics(string habit, string action)
        {
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("HabitTrackerDB")))
            {
                SqlCommand command = new SqlCommand("dbo.HabitInfo_Statistics", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Action", action);
                command.Parameters.AddWithValue("@Habit", habit);
                connection.Open();
                object total = command.ExecuteScalar();
                return Convert.ToString(total);
            }
        }

        public List<ChangeHabit> GetAllHabits()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("HabitTrackerDB")))
            {
                var output = connection.Query<ChangeHabit>("dbo.HabitInfo_GetAllHabits").ToList();
                return output;
            }
        }
    }
}
