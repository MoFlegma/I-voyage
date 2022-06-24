using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionDeVols
{
    public partial class Passager : Form
    {
        public Passager()
        {
            InitializeComponent();
            populate();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\26134\Documents\ivoyageDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string query = "select * from PASSAGERTABLE";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PassagerDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string Passagersexes = "";
            if (PassagerNomTb.Text == "" || PassagerTelephoneTb.Text == "" || PassagerAdresseTb.Text == "")
            {
                MessageBox.Show("Information manquante");
            }
            else
            {
                if (HommeRb.Checked == true)
                {
                    Passagersexes = "Homme";
                }
                else if (FemmeRb.Checked == true)
                {
                    Passagersexes = "Femme";
                }
                try
                {
                    Con.Open();
                    string Query = "insert into PASSAGERTABLE  values('"+PassagerNomTb.Text+"','"+PassagerAdresseTb.Text+"','"+Passagersexes+"','"+PassagerNationalityCb.SelectedItem.ToString()+"','"+PassagerTelephoneTb.Text+"')";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("passager ajouté avec succès");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Reset()
        {
            PassagerNomTb.Text = "";
            PassagerAdresseTb.Text = "";
            PassagerTelephoneTb.Text ="";
            HommeRb.Checked = false;
            FemmeRb.Checked = false;
            PassagerNationalityCb.SelectedIndex = -1;
            key = 0;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Reset();
        }
        int key = 0;
        private void PassagerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PassagerNomTb.Text = PassagerDGV.SelectedRows[0].Cells[1].Value.ToString();
            PassagerAdresseTb.Text = PassagerDGV.SelectedRows[0].Cells[2].Value.ToString();
            PassagerNationalityCb.SelectedItem = PassagerDGV.SelectedRows[0].Cells[4].Value.ToString();
            PassagerTelephoneTb.Text = PassagerDGV.SelectedRows[0].Cells[5].Value.ToString();
            if (PassagerNomTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(PassagerDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Sélectionner le passager à supprimer");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "Delete from PASSAGERTABLE where PassagerId=" + key + "";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("passager supprimer avec succès");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string Passagersexes = "";
            if (PassagerNomTb.Text == "" || PassagerTelephoneTb.Text == "" || PassagerAdresseTb.Text == "")
            {
                MessageBox.Show("Information manquante");
            }
            else
            {
                if (HommeRb.Checked == true)
                {
                    Passagersexes = "Homme";
                }
                else if (FemmeRb.Checked == true)
                {
                    Passagersexes = "Femme";
                }
                try
                {
                    Con.Open();
                    string Query = "update PASSAGERTABLE set PassagerNom= '" + PassagerNomTb.Text + "',PassagerAdress='" + PassagerAdresseTb.Text + "',PassagerSexe='" + Passagersexes+ "',PassagerNationalite= '"+PassagerNationalityCb.SelectedItem.ToString()+"',PassagerTelephone='"+PassagerTelephoneTb.Text+"' where PassagerId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("passager modifié avec succès");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Passager_Load(object sender, EventArgs e)
        {

        }
    }
}
