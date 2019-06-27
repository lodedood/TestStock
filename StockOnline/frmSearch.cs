using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockOnline
{
    public partial class frmSearch : Form
    {
        public string pvMode = "";

        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Focus();
        }

        public void lvLoadItem()
        {
            try
            {
                string lvSQL = "Select * from SysITEM_Stock ";

                if (txtSearch.Text != "")
                {
                    lvSQL += "Where (Item_ID like '%" + txtSearch.Text + "%' Or Item_Name like '%" + txtSearch.Text + "%') ";
                }

                DataTable DT = new DataTable();
                DT = GsysSQL.fncGetQueryData(lvSQL, DT);

                int lvNumRow = DT.Rows.Count;
                sp1.ActiveSheet.RowCount = lvNumRow;

                for (int i = 0; i < lvNumRow; i++)
                {
                    string lvID = DT.Rows[i]["Item_ID"].ToString();
                    string lvName = DT.Rows[i]["Item_Name"].ToString();
                    sp1.ActiveSheet.Cells[i, 0].Text = lvID;
                    sp1.ActiveSheet.Cells[i, 1].Text = lvName;
                }

                DT.Dispose();
            }
            catch
            {
                MessageBox.Show("ไม่สามารถติดต่อ ฐานข้อมูลได้ กรุณาเปิดโปรแกรมใหม่อีกครั้ง","แจ้งเตือน",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Application.Restart();
            }
        }

        public void lvLoadUser()
        {
            try
            {
                string lvSQL = "Select * from Employee ";

                if (txtSearch.Text != "")
                {
                    lvSQL += "Where (Employee_ID like '%" + txtSearch.Text + "%' Or Employee_Name like '%" + txtSearch.Text + "%' Or Employee_LName like '%" + txtSearch.Text + "%') ";
                }

                DataTable DT = new DataTable();
                DT = GsysSQL.fncGetQueryData(lvSQL, DT);

                int lvNumRow = DT.Rows.Count;
                sp1.ActiveSheet.RowCount = lvNumRow;

                for (int i = 0; i < lvNumRow; i++)
                {
                    string lvID = DT.Rows[i]["Employee_ID"].ToString();
                    string lvName = DT.Rows[i]["Employee_Name"].ToString() + "  " + DT.Rows[i]["Employee_LName"].ToString();
                    sp1.ActiveSheet.Cells[i, 0].Text = lvID;
                    sp1.ActiveSheet.Cells[i, 1].Text = lvName;
                }

                DT.Dispose();
            }
            catch
            {
                MessageBox.Show("ไม่สามารถติดต่อ ฐานข้อมูลได้ กรุณาเปิดโปรแกรมใหม่อีกครั้ง","แจ้งเตือน",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Application.Restart();
            }
        }

        private void sp1_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            GVar.gvSCode = sp1.ActiveSheet.Cells[e.Row, 0].Text;
            GVar.gvSName = sp1.ActiveSheet.Cells[e.Row, 1].Text;
            this.Close();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            timerRefresh.Enabled = true;
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            if (pvMode == "Item")
                lvLoadItem();
            else if (pvMode == "User")
                lvLoadUser();

            timerRefresh.Enabled = false;
        }
    }
}
