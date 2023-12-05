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
    public partial class SignUpUC : UserControl
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public FormLogin FormLogin;
        public SignUpUC(FormLogin formLogin)
        {
            InitializeComponent();
            FormLogin = formLogin;
        }
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin.SignInUC.BringToFront();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtfirst.Text != "" && txtlast.Text != "" && txtpass.Text != "" && txtuser.Text != "")
            {
                UserTable usertabla = new UserTable();
                usertabla.First_Name = txtfirst.Text;
                usertabla.Last_Name = txtlast.Text;
                usertabla.User_Name = txtuser.Text;
                usertabla.User_Password = txtpass.Text;

                db.UserTables.InsertOnSubmit(usertabla);
                db.SubmitChanges();
                MessageBox.Show("Data Inserted Successfully");

                txtfirst.Clear();
                txtlast.Clear();
                txtpass.Clear();
                txtpass2.Clear();
                txtuser.Clear();
            }
            else
            {
                MessageBox.Show("Fill All Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}