using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizedesign();
        }
        private void customizedesign()
        {
            panelMediaSubmenu.Visible = false;
            PanelPlaylistSubmenu.Visible = false;
            PanelToolsmediaSubmenu.Visible = false;
        }

        private void hidesubmenu()
        {
            if (panelMediaSubmenu.Visible == true)
                panelMediaSubmenu.Visible = false;

            if (PanelPlaylistSubmenu.Visible == true)
                PanelPlaylistSubmenu.Visible = false;

            if (PanelToolsmediaSubmenu.Visible == true)
                PanelToolsmediaSubmenu.Visible = false;

        }

        private void showsubmenu(Panel Submenu)
        {
            if (Submenu.Visible == false)
            {
                hidesubmenu();
                Submenu.Visible = true;
            }
            else
            {
                Submenu.Visible = false;
            }
        }

        private void Help_Click(object sender, EventArgs e)
        {
            hidesubmenu();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showsubmenu(panelMediaSubmenu);
        }

        private void panelMediaSubmedia_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hidesubmenu();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            hidesubmenu();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            hidesubmenu();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            showsubmenu(PanelPlaylistSubmenu);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hidesubmenu();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            hidesubmenu();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            hidesubmenu();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            hidesubmenu();

        }

        private void Tools_Click(object sender, EventArgs e)
        {
            showsubmenu(PanelToolsmediaSubmenu);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            hidesubmenu();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            hidesubmenu();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            hidesubmenu();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            hidesubmenu();

        }

        private Form activeform = null;
        private void openchildform(Form childform)
        {
            if(activeform!= null)
                activeform.Close();
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            PanelChildForm.Controls.Add(childform);
            PanelChildForm.Tag = childform;
            childform.BringToFront();
            childform.Show();

            
        }
    }
}
