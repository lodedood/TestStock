using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockOnline
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            GVar.gvBorrow = false;

            frmIN frm = new frmIN();
            frm.pvMode = "IN";
            frm.ShowDialog();

            lvLoadItem(true);
            lvLoadItemBorrow(false);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            GVar.gvAlertLine = true;
            lvLoadItem(true);
            lvLoadItemBorrow(false);
        }

        public void lvLoadItem(bool lvShow)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                btnreg.Enabled = false;
                btnIn.Enabled = false;
                btnOut.Enabled = false;
                btnBorrow.Enabled = false;
                btnNoteBook.Enabled = false;

                string lvSQL = "Select Top 50 * from Inv_Moving Where M_Type in ('R','P') Order by M_Pk Desc ";

                DataTable DT = new DataTable();
                DT = GsysSQL.fncGetQueryData(lvSQL, DT);

                int lvNumRow = DT.Rows.Count;
                sp1.ActiveSheet.RowCount = lvNumRow;

                progressBar1.Maximum = lvNumRow;
                progressBar1.Value = 0;
                pnStatus.Visible = true;

                for (int i = 0; i < lvNumRow; i++)
                {
                    sp1.ActiveSheet.Cells[i, 0].Text = Gstr.fncChangeSDate(DT.Rows[i]["M_Date"].ToString());
                    sp1.ActiveSheet.Cells[i, 1].Text = DT.Rows[i]["M_ItemID"].ToString();
                    sp1.ActiveSheet.Cells[i, 2].Text = GsysSQL.fncFindItemName(DT.Rows[i]["M_ItemID"].ToString());
                    sp1.ActiveSheet.Cells[i, 3].Text = DT.Rows[i]["M_AmountR"].ToString();
                    sp1.ActiveSheet.Cells[i, 4].Text = DT.Rows[i]["M_AmountP"].ToString();
                    sp1.ActiveSheet.Cells[i, 5].Text = DT.Rows[i]["M_AmountBal"].ToString();
                    sp1.ActiveSheet.Cells[i, 6].Text = GsysSQL.fncFindEmpName(DT.Rows[i]["M_UserResive"].ToString());
                    sp1.ActiveSheet.Cells[i, 7].Text = GsysSQL.fncFindEmpName(DT.Rows[i]["M_UserPay"].ToString());
                    sp1.ActiveSheet.Cells[i, 8].Text = GsysSQL.fncFindEmpName(DT.Rows[i]["M_Remark"].ToString());

                    progressBar1.Value += 1;
                    Application.DoEvents();
                }

                pnStatus.Visible = false;
                DT.Dispose();

                btnreg.Enabled = true;
                btnIn.Enabled = true;
                btnOut.Enabled = true;
                btnBorrow.Enabled = true;
                btnNoteBook.Enabled = true;

                if (lvShow) tabControl1.SelectedIndex = 0;

                this.Cursor = Cursors.Default;
            }
            catch
            {
                Application.Restart();
            }

        }

        public void lvLoadItemBorrow(bool lvShow)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                btnIn.Enabled = false;
                btnOut.Enabled = false;
                btnBorrow.Enabled = false;
                btnNoteBook.Enabled = false;

                string lvSQL = "Select Top 50 * from Inv_Moving Where M_Type = 'B' Order by M_Pk Desc ";

                DataTable DT = new DataTable();
                DT = GsysSQL.fncGetQueryData(lvSQL, DT);

                int lvNumRow = DT.Rows.Count;
                sp2.ActiveSheet.RowCount = lvNumRow;

                progressBar1.Maximum = lvNumRow;
                progressBar1.Value = 0;
                pnStatus.Visible = true;

                for (int i = 0; i < lvNumRow; i++)
                {
                    sp2.ActiveSheet.Cells[i, 0].Text = Gstr.fncChangeSDate(DT.Rows[i]["M_Date"].ToString());
                    sp2.ActiveSheet.Cells[i, 1].Text = DT.Rows[i]["M_ItemID"].ToString();

                    if (DT.Rows[i]["M_ItemID"].ToString() == "9999")
                    {
                        sp2.ActiveSheet.Cells[i, 2].Text = DT.Rows[i]["M_Remark"].ToString();
                    }
                    else
                    {
                        sp2.ActiveSheet.Cells[i, 2].Text = GsysSQL.fncFindItemName(DT.Rows[i]["M_ItemID"].ToString());
                    }

                    sp2.ActiveSheet.Cells[i, 3].Text = DT.Rows[i]["M_AmountP"].ToString();
                    sp2.ActiveSheet.Cells[i, 4].Text = GsysSQL.fncFindEmpName(DT.Rows[i]["M_UserResive"].ToString());
                    sp2.ActiveSheet.Cells[i, 5].Text = GsysSQL.fncFindEmpName(DT.Rows[i]["M_UserPay"].ToString());
                    sp2.ActiveSheet.Cells[i, 6].Text = DT.Rows[i]["M_Remark"].ToString();
                    sp2.ActiveSheet.Cells[i, 7].Text = DT.Rows[i]["M_Option"].ToString();
                    sp2.ActiveSheet.Cells[i, 9].Text = DT.Rows[i]["M_PK"].ToString();

                    progressBar1.Value += 1;
                    Application.DoEvents();
                }

                pnStatus.Visible = false;
                DT.Dispose();

                btnIn.Enabled = true;
                btnOut.Enabled = true;
                btnBorrow.Enabled = true;
                btnNoteBook.Enabled = true;

                if (lvShow) tabControl1.SelectedIndex = 1;

                this.Cursor = Cursors.Default;
            }
            catch
            {
                Application.Restart();
            }
}

        private void btnOut_Click(object sender, EventArgs e)
        {
            GVar.gvBorrow = false;

            frmIN frm = new frmIN();
            frm.pvMode = "OUT";
            frm.ShowDialog();

            lvLoadItem(true);
            lvLoadItemBorrow(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string lvTXT = "แจ้งเตือน เงินในบัญชีของท่านใกล้หมด  กรุณาออกไปทำมากินด้วย";
            //lineNotify(lvTXT);
        }

        private void lineNotify(string msg)
        {
            string token = "Wuh3ocetjly3TUZgd9OV0YY3o9g6GouD3wPaIsthAna";
            //string token = "udbt8VL6gdsiycFhNA5tCZgBfI2u6JnlUFBJOoG28Bg"; //ส่วนตัว
            try
            {
                var request = (HttpWebRequest)WebRequest.Create("https://notify-api.line.me/api/notify");
                var postData = string.Format("message={0}", msg);
                var data = Encoding.UTF8.GetBytes(postData);

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;
                request.Headers.Add("Authorization", "Bearer " + token);

                if (ChkAlertLine.Checked)
                {
                    using (var stream = request.GetRequestStream()) stream.Write(data, 0, data.Length);
                    var response = (HttpWebResponse)request.GetResponse();
                    var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            GVar.gvBorrow = false;

            frmIN frm = new frmIN();
            frm.pvMode = "Borrow";
            frm.ShowDialog();

            lvLoadItem(false);
            lvLoadItemBorrow(true);
        }

        private void sp2_ButtonClicked(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
        {
            string lvItemID = sp2.ActiveSheet.Cells[e.Row, 1].Text;
            if (lvItemID == "00021" || lvItemID == "00022" || lvItemID == "00023")
            {
                tabControl1.SelectedIndex = 2;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("ยืนยันการทำรายการ", "แจ้งเตือน", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string lvPk = sp2.ActiveSheet.Cells[e.Row, 9].Text;
                    //Update ยอด
                    string lvSQL = "Update Inv_Moving set M_Type = 'T' Where M_Pk = '" + lvPk + "' ";
                    string lvResault = GsysSQL.fncExecuteQueryData(lvSQL);

                    string lvItemName = sp2.ActiveSheet.Cells[e.Row, 2].Text;
                    string lvUserName = sp2.ActiveSheet.Cells[e.Row, 4].Text;

                    MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lvLoadItemBorrow(true);

                    string lvMsg = lvUserName + "  ได้นำ  " + lvItemName + "  มาคืนเรียบร้อยแล้ว ";
                    lineNotify(lvMsg);
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void FncListViewDrag(object sender, ItemDragEventArgs e, ListView lv)
        {
            // create array or collection for all selected items
            var items = new List<ListViewItem>();
            // add dragged one first
            items.Add((ListViewItem)e.Item);
            // optionally add the other selected ones
            foreach (ListViewItem lvi in lv.SelectedItems)
            {
                if (!items.Contains(lvi))
                {
                    items.Add(lvi);
                }
            }
            // pass the items to move...
            lv.DoDragDrop(items, DragDropEffects.Move);
        }

        private void FncListViewDragDrop(object sender, DragEventArgs e, ListView lv, string lvAddress)
        {
            //คืนของ
            string lvItemCode = "";
            if (lvAddress == "")
            {
                //หาสิ่งที่เลือก
                string lvItemSelect = "";
                if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
                {
                    var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                    // move to dest LV
                    foreach (ListViewItem lvi in items)
                    {
                        lvItemSelect = lvi.Text;
                    }
                }

                //ถ้าเป็นช่องเดิมไม่มีการย้ายให้ Return
                bool lvChk = false;
                foreach (ListViewItem item in lv.Items)
                {
                    if (item.Text == lvItemSelect)
                    {
                        lvChk = true;
                        break;
                    }
                }

                if (lvChk) return;

                //ยืนยัน
                string lvTxtAlert = "ตรวจสอบอุปกรณ์ ว่าครบหรือไม่ ";
                //if (GVar.gvDateBill != Gstr.fncChangeTDate(txtDate.Text)) lvTxtAlert = "  **วันที่ไม่ตรงกับใบเสร็จ**"+ Environment.NewLine + Environment.NewLine + "ยืนยันการทำรายการต่อหรือไม่?";
                DialogResult dialogResult = MessageBox.Show(lvTxtAlert, "ยืนยันการคืน NoteBook ?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                else
                {
                    string lvMsg = "";
                    if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
                    {
                        var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                        // move to dest LV
                        foreach (ListViewItem lvi in items)
                        {
                            if (lvi.Text == "Dell")
                            {
                                lvMsg = "แจ้งเตือน NoteBook Dell ได้ถูกนำมาคืนแล้ว";
                                lvItemCode = "00021";
                            }
                            else if (lvi.Text == "ASUS")
                            {
                                lvMsg = "แจ้งเตือน NoteBook ASUS ได้ถูกนำมาคืนแล้ว";
                                lvItemCode = "00022";
                            }
                            else if (lvi.Text == "ThinkPad")
                            {
                                lvMsg = "แจ้งเตือน NoteBook ThinkPad ได้ถูกนำมาคืนแล้ว";
                                lvItemCode = "00023";
                            }
                            else if (lvi.Text == "Lenovo")
                            {
                                lvMsg = "แจ้งเตือน NoteBook Lenovo ได้ถูกนำมาคืนแล้ว";
                                lvItemCode = "00024";
                            }
                        }
                    }

                    //Update ยอด
                    string lvSQL = "Update Inv_Moving set M_Type = 'T' Where M_ItemID = '" + lvItemCode + "' ";
                    string lvResault = GsysSQL.fncExecuteQueryData(lvSQL);

                    lineNotify(lvMsg);
                }
            }

            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                // move to dest LV
                foreach (ListViewItem lvi in items)
                {
                    if (lvAddress != "")
                    {
                        GVar.gvSave = false;
                        GVar.gvBorrow = true;
                        frmIN frm = new frmIN();
                        frm.pvMode = "Borrow";
                        lvItemCode = "";

                        if (lvi.Text == "Dell")
                            lvItemCode = "00021";
                        else if (lvi.Text == "ASUS")
                            lvItemCode = "00022";
                        else if (lvi.Text == "ThinkPad")
                            lvItemCode = "00023";
                        else if (lvi.Text == "Lenovo")
                            lvItemCode = "00024";

                        frm.txtID.Text = lvItemCode;
                        frm.txtName.Text = GsysSQL.fncFindItemName(lvItemCode);
                        frm.txtRemark.Text = "ใช้งาน สำหรับ " + lvAddress;
                        frm.ShowDialog();
                    }

                    if (GVar.gvSave)
                    {
                        // LVI obj can only belong to one LVI, remove
                        lvi.ListView.Items.Remove(lvi);
                        lv.Items.Add(lvi);
                    }
                }
            }

            lvLoadItemBorrow(true);
        }

        private void lv_ItemDrag(object sender, ItemDragEventArgs e)
        {
            FncListViewDrag(sender, e, ListItem);
        }

        private void ListRoom1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            FncListViewDrag(sender, e, ListRoom1);
        }

        private void ListRoom2_ItemDrag(object sender, ItemDragEventArgs e)
        {
            FncListViewDrag(sender, e, ListRoom2);
        }

        private void ListRoom3_ItemDrag(object sender, ItemDragEventArgs e)
        {
            FncListViewDrag(sender, e, ListRoom3);
        }

        private void ListRoom4_ItemDrag(object sender, ItemDragEventArgs e)
        {
            FncListViewDrag(sender, e, ListRoom4);
        }

        private void ListRoom5_ItemDrag(object sender, ItemDragEventArgs e)
        {
            FncListViewDrag(sender, e, ListRoom5);
        }

        private void ListRoom6_ItemDrag(object sender, ItemDragEventArgs e)
        {
            FncListViewDrag(sender, e, ListRoom6);
        }

        private void ListItem_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void ListRoom1_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void ListRoom2_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void ListRoom3_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void ListRoom4_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void ListRoom5_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void ListRoom6_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void ListItem_DragDrop(object sender, DragEventArgs e)
        {
            FncListViewDragDrop(sender, e, ListItem, "");
        }

        private void ListRoom1_DragDrop(object sender, DragEventArgs e)
        {
            FncListViewDragDrop(sender, e, ListRoom1, "ห้องประชุมใหญ่");
        }

        private void ListRoom2_DragDrop(object sender, DragEventArgs e)
        {
            FncListViewDragDrop(sender, e, ListRoom2, "ห้องประชุมวิศวะ");
        }

        private void ListRoom3_DragDrop(object sender, DragEventArgs e)
        {
            FncListViewDragDrop(sender, e, ListRoom3, "ห้องรับแขก (บนออฟฟิต)");
        }

        private void ListRoom4_DragDrop(object sender, DragEventArgs e)
        {
            FncListViewDragDrop(sender, e, ListRoom4, "ห้องประชุมผู้บริหาร");
        }

        private void ListRoom5_DragDrop(object sender, DragEventArgs e)
        {
            FncListViewDragDrop(sender, e, ListRoom5, "ห้องประชุมฝ่ายไร่");
        }

        private void ListRoom6_DragDrop(object sender, DragEventArgs e)
        {
            FncListViewDragDrop(sender, e, ListRoom6, "ห้องประชุมบุคคล");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;

            GVar.gvBorrow = true;
        }

        private void timerAlert_Tick(object sender, EventArgs e)
        {
            string lvTime = DateTime.Now.ToString("HHmmss");
            string lvMsg = "แจ้งเตือน ";
            if (lvTime == "190000")
            {
                bool lvChkDell = fncChkNoteBookOnList("Dell");
                bool lvChkASUS = fncChkNoteBookOnList("ASUS");
                bool lvChkThinkPad = fncChkNoteBookOnList("ThinkPad");
                bool lvChkLenovo = fncChkNoteBookOnList("Lenovo");

                if (!lvChkDell)
                {
                    lvMsg += "NoteBook Dell";
                }

                if (lvMsg != "แจ้งเตือน ") lvMsg += ",";

                if (!lvChkASUS)
                {
                    lvMsg += "NoteBook ASUS";
                }

                if (lvMsg != "แจ้งเตือน ") lvMsg += ",";

                if (!lvChkThinkPad)
                {
                    lvMsg += "NoteBook ThinkPad";
                }

                if (lvMsg != "แจ้งเตือน ") lvMsg += ",";

                if (!lvChkLenovo)
                {
                    lvMsg += "NoteBook Lenovo";
                }

                lvMsg += " ยังไม่ถูกนำมาคืน ไปหามาคืนด้วย";

                if (!lvChkDell || !lvChkASUS || !lvChkThinkPad || !lvChkLenovo)
                    lineNotify(lvMsg);
            }
            if (lvTime == "200000")
            {
                bool lvChkDell = fncChkNoteBookOnList("Dell");
                bool lvChkASUS = fncChkNoteBookOnList("ASUS");
                bool lvChkThinkPad = fncChkNoteBookOnList("ThinkPad");
                bool lvChkLenovo = fncChkNoteBookOnList("Lenovo");

                if (!lvChkDell)
                {
                    lvMsg += "NoteBook Dell";
                }

                if (lvMsg != "แจ้งเตือน ") lvMsg += ",";

                if (!lvChkASUS)
                {
                    lvMsg += "NoteBook ASUS";
                }

                if (lvMsg != "แจ้งเตือน ") lvMsg += ",";

                if (!lvChkThinkPad)
                {
                    lvMsg += "NoteBook ThinkPad";
                }

                if (lvMsg != "แจ้งเตือน ") lvMsg += ",";

                if (!lvChkLenovo)
                {
                    lvMsg += "NoteBook Lenovo";
                }

                lvMsg += " ยังไม่ถูกนำมาคืน ไปหามาคืนด้วย";

                if (!lvChkDell || !lvChkASUS || !lvChkThinkPad || !lvChkLenovo)
                    lineNotify(lvMsg);
            }
        }

        private bool fncChkNoteBookOnList(string lvName)
        {
            bool lvReturn = false;

            for (int i = 0; i < ListItem.Items.Count; i++)
            {
                if (ListItem.Items[i].Text == lvName)
                {
                    lvReturn = true;
                    break;
                }
            }

            //foreach (var item in ListItem.Items)
            //{
            //    if (item.ToString() == lvName) lvReturn = true;
            //}

            return lvReturn;
        }

        private void ChkAlertLine_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkAlertLine.Checked)
                GVar.gvAlertLine = true;
            else
                GVar.gvAlertLine = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadAssetData(true);
        }

        public void LoadAssetData(bool lvShow)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                btnIn.Enabled = false;
                btnOut.Enabled = false;
                btnBorrow.Enabled = false;
                btnNoteBook.Enabled = false;

                string lvSQL = "Select * from Asset Where Asset_ID2 >= '"+ txtSearchS.Text + "' And Asset_ID2 <= '"+ txtSearchE.Text +"' ";

                DataTable DT = new DataTable();
                DT = GsysSQL.fncGetQueryData(lvSQL, DT);

                int lvNumRow = DT.Rows.Count;
                sp3.ActiveSheet.RowCount = lvNumRow;

                progressBar1.Maximum = lvNumRow;
                progressBar1.Value = 0;
                pnStatus.Visible = true;

                for (int i = 0; i < lvNumRow; i++)
                {
                    sp3.ActiveSheet.Cells[i, 0].Text = DT.Rows[i]["Asset_ID2"].ToString();
                    sp3.ActiveSheet.Cells[i, 1].Text = DT.Rows[i]["Asset_Faction"].ToString();
                    sp3.ActiveSheet.Cells[i, 2].Text = Gstr.fncChangeSDate(DT.Rows[i]["Asset_ResiveDate"].ToString());
                    sp3.ActiveSheet.Cells[i, 3].Text = DT.Rows[i]["Asset_Name"].ToString();

                    progressBar1.Value += 1;
                    Application.DoEvents();
                }

                pnStatus.Visible = false;
                DT.Dispose();

                btnIn.Enabled = true;
                btnOut.Enabled = true;
                btnBorrow.Enabled = true;
                btnNoteBook.Enabled = true;

                if (lvShow) tabControl1.SelectedIndex = 3;

                this.Cursor = Cursors.Default;
            }
            catch
            {
                Application.Restart();
            }

        }

        private void btnPrintQR_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            //ลบข้อมูล เก่า
            string lvSQL = "Delete From SysTemp "; //HD
            string lvResault = GsysSQL.fncExecuteQueryDataAccess(lvSQL);

            for (int i = 0; i < sp3.ActiveSheet.RowCount; i++)
            {
                string lvField1 = sp3.ActiveSheet.Cells[i,0].Text;
                string lvField2 = sp3.ActiveSheet.Cells[i, 1].Text;
                string lvField3 = sp3.ActiveSheet.Cells[i, 2].Text;

                lvSQL = "Insert into SysTemp (Field1, Field2, Field3) ";//
                lvSQL += "Values ('" + lvField1 + "', '" + lvField2 + "', '" + lvField3 + "')";
                lvResault = GsysSQL.fncExecuteQueryDataAccess(lvSQL);
            }
            
            frmPrint frm = new frmPrint();
            this.Cursor = Cursors.Default;
            frm.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearchS.Text = "";
            txtSearchE.Text = "";
            sp3.ActiveSheet.RowCount = 0;
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            frmReg freg = new frmReg();
            freg.ShowDialog();
        }
    }
}
