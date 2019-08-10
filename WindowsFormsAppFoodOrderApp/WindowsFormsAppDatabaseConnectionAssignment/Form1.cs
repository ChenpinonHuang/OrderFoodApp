using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDatabaseConnectionAssignment
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\source\repos\WindowsFormsAppDatabaseConnectionAssignment\WindowsFormsAppDatabaseConnectionAssignment\Database1.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;

        public Form1()
        {
            InitializeComponent();
            dataGridView1.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(dataGridView1_RowHeaderMouseClick);
        }

        //Display Data
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from tbl_Student_Registration", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        //Clear Data  
        private void ClearData()
        {
            use_id.Text = "";
            first_name.Text = "";
            last_name.Text = "";
            contact_number.Text = "";
            phone.Text = "";
            password.Text = "";
            ID = 0;
        }

        //dataGridView1 RowHeaderMouseClick Event 
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            first_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            last_name.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            contact_number.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            phone.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            password.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            if (first_name.Text != "" && first_name.Text != "")
            {
                cmd = new SqlCommand("insert into tbl_Student_Registration(name, address, contact_number, subject_code, " +
                    "subject_name) values(@name, @address, @contact_number, @subject_code, @subject_name)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@name", first_name.Text);
                cmd.Parameters.AddWithValue("@address", last_name.Text);
                cmd.Parameters.AddWithValue("@contact_number", contact_number.Text);
                cmd.Parameters.AddWithValue("@subject_code", phone.Text);
                cmd.Parameters.AddWithValue("@subject_name", password.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Insert Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details");
            }
        }

        private void BtEdit_Click(object sender, EventArgs e)
        {
            if (first_name.Text != "" && first_name.Text != "")
            {
                cmd = new SqlCommand("update tbl_Student_Registration set name = @name, address = @address," +
                    "contact_number = @contact_number, subject_code = @subject_code," +
                    "subject_name = @subject_name where id = @id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@name", first_name.Text);
                cmd.Parameters.AddWithValue("@address", last_name.Text);
                cmd.Parameters.AddWithValue("@contact_number", contact_number.Text);
                cmd.Parameters.AddWithValue("@subject_code", phone.Text);
                cmd.Parameters.AddWithValue("@subject_name", password.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Insert Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details");
            }
        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete from tbl_Student_Registration where ID = @id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Delete Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record To Details");
            }
        }

        private void Check_connection_Click(object sender, EventArgs e)
        {
            con.Open();
            if (con != null && con.State == ConnectionState.Open)
                MessageBox.Show("Connection open!");
            else
                MessageBox.Show("Connection close!");
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
