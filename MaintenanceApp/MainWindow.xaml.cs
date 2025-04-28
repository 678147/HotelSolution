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

        private void LoadComboBoxOptions()
        {
            using var context = new AppDbContext();
            var utilFunctions = new UtillFunctions();


            var mTypes = context.Maintenances.Select(m => utilFunctions.GetMaintenanceTypeFromInt(m.TaskType)).Distinct().ToList();

            maintenanceTypes.ItemsSource = mTypes;
        }
    }
}
