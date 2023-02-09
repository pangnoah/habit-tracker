using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habit_Tracker
{
    public class ChangeHabit
    {
        public string Habit { get; set; }
        public string Date { get; set; }
        public int Duration { get; set; }
        public int Amount { get; set; }

        public string FullInfo
        {
            get
            {
                return $"({Habit}) ({Date}) ({Duration} Minutes) ({Amount})";
            }
        }

    }
}
