using System;
using System.Windows.Forms;
using HotelLibrary.Models;
using HotelLibrary.DBContex;

namespace ResepsjonDesktopApp
{
    public partial class AddMaintenanceForm : Form
    {
        private readonly AppDbContext _dbContext;

        public AddMaintenanceForm()
        {
            InitializeComponent();

            // Fyll comboboxene
            comboBoxTaskType.Items.AddRange(new string[] { "Cleaning", "Maintenance", "RoomService" });
            comboBoxTaskType.SelectedIndex = 0;

            comboBoxTaskStatus.Items.AddRange(new string[] { "New", "InProgress", "Done" });
            comboBoxTaskStatus.SelectedIndex = 0;
        }

        public AddMaintenanceForm(AppDbContext dbContext) : this()
        {
            _dbContext = dbContext;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (_dbContext == null)
            {
                MessageBox.Show("Database-tilkobling mangler.");
                return;
            }

            try
            {
                string description = textBoxDescription.Text.Trim();
                if (string.IsNullOrEmpty(description))
                {
                    MessageBox.Show("Beskrivelse må fylles ut.");
                    return;
                }

                if (!int.TryParse(textBoxRoomNumber.Text.Trim(), out int roomNumber))
                {
                    MessageBox.Show("Romnummer må være et gyldig tall.");
                    return;
                }

                int taskType = comboBoxTaskType.SelectedIndex+1;
                int taskStatus = comboBoxTaskStatus.SelectedIndex+1;

                var newTask = new Maintenance
                {
                    Description = description,
                    RoomNumber = roomNumber,
                    TaskType = taskType,
                    TaskStatus = taskStatus
                };

                _dbContext.Maintenances.Add(newTask);
                _dbContext.SaveChanges();

                MessageBox.Show("Oppgave lagret!");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Feil ved lagring: {ex.Message}");
            }
        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {

        }
    }
}
