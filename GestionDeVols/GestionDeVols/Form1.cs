using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GestionDeVols
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse
            );
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn( 0, 0, Width, Height, 25, 25));
            PnlNav.Height = BtnAcceuil.Height;
            PnlNav.Top = BtnAcceuil.Top;
            PnlNav.Left = BtnAcceuil.Left;
            BtnAcceuil.BackColor = Color.FromArgb(46, 51, 73);

            AcceuilTitre.Text = "Accueil";
            this.PnlFormLoader.Controls.Clear();
            Acceuil Accueil_Vrb = new Acceuil()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, };
            Accueil_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Accueil_Vrb);
            Accueil_Vrb.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void BtnAcceuil_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnAcceuil.Height;
            PnlNav.Top = BtnAcceuil.Top;
            PnlNav.Left = BtnAcceuil.Left;
            BtnAcceuil.BackColor = Color.FromArgb(46, 51, 73);

            AcceuilTitre.Text = "Accueil";
            this.PnlFormLoader.Controls.Clear();
            Acceuil Accueil_Vrb = new Acceuil()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true ,  };
            Accueil_Vrb.FormBorderStyle=FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Accueil_Vrb);
            Accueil_Vrb.Show();
        }


        private void BtnApropos_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnApropos.Height;
            PnlNav.Top = BtnApropos.Top;
            BtnApropos.BackColor = Color.FromArgb(46, 51, 73);

            AcceuilTitre.Text = "A propos";
            this.PnlFormLoader.Controls.Clear();
            Apropos Accueil_Vrb = new Apropos()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, };
            Accueil_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Accueil_Vrb);
            Accueil_Vrb.Show();
        }

        private void BtnAcceuil_Leave(object sender, EventArgs e)
        {
            BtnAcceuil.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnReservation_Leave(object sender, EventArgs e)
        {
            BtnReservation.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnApropos_Leave(object sender, EventArgs e)
        {
            BtnApropos.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button2_Cklic(object sender, EventArgs e)
        {
            PnlNav.Height = BtnAvion.Height;
            PnlNav.Top = BtnAvion.Top;
            BtnAvion.BackColor = Color.FromArgb(46, 51, 73);

            AcceuilTitre.Text = "Nos Avions";
            this.PnlFormLoader.Controls.Clear();
            NosAvions Accueil_Vrb = new NosAvions()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, };
            Accueil_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Accueil_Vrb);
            Accueil_Vrb.Show();
        }

        private void BtnPassager_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnPassager.Height;
            PnlNav.Top = BtnPassager.Top;
            BtnPassager.BackColor = Color.FromArgb(46, 51, 73);

            AcceuilTitre.Text = "Les passagers";
            this.PnlFormLoader.Controls.Clear();
            Passager Accueil_Vrb = new Passager()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, };
            Accueil_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Accueil_Vrb);
            Accueil_Vrb.Show();
        }

        private void BtnVoyage_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnVoyage.Height;
            PnlNav.Top = BtnVoyage.Top;
            BtnVoyage.BackColor = Color.FromArgb(46, 51, 73);

            AcceuilTitre.Text = "Les voyages";
            this.PnlFormLoader.Controls.Clear();
            Voyages Accueil_Vrb = new Voyages()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, };
            Accueil_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Accueil_Vrb);
            Accueil_Vrb.Show();
        }


        private void BtnReservation_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnReservation.Height;
            PnlNav.Top = BtnReservation.Top;
            BtnReservation.BackColor = Color.FromArgb(46, 51, 73);

            AcceuilTitre.Text = "Reservation";
            this.PnlFormLoader.Controls.Clear();
            Reservation Accueil_Vrb = new Reservation()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, };
            Accueil_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Accueil_Vrb);
            Accueil_Vrb.Show();
        }

        private void BtnVolAnnuler_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnVolAnnuler.Height;
            PnlNav.Top = BtnVolAnnuler.Top;
            BtnVolAnnuler.BackColor = Color.FromArgb(46, 51, 73);

            AcceuilTitre.Text = "Annulation de Vol";
            this.PnlFormLoader.Controls.Clear();
            VolAnnuler Accueil_Vrb = new VolAnnuler()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, };
            Accueil_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(Accueil_Vrb);
            Accueil_Vrb.Show();
        }

        private void BtnAvion_Leave(object sender, EventArgs e)
        {
            BtnAvion.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void BtnPassager_Leave(object sender, EventArgs e)
        {
            BtnPassager.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnVoyage_Leave(object sender, EventArgs e)
        {
            BtnVoyage.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnVolAnnuler_Leave(object sender, EventArgs e)
        {
            BtnVolAnnuler.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
