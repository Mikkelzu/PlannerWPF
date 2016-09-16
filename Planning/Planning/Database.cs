using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Planning
{
    public class Database
    {
        /// <summary>
        /// Connection string. Use this method to connect to database.
        /// </summary>
        /// <returns></returns>
        public static string ConnectionString()
        {
            return "Data Source=database.s3db;Version=3;datetimeformat=CurrentCulture;";
        }

        /// <summary>
        /// Shows data in a data grid. Make sure is used in Async Task void.
        /// </summary>
        /// <returns></returns>
        public static async Task<DataSet> ShowDataInGrid()
        {
            using (SQLiteConnection sql = new SQLiteConnection(ConnectionString()))
            {
                sql.Open();
                string command = Queries.Select;
                SQLiteCommand cmd = new SQLiteCommand(command,sql);
                await cmd.ExecuteNonQueryAsync();
                DataSet ds = new DataSet();
                SQLiteDataAdapter adap = new SQLiteDataAdapter(cmd);
                adap.Fill(ds);
                sql.Close();
                return ds;
            }
        }

        /// <summary>
        /// Method to add data to database.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="comp"></param>
        /// <param name="desc"></param>
        public async void AddDataToDataBase(string start, string end, string comp, string desc)
        {
            SQLiteConnection sql = new SQLiteConnection(ConnectionString());

            await sql.OpenAsync();

            SQLiteCommand cmd = new SQLiteCommand(Queries.Insert(start, end, comp, desc), sql);

            await cmd.ExecuteNonQueryAsync();
            sql.Close();
        }

        /// <summary>
        /// Edits the selected index of the datagrid.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="comp"></param>
        /// <param name="desc"></param>
        public void Edit(int id, string start, string end, string comp, string desc, string st)
        {
            using (SQLiteConnection sql = new SQLiteConnection(ConnectionString()))
            {
                sql.Open();

                SQLiteCommand cmd = new SQLiteCommand(Queries.Edit(id, start, end, comp, desc, st), sql);

                cmd.ExecuteNonQuery();
                sql.Close();
            }
        }

        /// <summary>
        /// Deletes a row from the database.
        /// </summary>
        /// <param name="id"></param>
        public static void Delete(int id)
        {
            using (SQLiteConnection sql = new SQLiteConnection(ConnectionString()))
            {
                sql.Open();
                SQLiteCommand cmd = new SQLiteCommand(Queries.Delete(id), sql);

                cmd.ExecuteNonQuery();
                sql.Close();
            }
        }
    }
}