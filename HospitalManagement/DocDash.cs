using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement
{
    public partial class DocDash : Form
    {
        public DocDash()
        {
            InitializeComponent();
        }

        private void DocDash_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDBDataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.hospitalDBDataSet1.Users);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
