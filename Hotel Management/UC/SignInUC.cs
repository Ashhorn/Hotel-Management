using Hotel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management.UC
{
    public partial class SignInUC : UserControl
    {

        public FormLogin FormLogin;
        public SignInUC(FormLogin formLogin)
        {
            InitializeComponent();
            FormLogin = formLogin;
        }

        DataClasses1DataContext dbHotel = new DataClasses1DataContext();

        private void SignUp_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin.SignUpUC.BringToFront();


        }

        private void loginbutton_Click_1(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            // Use Any() to check if there's any user with the specified username
            bool userExists = dbHotel.UserTables.Any(x => x.User_Name == username);

            if (userExists)
            {
                // Use Single() to retrieve the user with the specified username
                var user = dbHotel.UserTables.Single(x => x.User_Name == username);

                if (user.User_Password == password)
                {

                    ParentForm.Hide();
                    // Replace Form with your main form type
                    LoadingForm mainForm1 = new LoadingForm();
                    mainForm1.ShowDialog();


                }

                else
                {
                    MessageBox.Show("Invalid Password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("User not found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBoxShow_Click_2(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            tbPassword.UseSystemPasswordChar = false;
            pictureBoxHide.Show();

        }

        private void pictureBoxHide_Click_2(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            tbPassword.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
        }
    }
}