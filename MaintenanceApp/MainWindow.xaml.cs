using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HotelLibrary;
using HotelLibrary.DBContex;
using Microsoft.IdentityModel.Tokens;

namespace MaintenanceApp
{
    /// <summary>  
    /// Interaction logic for MainWindow.xaml  
    /// </summary>  
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        public void changeWorkButton_Click(object sender, RoutedEventArgs e)
        {
            var utilFunctions = new UtillFunctions();
            using (var context = new AppDbContext()) 
            {
                string description = descriptionT.Text;
                int roomNumber = int.Parse(roomnr.Text);
                if (typeM == null || taskS == null) { return; }
                if (typeM.SelectedItem is ComboBoxItem selectedItem && taskS.SelectedItem is ComboBoxItem selectedTaskStatus )
                {
                    int taskType = utilFunctions.GetTaskTypeFromString(selectedItem.Content.ToString().ToLower().Trim());

                    int taskStatus = utilFunctions.GetTaskStatusFromString(selectedTaskStatus.Content.ToString().ToLower().Trim());

                    var mainTchange = context.Maintenances
                        .Where(m => m.RoomNumber == roomNumber && m.TaskType == taskType)
                        .FirstOrDefault();
                    if (mainTchange != null)
                    {
                        if (!string.IsNullOrEmpty(description)) { mainTchange.Description = description; }
                        if (mainTchange.TaskStatus != taskStatus) { mainTchange.TaskStatus = taskStatus; }
                        context.SaveChanges();

                        var mainList = context.Maintenances
                            .Where(m => m.TaskType == taskType)
                            .Select(m => new
                            {
                                m.MaintenanceId,
                                m.RoomNumber,
                                m.Description,
                                TaskStatus = utilFunctions.GetTaskStatusFromInt(m.TaskStatus)
                            }).ToList();
                        MaintenanceDataGrid.ItemsSource = mainList;
                    }
                }
                else
                {
                    MessageBox.Show("No maintenance found for the given room number and task type.");
                }   
            }
        }

        public void typeM_SelectionChanged(object Sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            using (var context = new AppDbContext())    
            {
                if (typeM == null) { return; }
                if (typeM.SelectedItem is ComboBoxItem selectedItem)
                {
                    var utilFunctions = new UtillFunctions();

                    // Ensure SelectedItem is not null before calling ToString()

                    string taskTypeS = selectedItem.Content.ToString().ToLower();
                    if (string.IsNullOrEmpty(taskTypeS))
                    {
                        MessageBox.Show("Invalid selection. Please select a valid task type.");
                        return;
                    }

                    int taskType = utilFunctions.GetTaskTypeFromString(taskTypeS);

                    var mainList = context.Maintenances
                        .Where(m => m.TaskType == taskType)
                        .Select(m => new
                        {
                            m.MaintenanceId,
                            m.RoomNumber,
                            m.Description,
                            TaskStatus = utilFunctions.GetTaskStatusFromInt(m.TaskStatus)
                        }).ToList();
                    MaintenanceDataGrid.ItemsSource = mainList;
                }
                }
            }
        }


    }

