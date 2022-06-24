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
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
            populate();
            FillPassagerIdCb();
            FillVoyageCode();

        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\26134\Documents\ivoyageDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from  RESERVATIONTABLE";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ReservationDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void FillPassagerIdCb()
        {
            //string AvionStatus = "Disponible";
            Con.Open();
            SqlCommand cmd = new SqlCommand("select PassagerId from PASSAGERTABLE", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PassagerId", typeof(int));
            dt.Load(rdr);
            PassagerIdCb.ValueMember = "PassagerId";
            PassagerIdCb.DataSource = dt;
            Con.Close();
        }

        private void FillVoyageCode()
        {
            //string AvionStatus = "Disponible";
            Con.Open();
            SqlCommand cmd = new SqlCommand("select VoyageCode from VOYAGETABLE", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("VoyageCode", typeof(int));
            dt.Load(rdr);
            VoyageCb.ValueMember = "VoyageCode";
            VoyageCb.DataSource = dt;
            Con.Close();
        }
        string pname;
        private void GetName()
        {
            Con.Open();
            string mysql = "select * from PASSAGERTABLE where PassagerId=" + PassagerIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(mysql, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                pname = dr["PassagerNom"].ToString();
            }
            Con.Close();
            MessageBox.Show(pname);
        }

        string Date, Src, Dest;
        int Cost;
        private void GetVoyage()
        {
            Con.Open();
            string mysql = "select * from VOYAGETABLE where VoyageCode=" + VoyageCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(mysql, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Date= dr["VoyageDate"].ToString();
                Src = dr["VoyageSource"].ToString();
                Dest = dr["VoyageDestination"].ToString();
                Cost = Convert.ToInt32(dr["VoyageCout"].ToString());
            }
            Con.Close();
            //MessageBox.Show(Date+Src+Dest+Cost);
        }

        private void VoyageCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetVoyage();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (NumeroPassportTb.Text == "" || VoyageCb.SelectedIndex == -1 || PassagerIdCb.SelectedIndex == -1 )
            {
                MessageBox.Show("Information manquante");
            }
            else
            {
                try
                {
                    Con.Open();
                    string Query = "insert into RESERVATIONTABLE  values(" + PassagerIdCb.SelectedValue.ToString() + ",'" +pname+ "','" +VoyageCb.SelectedValue.ToString()+ "','" +Date+ "','" +Src+ "','"+Dest+ "','" + Cost + "','" +NumeroPassportTb.Text+ "')";
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reservation accepté avec succès");
                    Con.Close();
                    populate();
                    //Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Reservation_Load(object sender, EventArgs e)
        {

        }

        private void PassagerIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetName();
        }
    }
}
