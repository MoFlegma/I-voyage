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
    public partial class Voyages : Form
    {
        public Voyages()
        {
            InitializeComponent();
            populate();
            FillVoyageCodeCb();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\26134\Documents\ivoyageDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from  VOYAGETABLE";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            VoyageDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void FillVoyageCodeCb()
        {
            string AvionStatus = "Disponible";
            Con.Open();
            SqlCommand cmd = new SqlCommand("select AvionId from AVIONTABLE where AvionStatu='"+AvionStatus+"' ", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("AvionId",typeof(int));
            dt.Load(rdr);
            VoyageCodeCb.ValueMember = "AvionId";
            VoyageCodeCb.DataSource = dt;
            Con.Close();
        }




        private void Voyages_Load(object sender, EventArgs e)
        {

        }
        private void ChangeStatus()
        {
            String AvionStatus = "Occupé";
                try
                {
                    Con.Open();
                    string Query = "update AVIONTABLE set AvionStatu='" + AvionStatus + "' where AvionId=" + VoyageCodeCb.SelectedValue.ToString() + ";";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("avion modifié avec succès");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (VoyageCoutTb.Text == "" || VoyageCodeCb.SelectedIndex == -1 || VoyageSourceCb.SelectedIndex == -1 || VoyageDestinationCb.SelectedIndex == -1)
            {
                MessageBox.Show("Information manquante");
            }
            else
                try
                {
                    Con.Open();
                    string Query = "insert into VOYAGETABLE  values('" +VoyageDateDt.Value+ "','" +VoyageCodeCb.SelectedValue.ToString()+ "','"+VoyageSourceCb.SelectedItem.ToString()+ "','" +VoyageDestinationCb.SelectedItem.ToString() + "'," + VoyageCoutTb.Text + ")";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("voyage ajouté avec succès");
                    Con.Close();
                    populate();
                    ChangeStatus();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

        }

        private void Reset()
        {
            VoyageSourceCb.SelectedIndex = -1;
            VoyageDestinationCb.SelectedIndex = -1;
            //VoyageCodeCb.SelectedIndex = -1;
            VoyageCoutTb.Text = "";
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (VoyageSourceCb.SelectedIndex == -1 || VoyageDestinationCb.SelectedIndex == -1 || VoyageCoutTb.Text == "")
            {
                MessageBox.Show("Information manquante");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "update VOYAGETABLE set VoyageDate= '" + VoyageDateDt.Value + "',VoyageAvion=" +VoyageCodeCb.SelectedValue.ToString() + ",VoyageSource='" + VoyageSourceCb.SelectedItem.ToString() + "',VoyageDestination= '" + VoyageDestinationCb.SelectedItem.ToString() + "',VoyageCout=" + VoyageCoutTb.Text + " where VoyageCode=" + key + ";";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Voyage modifié avec succès");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int key = 0;
        private void VoyageDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            VoyageDateDt.Text = VoyageDGV.SelectedRows[0].Cells[1].Value.ToString();
            VoyageCodeCb.SelectedValue = VoyageDGV.SelectedRows[0].Cells[2].Value.ToString();
            VoyageSourceCb.SelectedItem = VoyageDGV.SelectedRows[0].Cells[3].Value.ToString();
            VoyageDestinationCb.SelectedItem = VoyageDGV.SelectedRows[0].Cells[4].Value.ToString();
            VoyageCoutTb.Text = VoyageDGV.SelectedRows[0].Cells[5].Value.ToString();
            if (VoyageCodeCb.SelectedIndex == -1)
            {
                key = 0;
                /*VoyageCoutTb.Text = "";
                VoyageSourceCb.SelectedIndex = -1;
                VoyageDestinationCb.SelectedIndex = -1;*/
            }
            else
            {
                key = Convert.ToInt32(VoyageDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
