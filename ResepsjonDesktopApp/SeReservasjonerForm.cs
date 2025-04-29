using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelLibrary.DBContex;
using HotelLibrary.Models;

namespace ResepsjonDesktopApp
{
    public partial class SeReservasjonerForm : Form
    {
        private readonly AppDbContext _dbContext;
        public SeReservasjonerForm(AppDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
            registrerteResvasjonerGrid();
        }
        private void dataGridViewReservasjoner_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void registrerteResvasjonerGrid()
        {
            var bookings = _dbContext.Bookings.ToList();
            dataGridViewReservasjoner.DataSource = bookings;
        }

        private void buttonCheckInn_Click(object sender, EventArgs e)
        {
            if (dataGridViewReservasjoner.SelectedRows.Count == 0)
            {
                MessageBox.Show("Velg en reservasjon først.");
                return;
            }
            int selectedRoomNumber = (int)dataGridViewReservasjoner.SelectedRows[0].Cells["RoomNumber"].Value;
            
            var bookingStatus = _dbContext.Bookings
            .Where(m => m.RoomNumber == selectedRoomNumber)
            .FirstOrDefault();
            if(bookingStatus == null)
            {
                MessageBox.Show("Ingen reservasjon funnet for dette rommet.");
                return;
            }
            bookingStatus.CheckedIn = true;
            _dbContext.SaveChanges();
            registrerteResvasjonerGrid();
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            if (dataGridViewReservasjoner.SelectedRows.Count == 0)
            {
                MessageBox.Show("Velg en reservasjon først.");
                return;
            }
            int selectedRoomNumber = (int)dataGridViewReservasjoner.SelectedRows[0].Cells["RoomNumber"].Value;

            var bookingStatus = _dbContext.Bookings
            .Where(m => m.RoomNumber == selectedRoomNumber)
            .FirstOrDefault();
            if (bookingStatus == null)
            {
                MessageBox.Show("Ingen reservasjon funnet for dette rommet.");
                return;
            }
            Maintenance maintenance = new Maintenance()
            {
                RoomNumber = selectedRoomNumber,
                Description = "Rengjøring",
                TaskStatus = 1,
                TaskType = 1
            };

            _dbContext.Maintenances.Add(maintenance);
            bookingStatus.CheckedIn = false;
            _dbContext.SaveChanges();
            registrerteResvasjonerGrid();

        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridViewReservasjoner.SelectedRows.Count == 0)
            {
                MessageBox.Show("Velg en reservasjon først.");
                return;
            }
            int selectedRoomNumber = (int)dataGridViewReservasjoner.SelectedRows[0].Cells["RoomNumber"].Value;
            var bookingStatus = _dbContext.Bookings
            .Where(m => m.RoomNumber == selectedRoomNumber)
            .FirstOrDefault();
            _dbContext.Bookings.Remove(bookingStatus);
            _dbContext.SaveChanges();
            registrerteResvasjonerGrid();
        }
    }
}
