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

namespace Planning
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class EditWindow : MetroWindow
    {
        public EditWindow(int id, string start, string end, string comp, string desc, string check, string prio, ShowWindow win)
        {
            InitializeComponent();

            txtid.Text = id.ToString();
            startDate.Text = start;
            endDate.Text = end;
            txtSubject.Text = comp;
            txtDesc.Text = desc;
            cmbPrio.SelectedValue = prio;

            string[] priorityArray = new string[] {"Low", "Middle", "High" };

            cmbPrio.ItemsSource = priorityArray;

            if (check == "Complete")
            {
                chkStatus.IsChecked = true;
            }
            else
            {
                chkStatus.IsChecked = false;
            }
        }

        /// <summary>
        /// Edits the selected record.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var dbObject = new Database();
            var show = new ShowWindow();

            try
            {
                if (startDate.Text == "" || endDate.Text == "" || txtSubject.Text == "" || txtDesc.Text == "" || cmbPrio.SelectedIndex == -1)
                {
                    await this.ShowMessageAsync("Error", "1 or more fields were empty.");
                }
                else
                {
                    if (startDate.SelectedDate < startDate.SelectedDate || endDate.SelectedDate < endDate.SelectedDate)
                    {
                        await this.ShowMessageAsync("Error", "Starting or ending date can't be earlier than today.");
                    }
                    else
                    {
                        if (chkStatus.IsChecked == true)
                        {
                            var x = "Complete";

                            dbObject.Edit(Convert.ToInt32(txtid.Text), startDate.Text, endDate.Text, txtSubject.Text, txtDesc.Text, x, cmbPrio.SelectedValue.ToString());
                            await this.ShowMessageAsync("Success!", $"Successfully edited item id {txtid.Text}");
                            CollectionViewSource.GetDefaultView(show.dataGrid.ItemsSource).Refresh();
                        }
                        else
                        {
                            var x = "Incomplete";
                            dbObject.Edit(Convert.ToInt32(txtid.Text), startDate.Text, endDate.Text, txtSubject.Text, txtDesc.Text, x, cmbPrio.SelectedValue.ToString());
                            await this.ShowMessageAsync("Success!", $"Successfully edited item id {txtid.Text}");
                        }
                       
                    }
                }
                
                Close();
            }
            catch (DatabaseExceptions ex)
            {
                throw ex;
            }
        }
    }
}
