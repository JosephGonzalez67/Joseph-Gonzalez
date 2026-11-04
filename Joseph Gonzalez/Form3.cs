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
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
            // Al iniciar, ocultar los paneles de información
            pilatesPanelInfo.Visible = false;
            karatePanelsInfo.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPilatesStaff_Click(object sender, EventArgs e)
        {
            pilatesPanelInfo.Visible = false;
            pilatesPanelInfo.Visible = true;
        }

        private void btnKarateStaff_Click(object sender, EventArgs e)
        {
            karatePanelsInfo.Visible = false;
            karatePanelsInfo.Visible = true;
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pilatesPanelInfo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
