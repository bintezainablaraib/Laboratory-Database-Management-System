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
namespace InsertData
{
    public partial class Form1 : Form
    {
        String str = "server=DESKTOP-KQI1M52\\SQLEXPRESS;database=classBC;Integrated Security=true;";
        SqlConnection con = new SqlConnection(str);
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try

            {

                String str = "server=DESKTOP-KQI1M52\\SQLEXPRESS;database=classBC;Integrated Security=true;";

                String query = "select * from classPerformance";
                

                SqlConnection con = new SqlConnection(str);
               
                

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }

               

            }

            catch (Exception es)

            {

                MessageBox.Show(es.Message);



            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'classBCDataSet.ClassPerformance' table. You can move, or remove it, as needed.
            this.classPerformanceTableAdapter.Fill(this.classBCDataSet.ClassPerformance);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String str = "server=DESKTOP-KQI1M52\\SQLEXPRESS;database=classBC;Integrated Security=true;";
            String query = "insert into classperformance (regno, name) values ('" + this.textBox2.Text + "','" + this.textBox1.Text + "')";
            SqlDataReader dbr;
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                con.open();
                dbr = cmd.ExecuteReader();
                MessageBox.Show("saved");
                while (dbr.read())
                {
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        
    }
    }
}
