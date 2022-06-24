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
    public partial class NosAvions : Form
    {
        public NosAvions()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\26134\Documents\ivoyageDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from  AVIONTABLE";
            SqlDataAdapter sda = new SqlDataAdapter(query , Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AvionDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
        String AvionStatus="";
        if(AvionNomTb.Text == "" || AvionCapaciteTb.Text== "" )
            {
                MessageBox.Show("Information manquante");
            }
            else
            {
                if(OccuopeRb.Checked == true)
                {
                    AvionStatus = "Occupé";
                }else if(DisponibleRb.Checked == true)
                {
                    AvionStatus = "Disponible";
                }
                try
                {
                    Con.Open();
                    String Query = "insert into AVIONTABLE values('" + AvionNomTb.Text + "','" + AvionCapaciteTb.Text + "','"+AvionStatus+"')";
                    SqlCommand cmd = new SqlCommand(Query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("avion ajouté avec succès");
                    Con.Close();
                    populate();
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void reset()
        {
            AvionNomTb.Text = "";
            AvionCapaciteTb.Text = "";
            OccuopeRb.Checked = false;
            DisponibleRb.Checked = false;
            key = 0;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            reset();
        }

        int key = 0;
        private void AvionDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AvionNomTb.Text = AvionDGV.SelectedRows[0].Cells[1].Value.ToString();
            AvionCapaciteTb.Text = AvionDGV.SelectedRows[0].Cells[2].Value.ToString();
            if (AvionNomTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(AvionDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if(key== 0)
            {
                MessageBox.Show("Sélectionner l'avion à supprimer");
            }
            else
            {
                try
                {
                    Con.Open();
                    String Query = "Delete from AVIONTABLE where AvionId="+key+"";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("avion supprimer avec succès");
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
             String AvionStatus = "";
             if (AvionNomTb.Text == "" || AvionCapaciteTb.Text == "")
             {
                 MessageBox.Show("Information manquante");
             }
             else
             {
                 if (OccuopeRb.Checked == true)
                 {
                     AvionStatus = "Occupé";
                 }
                 else if (DisponibleRb.Checked == true)
                 {
                     AvionStatus = "Disponible";
                 }
                 try
                 {
                     Con.Open();
                     string Query = "update AVIONTABLE set AvionNom= '"+AvionNomTb.Text+"',AvionCapacite="+AvionCapaciteTb.Text+",AvionStatu='"+AvionStatus+"' where AvionId="+key+";";
                     SqlCommand cmd = new SqlCommand(Query, Con);
                     cmd.ExecuteNonQuery();
                     MessageBox.Show("avion modifié avec succès");
                     Con.Close();
                     populate();
                 }
                 catch (Exception Ex)
                 {
                     MessageBox.Show(Ex.Message);
                 }
             }
         }

        private void RechercheTb_TextChanged(object sender, EventArgs e)
        {
        }

        private void recherchebtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select * from  AVIONTABLE where AvionNom ='"+RechercheTb.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AvionDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
