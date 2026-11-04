using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joseph_Gonzalez
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMembership_Click(object sender, EventArgs e)
        {
            MembershipForm membershipForm = new MembershipForm();
            membershipForm.ShowDialog();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            StaffForm staffForm = new StaffForm();
            staffForm.ShowDialog();
        }
    }
}
