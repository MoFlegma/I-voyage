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
using System.Runtime.Versioning;


namespace GestionDeVols
{
    public partial class VolAnnuler : Form
    {
        public VolAnnuler()
        {
            InitializeComponent();
            populate();
            FillBilletId(); 
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\26134\Documents\ivoyageDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string query = "select * from VOLANNULERTABLE";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
           // SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CancellationDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void FillBilletId()
        {
            //string AvionStatus = "Disponible";
            Con.Open();
            SqlCommand cmd = new SqlCommand("select BilletId from RESERVATIONTABLE", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("BilletId", typeof(int));
            dt.Load(rdr);
            BilletIdCb.ValueMember = "BilletId";
            BilletIdCb.DataSource = dt;
            Con.Close();
        }

        public static DateTime Today { get;set; }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (BilletIdCb.SelectedIndex == -1)
            {
                MessageBox.Show("Information manquante");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "insert into VOLANNULERTABLE  values(" + BilletIdCb.SelectedValue.ToString() + ")";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Annulation de vol accepté avec succès");
                    Con.Close();
                    populate();
                    Supprimer();
                    FillBilletId();
                    BilletIdCb.SelectedIndex = -1; 

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void Supprimer()
        {

         try
           {
               Con.Open();
               String Query = "Delete from RESERVATIONTABLE where BilletId=" +BilletIdCb.SelectedValue.ToString()+ "";
               SqlCommand cmd = new SqlCommand(Query, Con);
               cmd.ExecuteNonQuery();
               Con.Close();
             }
          catch (Exception Ex)
             {
             MessageBox.Show(Ex.Message);
          }
        }
    }
}
