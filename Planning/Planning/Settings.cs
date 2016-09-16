using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planning
{
    public class Settings
    {
        public static void inconspicuous()
        {
            ShowWindow s = new ShowWindow();

            DateTime t1 = DateTime.Today;

            DateTime t2 = s.FreedomDate.DisplayDate;

            var x = (t2 - t1).TotalDays;
            if (x == 1)
            {
                s.lblFreedom.Content = $"{x} day left! Freedom tomorrow!";
            }
            else
            {
                s.lblFreedom.Content = $"{x} days left.";
            }
        }
    }       
}