using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintPatriickHospitalSystem
{
    //User controls
    public partial class UCMenu : UserControl
    {
        public UCMenu()
        {
            InitializeComponent();
        }

        //Manages patient button
        private void btnPat_Click(object sender, EventArgs e)
        {
            UCPatients ucp = new UCPatients();
            this.Hide();
            this.Parent.Controls.Add(ucp);
        }
        //Manages employees button
        private void btnEmp_Click(object sender, EventArgs e)
        {
            UCEmployees uce = new UCEmployees();
            this.Hide();
            this.Parent.Controls.Add(uce);

        }
        //Panel Page Title
        private void pnltop_Paint(object sender, PaintEventArgs e)
        {

        }
        //Panel BackGround Main Menu Container
        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
