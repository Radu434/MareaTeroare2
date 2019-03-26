using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace Marea_Teroare
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            wPlayer.URL = ("soundTrack.aac");
            wPlayer.controls.play();

        }
        WMPLib.WindowsMediaPlayer wPlayer = new WMPLib.WindowsMediaPlayer();
       
        

        private void btnStalin_Click(object sender, EventArgs e)
        {
            txtMain.Visible = true;
            txtMain.Text = File.ReadAllText("Stalin1.txt");
            pbTop.Image = global::Marea_Teroare.Properties.Resources.Stalin1;
            pbMid.Image = global::Marea_Teroare.Properties.Resources.young_Stalin;
            pbBot.Image = global::Marea_Teroare.Properties.Resources.stalin2;
            lblTitlu.Text = "Iosif Vissarionovici Stalin";
            
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (frmMain.ActiveForm.WindowState == FormWindowState.Maximized || frmMain.ActiveForm.WindowState == FormWindowState.Normal)
            {
                frmMain.ActiveForm.WindowState = FormWindowState.Minimized;
            }
        }

        private void btnMinMax_Click_1(object sender, EventArgs e)
        {
            if (frmMain.ActiveForm.WindowState == FormWindowState.Maximized)
            {
                frmMain.ActiveForm.WindowState = FormWindowState.Normal;
            }
            else if (frmMain.ActiveForm.WindowState != FormWindowState.Maximized)
            {
                frmMain.ActiveForm.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

       
        private void lblText_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMain.Visible = true;
            txtMain.Text = File.ReadAllText("Revolutia1.txt");
            pbTop.Image = global::Marea_Teroare.Properties.Resources.Lenin1;
            pbMid.Image= global::Marea_Teroare.Properties.Resources.lenin2;
            pbBot.Image= global::Marea_Teroare.Properties.Resources.soldati;
            lblTitlu.Text = "Revolutia Bolsevica";
        }

        private void btnNKVD_Click(object sender, EventArgs e)
        {
            txtMain.Visible = true;
            txtMain.Text = File.ReadAllText("NKVD.txt");
            pbTop.Image = global::Marea_Teroare.Properties.Resources.StemaNKVD;
            pbMid.Image = global::Marea_Teroare.Properties.Resources.ofiterNKVD;
            pbBot.Image = global::Marea_Teroare.Properties.Resources.victimeNKVD;
            lblTitlu.Text = "NKVD";

        }

        private void btnGulag_Click(object sender, EventArgs e)
        {
            txtMain.Visible = true;
            txtMain.Text = File.ReadAllText("Gulag.txt");
            pbTop.Image = global::Marea_Teroare.Properties.Resources.gulagMap;
            pbMid.Image = global::Marea_Teroare.Properties.Resources.gulagPrizonieri;
            pbBot.Image = global::Marea_Teroare.Properties.Resources.gulag2;
            lblTitlu.Text = "Lagarele de Munca Fortata";



        }
        
     

        private void btnHardbass_Click(object sender, EventArgs e)
        {
            
            
            wPlayer.URL=("hardbass.mp3");
            wPlayer.controls.play();
        }

       
    }
}
