using Hotel_Management.Forms;
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
    public partial class RoomUC : UserControl
    {
        public MainForm MainForm;
        DataClasses1DataContext db = new DataClasses1DataContext();
        public RoomUC(MainForm Form)
        {
            InitializeComponent();
            MainForm = Form;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AddRooms addroom = new AddRooms();
            addroom.ShowDialog();
        }

        private void RoomUC_Load(object sender, EventArgs e)
        {
           var roomdetails = (from x in db.rooms select x).ToList();
            GridView1.DataSource = roomdetails;
        }

        private void GridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
