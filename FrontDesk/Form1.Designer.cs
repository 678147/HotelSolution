using System.Windows.Forms;
namespace FrontDesk
{
    public partial class Form1 : Form
    {
        private readonly AppDbContext _dbContext;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(AppDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
            LoadMaintenanceTasks();
        }

        private void LoadMaintenanceTasks()
        {
            // ...
        }
    }
}



