using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Controls;
using System.Globalization;
using System.Diagnostics;

namespace Planning
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            string[] priorityArray = new string[] { "Low", "Medium", "High" };
            cmbPriority.ItemsSource = priorityArray;
        }

        private async void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var dbObject = new Database();
            
            try
            {
                if (start.SelectedDate.ToString() == "" || end.SelectedDate.ToString() == "" || txtSubject.Text == "" || txtDesc.Text == "" ||cmbPriority.SelectedIndex == -1)
                {
                    await this.ShowMessageAsync("Error", "1 or more fields were empty.");
                }
                else
                {
                    //if (start.SelectedDate < DateTime.Today || end.SelectedDate < DateTime.Today)
                    //{
                    //    await this.ShowMessageAsync("Error", "Starting or ending date can't be earlier than today.");
                    //}
                    //else
                    //{
                        await this.ShowMessageAsync("Added", "Added new item to database.");
                        string x = cmbPriority.SelectedValue.ToString();
                        dbObject.AddDataToDataBase(start.ToString(), end.ToString(), txtSubject.Text, txtDesc.Text, x);
                    //}
                }
            }
            catch (DatabaseExceptions ex)
            {
                throw ex;
            }
            
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow sw = new ShowWindow();

            sw.Show();
        }

        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
            Environment.Exit(0);
        }
    }
}
