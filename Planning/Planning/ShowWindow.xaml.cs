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
using System.Data;

namespace Planning
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ShowWindow : MetroWindow
    {
        public ShowWindow()
        {
            InitializeComponent();

            new Task(ShowData).Start();
            inconspicuous();


        }

        public async void ShowData()
        {
            DataSet ds = await Database.ShowDataInGrid();

            Dispatcher.Invoke(() =>
            {
                if (ds.Tables.Count > 0)
                    dataGrid.ItemsSource = ds.Tables[0].DefaultView;
            });
        }

        private async void btnEditWindow_Click(object sender, RoutedEventArgs e)
        {
            object item = dataGrid.SelectedItem;

            if (item == null)
            {
                await this.ShowMessageAsync("Error","No row selected!");
            }
            else
            {
                int id = Convert.ToInt32((dataGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
                string start = (dataGrid.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                string end = (dataGrid.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                string comp = (dataGrid.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
                string desc = (dataGrid.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
                string status = (dataGrid.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text;
                string prio = (dataGrid.SelectedCells[6].Column.GetCellContent(item) as TextBlock).Text;

                EditWindow ed = new EditWindow(id, start, end, comp, desc, status, prio, this);
                ed.Show();
                if (ed.IsLoaded == false)
                {
                    btnUpdate.Visibility = Visibility.Visible;
                }
            }
        }

        private async void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            object item = dataGrid.SelectedItem;


            if (item == null)
            {
                await this.ShowMessageAsync("Error", "No row selected!");
            }
            else
            {
                int id = Convert.ToInt32((dataGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);

                MessageDialogResult res = await this.ShowMessageAsync("Are you sure?","Are you sure you want to delete the item?", MessageDialogStyle.AffirmativeAndNegative);
                if (res == MessageDialogResult.Affirmative)
                {
                    await this.ShowMessageAsync("Deleted","Successfully deleted the row.");
                    Database.Delete(id);
                    btnUpdate.Visibility = Visibility.Visible;
                }
                else
                {
                    await this.ShowMessageAsync("Cancelled", "Cancelled deletion.");
                }
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = null;
            new Task(ShowData).Start();
        }

        #region Test cases DO NOT TOUCH
        public void inconspicuous()
        {
            DateTime t1 = DateTime.Today;

            DateTime t2 = FreedomDate.DisplayDate;

            var x = (t2 - t1).TotalDays;
            if (x == 1)
            {
                lblFreedom.Content = $"{x} day left! Freedom tomorrow!";
            }
            else
            {
                lblFreedom.Content = $"{x} days left.";
            }
        }
        #endregion
    }
}
