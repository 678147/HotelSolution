using System;
using System.Linq;
using System.Windows.Forms;
using HotelLibrary;
using HotelLibrary.DBContex;
using HotelLibrary.Models;

namespace ResepsjonDesktopApp
{
    public partial class RoomReservationForm : Form
    {
        private readonly AppDbContext _dbContext;

        public RoomReservationForm()
        {
            InitializeComponent();

            _dbContext = new AppDbContext(); // Lager ny kobling til databasen

            LoadRooms();
        }

        private void LoadRooms()
        {
            UtillFunctions utilFunctions = new UtillFunctions();
            try
            {
                var rooms = _dbContext.Rooms
                    .Select(r => new
                    {
                        r.RoomNumber,
                        RoomType = utilFunctions.GetRoomTypeFromInt(r.RoomType),
                        r.RoomSize
                    }).ToList();
                dataGridViewRooms.DataSource = rooms;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Feil ved lasting av rom: {ex.Message}");
            }
        }

        private void buttonNewReservation_Click(object sender, EventArgs e)
        {
            if (dataGridViewRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Velg et rom først.");
                return;
            }
            // Hent valgt RoomNumber fra grid
            int selectedRoomNumber = (int)dataGridViewRooms.SelectedRows[0].Cells["RoomNumber"].Value;
            String email = textBoxEmail.Text;
            DateTime checkInDate = dateTimePickerCheckInn.Value;
            DateTime checkOutDate = dateTimePickerCheckOut.Value;
            UtillFunctions utilFunctions = new UtillFunctions();
            if (_dbContext.Users.Any(u => u.Email != email))
            {
                MessageBox.Show("Brukeren finnes ikke i databasen.");
                return;
            }
            try
            {
                utilFunctions.registerBooking(email, selectedRoomNumber, checkInDate, checkOutDate);
                MessageBox.Show("Reservasjon registrert.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Feil ved registrering av reservasjon: {ex.Message}");
                MessageBox.Show(selectedRoomNumber.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSeReservasjoner_Click(object sender, EventArgs e)
        {
            var bookingForm = new SeReservasjonerForm(_dbContext);
            bookingForm.ShowDialog();
        }
    }
}

