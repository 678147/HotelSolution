using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelLibrary;
using Microsoft.EntityFrameworkCore;
using HotelLibrary.DBContex;
namespace ResepsjonDesktopApp
{
    public partial class ResepsjonForm : Form
    {
        private readonly AppDbContext _dbContext;

        public ResepsjonForm(AppDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;

            buttonNewTask.Click += buttonNewTask_Click;
            LoadMaintenanceTasks();
        }

        private void LoadMaintenanceTasks()
        {
            UtillFunctions utilFunctions = new UtillFunctions();
            try
            {
                var mainList = _dbContext.Maintenances
                        .Select(m => new
                        {
                            m.MaintenanceId,
                            m.RoomNumber,
                            m.Description,
                            TaskStatus = utilFunctions.GetTaskStatusFromInt(m.TaskStatus),
                            TaskType = utilFunctions.GetMaintenanceTypeFromInt(m.TaskType)
                        }).ToList();

                dataGridViewMaintenance.DataSource = mainList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Feil under lasting av oppgaver: {ex.Message}");
            }
        }

        private void buttonNewTask_Click(object sender, EventArgs e)
        {
            // Åpne AddMaintenanceForm
            var addForm = new AddMaintenanceForm(_dbContext);
            var result = addForm.ShowDialog();

            // Hvis brukeren lagret en ny oppgave (f.eks. via DialogResult.OK)
            if (result == DialogResult.OK)
            {
                LoadMaintenanceTasks(); // Last oppdatert liste
            }
        }

        private void buttonNewTask_Click_1(object sender, EventArgs e)
        {

        }
    }

}