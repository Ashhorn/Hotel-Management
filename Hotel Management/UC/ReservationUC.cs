using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Hotel_Management.UC
{
    public partial class ReservationUC : UserControl
    {
        DataClasses1DataContext dbRooms = new DataClasses1DataContext();
        DataClasses1DataContext dbReservations = new DataClasses1DataContext();
        public ReservationUC()
        {
            InitializeComponent();
            LoadAvailableRoomNumbers();
        }


        private void label9_Click(object sender, EventArgs e)
        {
            gridview1.Refresh();
        }

        private void Clear()
        {
            comboBoxRoomType.SelectedIndex = 0;
            comboBoxRoomNo.SelectedIndex = 0;
            textBoxClientId.Clear();
            dateTimePickerIn.Value = DateTime.Now;
            dateTimePickerOut.Value = DateTime.Now;
            tabControlReservation.SelectedTab = tabPageAddReservation;


        }

        private void Clear1()
        {
            comboBoxRoomType1.SelectedIndex = 0;
            comboBoxRoomNo1.SelectedIndex = 0;
            textBoxClientId1.Clear();
            dateTimePickerIn1.Value = DateTime.Now;
            dateTimePickerOut1.Value = DateTime.Now;



        }

        private void tabPageAddReservation_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void tabPageUpdateCancel_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void LoadAvailableRoomNumbers()
        {
            // Assuming YourDataContext is the name of your LINQ to SQL DataContext
            using (DataClasses1DataContext dbRoom = new DataClasses1DataContext())
            {
                // Retrieve available room numbers (assuming "isFree" column is used)
                var availableRoomNumbers = dbRoom.rooms
                    .Where(room => room.booked == "No")
                    .Select(room => room.roomNo)
                    .ToList();

                // Clear existing items in the combo box
                comboBoxRoomNo.Items.Clear();

                // Add available room numbers to the combo box
                comboBoxRoomNo.Items.AddRange(availableRoomNumbers.Select(roomNo => (object)roomNo).ToArray());

            }
        }

        private int GetRoomNumberForClient(int clientID)
        {
            using (DataClasses1DataContext dbReservations = new DataClasses1DataContext())
            {
                ReservationTable existingReservation = dbReservations.ReservationTables
                    .SingleOrDefault(reservation => reservation.Reservation_Client_ID == clientID);

                return existingReservation?.Reservation_Room_Number ?? 0;
            }
        }

        private void InitializeForm()
        {
            LoadAvailableRoomNumbers();
            LoadAvailableRoomNumbers1();
        }

        private void UpdateRoomStatus(int roomNumber, bool isFree)
        {
            using (DataClasses1DataContext dbRooms = new DataClasses1DataContext())
            {
                // Retrieve the RoomsTable record for the specified roomNumber
                room roomToUpdate = dbRooms.rooms.SingleOrDefault(room => room.roomid == roomNumber);

                if (roomToUpdate != null)
                {
                    // Update the isFree column
                    roomToUpdate.booked = isFree ? "Yes" : "No";

                    // Save changes to the database
                    dbRooms.SubmitChanges();
                }
            }
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            string roomType = comboBoxRoomType.Text;
            int roomNumber = Convert.ToInt32(comboBoxRoomNo.Text);
            int clientID = Convert.ToInt32(textBoxClientId.Text);
            string checkInDate = dateTimePickerIn.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string checkOutDate = dateTimePickerOut.Value.ToString("yyyy-MM-dd HH:mm:ss");

            // Create a new ReservationTable object
            ReservationTable newReservation = new ReservationTable
            {
                Reservation_Room_Type = roomType,
                Reservation_Room_Number = roomNumber,
                Reservation_Client_ID = clientID,
                Reservation_In = checkInDate,
                Reservation_Out = checkOutDate
            };

            // Add the new reservation to the database
            dbReservations.ReservationTables.InsertOnSubmit(newReservation);
            dbReservations.SubmitChanges();

            MessageBox.Show("Reservation added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UpdateRoomStatus(roomNumber, false);
        }

        private void UpdateReservation(int clientID, string roomType, int roomNumber, string checkInDate, string checkOutDate)
        {
            using (DataClasses1DataContext dbReservations = new DataClasses1DataContext())
            {
                // Retrieve the existing reservation based on Client_ID
                ReservationTable existingReservation = dbReservations.ReservationTables.SingleOrDefault(reservation => reservation.Reservation_Client_ID == clientID);

                if (existingReservation != null)
                {
                    // Update the properties of the existing reservation
                    existingReservation.Reservation_Room_Type = roomType;
                    existingReservation.Reservation_Room_Number = roomNumber;
                    existingReservation.Reservation_In = checkInDate;
                    existingReservation.Reservation_Out = checkOutDate;

                    // Save changes to the database
                    dbReservations.SubmitChanges();

                    MessageBox.Show("Reservation updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Reservation not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonUpdateR_Click(object sender, EventArgs e)
        {
            int clientID = Convert.ToInt32(textBoxClientId1.Text);
            string roomType = comboBoxRoomType1.Text;
            int roomNumber = Convert.ToInt32(comboBoxRoomNo1.Text);
            string checkInDate = dateTimePickerIn1.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string checkOutDate = dateTimePickerOut1.Value.ToString("yyyy-MM-dd HH:mm:ss");

            UpdateReservation(clientID, roomType, roomNumber, checkInDate, checkOutDate);

            // Optionally, update room status if needed
            UpdateRoomStatus(roomNumber, false);
        }

        private void ReservationUC_Load(object sender, EventArgs e)
        {
            var reservationdetail = (from x in dbReservations.ReservationTables select x).ToList();
            gridview1.DataSource = reservationdetail;

            comboBoxRoomType1.SelectedIndex = 0;
            comboBoxRoomNo1.SelectedIndex = 0;
            comboBoxRoomType.SelectedIndex = 0;
            comboBoxRoomNo.SelectedIndex = 0;
            LoadAvailableRoomNumbers();
            LoadAvailableRoomNumbers1();

        }

        private void buttonCancelR_Click(object sender, EventArgs e)
        {
            int clientID = Convert.ToInt32(textBoxClientId1.Text);

            // Assuming you have a method or variable to get the room number associated with the client ID
            int roomNumber = GetRoomNumberForClient(clientID);

            // Delete the reservation
            DeleteReservation(clientID);
            if (roomNumber != 0) // Check if room number is valid
            {
                UpdateRoomStatus(roomNumber, true);
            }
        }
        private void DeleteReservation(int clientID)
        {
            using (DataClasses1DataContext dbReservations = new DataClasses1DataContext())
            {
                // Retrieve the existing reservation based on Client_ID
                ReservationTable existingReservation = dbReservations.ReservationTables.SingleOrDefault(reservation => reservation.Reservation_Client_ID == clientID);

                if (existingReservation != null)
                {
                    // Remove the reservation from the database
                    dbReservations.ReservationTables.DeleteOnSubmit(existingReservation);

                    // Save changes to the database
                    dbReservations.SubmitChanges();

                    MessageBox.Show("Reservation canceled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Reservation not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadAvailableRoomNumbers1()
        {
            // Assuming YourDataContext is the name of your LINQ to SQL DataContext
            using (DataClasses1DataContext dbRooms = new DataClasses1DataContext())
            {
                var availableRoomNumbers = dbRooms.rooms
                    .Where(room => room.booked == "Yes")
                    .Select(room => room.roomNo)
                    .ToList();

                comboBoxRoomNo1.Items.Clear();
                comboBoxRoomNo1.Items.AddRange(availableRoomNumbers.Select(roomNo => (object)roomNo).ToArray());
            }
        }

    }
}
