using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planning
{
    class Queries
    {
        /// <summary>
        /// String to select all from database.
        /// </summary>
        public static string Select
        {
            get
            {
                return "SELECT * FROM planning ORDER BY StartDate ASC";
            }
        }

        /// <summary>
        /// Inserts query into database, returns a string.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="end"></param>
        /// <param name="comp"></param>
        /// <param name="desc"></param>
        /// <returns></returns>
        public static string Insert(string start, string end, string comp, string desc, string prio)
        {
            return $"INSERT INTO planning (StartDate, EndDate, Component, Description, Status, priority) VALUES('{start}','{end}','{comp}','{desc}', 'Incomplete', '{prio}')";
        }

        /// <summary>
        /// Delete query string/
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string Delete(int id)
        {
            return $"DELETE FROM planning WHERE ID = '{id}'";
        }

        /// <summary>
        /// Edit query string.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="comp"></param>
        /// <param name="desc"></param>
        /// <returns></returns>
        public static string Edit(int id, string start, string end, string comp, string desc, string status, string prio)
        {
            return $"UPDATE planning SET StartDate='{start}', EndDate='{end}', Component='{comp}', Description='{desc}', status='{status}', priority='{prio}' WHERE ID='{id}'";
        }
    }
}