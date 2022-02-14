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

namespace Cst150Project
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void Back2Items_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ItemsPortal().Show();
            this.Hide();
        }

        //Method for populating grid with data from CategoryTbl
        private void populate()
        {
            Con.Open();
            string query = "select * from CategoryTbl";
            SqlDataAdapter CatSDA = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(CatSDA);
            var ds = new DataSet();
            CatSDA.Fill(ds);
            CatDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void CatsClear_lbl_Click(object sender, EventArgs e)
        {
            CatId_txt.Clear();
            CatName_txt.Clear();    
            CatDescrip_txt.Clear();
            CatId_txt.Focus();
        }

        private void ItemsExit_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ItemsPortalLogout_btn_Click(object sender, EventArgs e)
        {
            new LogInForm().Show();
            this.Hide();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kevre\OneDrive\Documents\GymAppDB.V1.mdf;Integrated Security=True;Connect Timeout=30");

        //Adding information and loading up to database
        private void AddCat_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "Insert into CategoryTbl values(" + CatId_txt.Text + ",'" +CatName_txt.Text+ "','"
                                                            + CatDescrip_txt.Text+ "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Succesfully");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        //allows data inputs to be reflected onto textboxes
        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CatId_txt.Text = CatDGV.SelectedRows[0].Cells[0].Value.ToString();
            CatName_txt.Text = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
            CatDescrip_txt.Text = CatDGV.SelectedRows[0].Cells[2].Value.ToString();
        }


        //deleting items from database
        private void RemoveCat_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if(CatId_txt.Text == "")
                {
                    MessageBox.Show("Select The Category to Delete");
                }
                else
                {
                    Con.Open();
                    string query = "delete from CategoryTbl where Id=" + CatId_txt.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Succesfully");
                    Con.Close();
                    populate();
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditCat_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatId_txt.Text == "" || CatName_txt.Text == "" || CatDescrip_txt.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "update CategoryTbl set Name='" + CatName_txt.Text + "',Description= '" + CatDescrip_txt.Text + "' where Id=" + CatId_txt.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Successfully Updated");
                    Con.Close();
                    populate();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}


