using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Web.UI.Design.WebControls;
using Hotel_Management;
using Hotel_Management.UC;

namespace Hotel
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

        }
        public SignInUC SignInUC { get; set; }
        public SignUpUC SignUpUC { get; set; }

        private void FormLoginRightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormLoginRightPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext dbHotel = new DataClasses1DataContext();

            SignInUC = new SignInUC(this);
            SignUpUC = new SignUpUC(this);

            FormLoginRightPanel.Controls.Add(SignInUC);

            FormLoginRightPanel.Controls.Add(SignUpUC);
        }
    }
}
