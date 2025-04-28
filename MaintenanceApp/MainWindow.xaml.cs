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
                int taskType;
        
                taskType = utilFunctions.GetTaskTypeFromString(typeM.SelectedItem.ToString());

                var maintChange = context.Maintenances
                    .Where(m => m.RoomNumber == roomNumber && m.TaskType == taskType)
                    .FirstOrDefault();
                if (maintChange != null)
                { 
                    if (description != "" || description != null) maintChange.Description = description;
                    
                    if(taskType < 3) maintChange.TaskStatus = taskType++;
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
                if (typeM.SelectedItem == null) { return; }
                else
                {

                    var utilFunctions = new UtillFunctions();


                    int taskType = utilFunctions.GetTaskTypeFromString(typeM.SelectedItem.ToString());

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
