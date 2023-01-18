using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeMonetSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        
        
        //Manages user controls
        ManageUC mnguc = new ManageUC();
        //Sets Main Menu button
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            UCMenu ucm = new UCMenu();
            panBtnDetail.Height = btnMainMenu.Height;
            panBtnDetail.Top = btnMainMenu.Top;
            mnguc.DisplayControl(ucm, panelContainer);
        
        }
        //Sets Employee menu button
        private void btnEmp_Click(object sender, EventArgs e)
        {
            UCEmployees uce = new UCEmployees();
            panBtnDetail.Height = btnEmp.Height;
            panBtnDetail.Top = btnEmp.Top;
            mnguc.DisplayControl(uce, panelContainer);
        }
        //Sets Patient menu button
        private void btnPat_Click(object sender, EventArgs e)
        {

            UCPatients ucp = new UCPatients();
            panBtnDetail.Height = btnPat.Height;
            panBtnDetail.Top = btnPat.Top;
            mnguc.DisplayControl(ucp, panelContainer);
        }
        //Sets menu button
        private void MainMenu_Load(object sender, EventArgs e)
        {
            UCMenu ucm = new UCMenu();
            panBtnDetail.Height = btnMainMenu.Height;
            panBtnDetail.Top = btnMainMenu.Top;
            mnguc.DisplayControl(ucm, panelContainer);

        }
        //Sets Logout menu button
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            panBtnDetail.Height = btnLogout.Height;
            panBtnDetail.Top = btnLogout.Top;
            this.Close();
            f1.Show();           

        }
        //Sets Exit button
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        ////Sets Form1 Panel Container
        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
