using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace StockOnline
{
    public partial class frmReg : Form
    {
        #region //Connect Database 
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PSConnection"].ToString());
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        #endregion
        DataSet ds = new DataSet();

        public frmReg()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "" || this.textBox2.Text == "" || this.textBox3.Text == "")
            {
                MessageBox.Show("โปรดกรอกข้อมูลให้ครบถ้วน");

                if(this.textBox1.Text == "")
                {
                    textBox1.Focus();
                }
                else if (this.textBox2.Text == "")
                {
                    textBox2.Focus();
                }
                else
                {
                    textBox3.Focus();
                }
            }

            else { 
            cmd = new SqlCommand("SELECT * FROM Employee WHERE Employee_ID= '"+this.textBox1.Text+"'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                MessageBox.Show("มีรหัสพนักงานคนนี้อยู่แล้ว");
                ds.Clear();
            }

            else {
            string lvSQL = "INSERT INTO Employee(Employee_ID, Employee_Name,Employee_LName)" + "VALUES" + "('" + this.textBox1.Text+ "', '"+this.textBox2.Text+"', '"+this.textBox3.Text+"')";
            string DR = GsysSQL.fncExecuteQueryData(lvSQL);

            if (DR == "Success")
            {
                MessageBox.Show("บันทึกเรียบร้อย");
                this.Close();
            }
            else
            {
                MessageBox.Show("ผิดพลาด");
            }
        }
    }
}

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr!=8)
            {
                e.Handled = true;
                MessageBox.Show("ระบุเป็นตัวเลขเท่านั้น");
            }
        }
    }
}
