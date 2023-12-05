using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management.Forms
{
    public partial class AddRooms : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public AddRooms()
        {
            InitializeComponent();
        }

        private void confirmedbtn_Click(object sender, EventArgs e)
        {
            string prodid = (txtroomnumber.Text);
            var stexist = from s in db.rooms where s.roomNo == prodid select s.roomNo;
            if(stexist.Count()> 0)
            {
                MessageBox.Show("Can not insert duplicate record.");
            }
            else if (txtbed.Text != "" && txtprice.Text != "" && txtroomnumber.Text != "" && txtroomtype.Text != "")
            {
                room rooma = new room();
                rooma.roomNo = txtroomnumber.Text;
                rooma.roomType = txtroomtype.Text;
                rooma.bed = txtbed.Text;
                rooma.price = Int64.Parse(txtprice.Text);
                db.rooms.InsertOnSubmit(rooma);
                db.SubmitChanges();
                MessageBox.Show("Data Inserted Successfully");

            }
            else
            {
                MessageBox.Show("Fill All Fields","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
