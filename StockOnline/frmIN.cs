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
    public partial class frmIN : Form
    {
        public string pvMode = "";

        public frmIN()
        {
            InitializeComponent();
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            txtID.Focus();

            if (!GVar.gvBorrow)
                btnSearchItem.PerformClick();
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("กรุณาระบุรหัส", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Text = "";
                txtID.Focus();
                return;
            }
            else if (txtName.Text == "")
            {
                MessageBox.Show("กรุณาระบุชื่อ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Text = "";
                txtName.Focus();
                return;
            }
            else
            {
                string lvChk = GsysSQL.fncFindItemName(txtID.Text);
                if (lvChk == "")
                {
                    MessageBox.Show("ไม่พบข้อมูลรหัสนี้  กรุณาตรวจสอบ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Text = "";
                    txtName.Text = "";
                    txtID.Focus();
                    return;
                }

                tabControl1.SelectedIndex = 2;
                txtAmount.Text = "";
                txtAmount.Focus();
            }
        }

        private void btnPrv1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnPrv2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnNext3_Click(object sender, EventArgs e)
        {
            if (btnNext3.Text != "")
            {
                tabControl1.SelectedIndex = 3;
                txtUserResive.Text = "";
                txtUserResive.Focus();

                btnSearchUser.PerformClick();
            }
            else
            {
                MessageBox.Show("กรุณาระบุจำนวน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAmount.Text = "";
                txtAmount.Focus();
                return;
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            txtAmount.Text += "1";
            txtAmount.Focus();
            SendKeys.Send("{End}");
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            txtAmount.Text += "2";
            txtAmount.Focus();
            SendKeys.Send("{End}");
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            txtAmount.Text += "3";
            txtAmount.Focus();
            SendKeys.Send("{End}");
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            txtAmount.Text += "4";
            txtAmount.Focus();
            SendKeys.Send("{End}");
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            txtAmount.Text += "5";
            txtAmount.Focus();
            SendKeys.Send("{End}");
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            txtAmount.Text += "6";
            txtAmount.Focus();
            SendKeys.Send("{End}");
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            txtAmount.Text += "7";
            txtAmount.Focus();
            SendKeys.Send("{End}");
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            txtAmount.Text += "8";
            txtAmount.Focus();
            SendKeys.Send("{End}");
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            txtAmount.Text += "9";
            txtAmount.Focus();
            SendKeys.Send("{End}");
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            txtAmount.Text += "0";
            txtAmount.Focus();
            SendKeys.Send("{End}");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txtAmount.Focus();
            SendKeys.Send("{End}");
            SendKeys.Send("{BS}");
        }

        private void frmIN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBPSDataSet.SysITEM_Stock' table. You can move, or remove it, as needed.
            this.sysITEM_StockTableAdapter.Fill(this.dBPSDataSet.SysITEM_Stock);

            if (pvMode == "IN")
            {
                this.Text = "รับเข้า";
                groupBox4.Text = "รหัสผู้รับ";
            }
            else if (pvMode == "Borrow")
            {
                this.Text = "ยืมของ";
                groupBox4.Text = "ยืมของ";
            }
            else
            {
                this.Text = "จ่ายออก";
                groupBox4.Text = "รหัสผู้ขอเบิก";
            }
        }

        private void txtName_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            GVar.gvSCode = "";
            GVar.gvSName = "";

            frmSearch frm = new frmSearch();
            frm.pvMode = "Item";
            frm.groupBox1.Text = groupBox2.Text;
            frm.txtSearch.Text = txtID.Text;
            frm.lvLoadItem();
            frm.ShowDialog();

            if (GVar.gvSCode != "")
            {
                txtID.Text = GVar.gvSCode;
                txtName.Text = GVar.gvSName;
            }
        }

        private void btnPrv3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            GVar.gvSCode = "";
            GVar.gvSName = "";

            frmSearch frm = new frmSearch();
            frm.pvMode = "User";
            frm.groupBox1.Text = groupBox4.Text;
            frm.lvLoadUser();
            frm.ShowDialog();

            if (GVar.gvSCode != "")
            {
                txtUserResive.Text = GVar.gvSCode;
            }
        }

        private void btnNext4_Click(object sender, EventArgs e)
        {
            if (pvMode == "IN")
            {
                if (txtUserResive.Text != "")
                {
                    string lvChk = GsysSQL.fncFindEmpName(txtUserResive.Text);
                    if (lvChk == "")
                    {
                        MessageBox.Show("ไม่พบข้อมูลรหัสนี้  กรุณาตรวจสอบ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUserResive.Text = "";
                        txtUserResive.Focus();
                        return;
                    }


                    tabControl1.SelectedIndex = 4;
                    //txtRemark.Text = "";
                    txtRemark.Focus();
                }
                else
                {
                    MessageBox.Show("กรุณาระบุผู้รับ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserResive.Text = "";
                    txtUserResive.Focus();
                    return;
                }
            }
            else
            {
                if (txtUserResive.Text != "")
                {
                    string lvChk = GsysSQL.fncFindEmpName(txtUserResive.Text);
                    if (lvChk == "")
                    {
                        MessageBox.Show("ไม่พบข้อมูลรหัสนี้  กรุณาตรวจสอบ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUserResive.Text = "";
                        txtUserResive.Focus();
                        return;
                    }

                    tabControl1.SelectedIndex = 5;
                    txtUserPay.Text = "";
                    txtUserPay.Focus();

                    btnSearchUser1.PerformClick();
                }
                else
                {
                    MessageBox.Show("กรุณาระบุผู้รับ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserResive.Text = "";
                    txtUserResive.Focus();
                    return;
                }
            }
        }

        private void btnPrv4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string lvName = GsysSQL.fncFindItemName(txtID.Text);

                if (lvName != "")
                {
                    txtName.Text = lvName;
                    btnNext2.PerformClick();
                }
                else
                {
                    MessageBox.Show("ไม่พบข้อมูล กรุณาตรวจสอบ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Text = "";
                    txtName.Text = "";
                    txtID.Focus();
                    return;
                }
            }
        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnNext3.PerformClick();
            }
        }

        private void txtUserResive_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnNext4.PerformClick();
            }
        }

        private void txtRemark_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.PerformClick();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (pvMode == "IN")
            {
                #region รับเข้า
                //เช็คข้อมูล
                if (txtDate.EditValue == "")
                {
                    MessageBox.Show("กรุณาระบุ วันที่", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDate.Focus();
                    return;
                }
                else if (txtID.Text == "")
                {
                    MessageBox.Show("กรุณาระบุ รหัส", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Focus();
                    return;
                }
                else if (Gstr.fncToInt(txtAmount.Text) <= 0)
                {
                    MessageBox.Show("กรุณาระบุ จำนวน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAmount.Focus();
                    return;
                }
                else if (txtUserResive.Text == "")
                {
                    MessageBox.Show("กรุณาระบุ ผู้รับ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserResive.Focus();
                    return;
                }

                string lvType = "R";
                string lvDate = Gstr.fncChangeTDate(txtDate.EditValue.ToString());
                string lvItemID = Gstr.fncGetDataCode(txtID.Text, ";");
                string lvAmount = txtAmount.Text;
                string lvBal = GsysSQL.fncFindBal(lvItemID);
                string lvUserResive = txtUserResive.Text;
                string lvUserPay = "";
                string lvRemark = txtRemark.Text;

                string lvSQL = "";
                string lvResault = "";

                int lvTotalBal = Gstr.fncToInt(lvBal) + Gstr.fncToInt(lvAmount);
                if (lvTotalBal < 0) lvTotalBal = 0;
                
                //Update ยอด 
                lvSQL = "Update SysITEM_Stock set Item_Amount = '" + lvTotalBal + "' Where Item_ID = '" + lvItemID + "' ";
                lvResault = GsysSQL.fncExecuteQueryData(lvSQL);

                //Insert เคลื่อนไหว
                lvSQL = "Insert into Inv_Moving (M_Type, M_Date, M_ItemID, M_AmountR, M_AmountP, M_AmountBal, M_UserResive, M_UserPay, M_Remark) ";
                lvSQL += "values('" + lvType + "', '" + lvDate + "', '" + lvItemID + "', '" + lvAmount + "', '', '" + lvTotalBal + "', '" + lvUserResive + "', '" + lvUserPay + "', '" + lvRemark + "')";
                lvResault = GsysSQL.fncExecuteQueryData(lvSQL);

                if (lvResault == "Success")
                {
                    GVar.gvSave = true;
                    MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                #endregion
            }
            else if (pvMode == "Borrow")
            {
                #region ยืมของ
                //เช็คข้อมูล
                if (txtDate.EditValue == "")
                {
                    MessageBox.Show("กรุณาระบุ วันที่", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDate.Focus();
                    return;
                }
                else if (txtID.Text == "")
                {
                    MessageBox.Show("กรุณาระบุ รหัส", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Focus();
                    return;
                }
                else if (Gstr.fncToInt(txtAmount.Text) <= 0)
                {
                    MessageBox.Show("กรุณาระบุ จำนวน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAmount.Focus();
                    return;
                }
                else if (txtUserResive.Text == "")
                {
                    MessageBox.Show("กรุณาระบุ ผู้ขอเบิก", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserResive.Focus();
                    return;
                }
                else if (txtUserPay.Text == "")
                {
                    MessageBox.Show("กรุณาระบุ ผู้จ่าย", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserResive.Focus();
                    return;
                }

                string lvType = "B";
                string lvDate = Gstr.fncChangeTDate(txtDate.EditValue.ToString());
                string lvItemID = Gstr.fncGetDataCode(txtID.Text, ";");
                string lvAmount = txtAmount.Text;
                string lvBal = GsysSQL.fncFindBal(lvItemID);
                string lvUserResive = Gstr.fncGetDataCode(txtUserResive.Text, ";");
                string lvUserPay = Gstr.fncGetDataCode(txtUserPay.Text, ";");
                string lvRemark = txtRemark.Text;

                string lvSQL = "";
                string lvResault = "";

                int lvTotalBal = Gstr.fncToInt(lvBal) - Gstr.fncToInt(lvAmount);
                int lvMinStock = Gstr.fncToInt(GsysSQL.fncFindMinStock(lvItemID));

                string lvOption = "";
                if (ChkMouse.Checked) lvOption += "Mouse ";
                if (ChkMousePad.Checked) lvOption += "MousePad ";
                if (ChkAdapter.Checked) lvOption += "Adapter ";
                if (ChkPointer.Checked) lvOption += "Pointer ";
                if (ChkFlashDrive.Checked) lvOption += "FlashDrive ";

                lvOption = lvOption.Replace(' ', ',');

                ////ห้ามจ่ายติดลบ
                //if (lvTotalBal < 0)
                //{
                //    MessageBox.Show("จำนวนคงเหลือไม่เพียงพอ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    txtAmount.Focus();
                //    return;
                //}

                //if (lvTotalBal < 0) lvTotalBal = 0;

                ////Update ยอด
                //lvSQL = "Update SysITEM_Stock set Item_Amount = '" + lvTotalBal + "' Where Item_ID = '" + lvItemID + "' ";
                //lvResault = GsysSQL.fncExecuteQueryData(lvSQL);

                //Insert เคลื่อนไหว
                lvSQL = "Insert into Inv_Moving (M_Type, M_Date, M_ItemID, M_AmountR, M_AmountP, M_AmountBal, M_UserResive, M_UserPay, M_Remark, M_Option) ";
                lvSQL += "values('" + lvType + "', '" + lvDate + "', '" + lvItemID + "', '', '" + lvAmount + "', '" + lvTotalBal + "', '" + lvUserResive + "', '" + lvUserPay + "', '" + lvRemark + "', '"+ lvOption + "')";
                lvResault = GsysSQL.fncExecuteQueryData(lvSQL);

                if (lvResault == "Success")
                {
                    GVar.gvSave = true;
                    string lvUserName = GsysSQL.fncFindFullEmpName(lvUserResive);
                    string lvItemName = GsysSQL.fncFindItemName(lvItemID);
                    string lvItemUnit = GsysSQL.fncFindItemUnit(lvItemID);
                    if (lvItemName == "อื่นๆ")
                        lvItemName = lvRemark;
                    string lvMessage = "แจ้งเตือน " + lvUserName + " ได้ยืม  "+ lvItemName + "  จำนวน " + lvAmount + " " + lvItemUnit + " " + lvRemark;
                    lineNotify(lvMessage);

                    MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                #endregion
            }
            else
            {
                #region เบิกจ่าย
                //เช็คข้อมูล
                if (txtDate.EditValue == "")
                {
                    MessageBox.Show("กรุณาระบุ วันที่", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDate.Focus();
                    return;
                }
                else if (txtID.Text == "")
                {
                    MessageBox.Show("กรุณาระบุ รหัส", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Focus();
                    return;
                }
                else if (Gstr.fncToInt(txtAmount.Text) <= 0)
                {
                    MessageBox.Show("กรุณาระบุ จำนวน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAmount.Focus();
                    return;
                }
                else if (txtUserResive.Text == "")
                {
                    MessageBox.Show("กรุณาระบุ ผู้ขอเบิก", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserResive.Focus();
                    return;
                }
                else if (txtUserPay.Text == "")
                {
                    MessageBox.Show("กรุณาระบุ ผู้จ่าย", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserResive.Focus();
                    return;
                }

                string lvType = "P";
                string lvDate = Gstr.fncChangeTDate(txtDate.EditValue.ToString());
                string lvItemID = Gstr.fncGetDataCode(txtID.Text, ";");
                string lvAmount = txtAmount.Text;
                string lvBal = GsysSQL.fncFindBal(lvItemID);
                string lvUserResive = Gstr.fncGetDataCode(txtUserResive.Text, ";");
                string lvUserPay = Gstr.fncGetDataCode(txtUserPay.Text, ";");
                string lvRemark = txtRemark.Text;

                string lvSQL = "";
                string lvResault = "";

                int lvTotalBal = Gstr.fncToInt(lvBal) - Gstr.fncToInt(lvAmount);
                int lvMinStock = Gstr.fncToInt(GsysSQL.fncFindMinStock(lvItemID));

                //ห้ามจ่ายติดลบ
                if (lvTotalBal < 0)
                {
                    MessageBox.Show("จำนวนคงเหลือไม่เพียงพอ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAmount.Focus();
                    return;
                }

                if (lvTotalBal < 0) lvTotalBal = 0;

                //Update ยอด
                lvSQL = "Update SysITEM_Stock set Item_Amount = '" + lvTotalBal + "' Where Item_ID = '" + lvItemID + "' ";
                lvResault = GsysSQL.fncExecuteQueryData(lvSQL);

                //Insert เคลื่อนไหว
                lvSQL = "Insert into Inv_Moving (M_Type, M_Date, M_ItemID, M_AmountR, M_AmountP, M_AmountBal, M_UserResive, M_UserPay, M_Remark) ";
                lvSQL += "values('" + lvType + "', '" + lvDate + "', '" + lvItemID + "', '', '" + lvAmount + "', '" + lvTotalBal + "', '" + lvUserResive + "', '" + lvUserPay + "', '" + lvRemark + "')";
                lvResault = GsysSQL.fncExecuteQueryData(lvSQL);

                if (lvResault == "Success")
                {
                    if (lvTotalBal <= lvMinStock && lvMinStock != 0)
                    {
                        string lvMessage = "แจ้งเตือน " + txtName.Text + " ใกล้หมดแล้ว ยอดคงเหลือปัจุบัน คือ " + lvTotalBal;
                        lineNotify(lvMessage);
                    }
                    else
                    {
                        string lvEmpName = GsysSQL.fncFindFullEmpName(lvUserResive);
                        string lvItemName = GsysSQL.fncFindItemName(lvItemID);
                        string lvItemUnit = GsysSQL.fncFindItemUnit(lvItemID);

                        string lvMessage = "แจ้งเตือน " + lvEmpName + " ได้เบิก " + lvItemName + " จำนวน " + lvAmount + " " + lvItemUnit;
                        lineNotify(lvMessage);
                    }

                    MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                #endregion
            }
        }

        private void btnSearchUser1_Click(object sender, EventArgs e)
        {
            GVar.gvSCode = "";
            GVar.gvSName = "";

            frmSearch frm = new frmSearch();
            frm.pvMode = "User";
            frm.groupBox1.Text = groupBox7.Text;
            frm.lvLoadUser();
            frm.ShowDialog();

            if (GVar.gvSCode != "")
            {
                txtUserPay.Text = GVar.gvSCode;
            }
        }
        
        private void btnPrv5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void btnNext5_Click(object sender, EventArgs e)
        {
            if (txtUserPay.Text != "")
            {
                string lvChk = GsysSQL.fncFindEmpName(txtUserPay.Text);
                if (lvChk == "")
                {
                    MessageBox.Show("ไม่พบข้อมูลรหัสนี้  กรุณาตรวจสอบ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserPay.Text = "";
                    txtUserPay.Focus();
                    return;
                }

                if (txtID.Text == "00021" || txtID.Text == "00022" || txtID.Text == "00023")
                    tabControl1.SelectedIndex = 7;
                else
                    tabControl1.SelectedIndex = 4;

                //txtRemark.Text = "";
                txtRemark.Focus();
            }
            else
            {
                MessageBox.Show("กรุณาระบุผู้จ่าย", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserPay.Text = "";
                txtUserPay.Focus();
                return;
            }
        }
        
        private void lineNotify(string msg)
        {
            string token = "Wuh3ocetjly3TUZgd9OV0YY3o9g6GouD3wPaIsthAna"; //แผนกคอม
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

                if (GVar.gvAlertLine)
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

        private void btnNext6_Click(object sender, EventArgs e)
        {
            string lvUnit = GsysSQL.fncFindItemUnit(txtID.Text);
            lbDate.Text = txtDate.DateTime.ToString("dd/MM/yyyy");
            lbItem.Text = GsysSQL.fncFindItemName(txtID.Text);
            lbAmount.Text = txtAmount.Text + " " + lvUnit;
            lbUserResive.Text = GsysSQL.fncFindFullEmpName(txtUserResive.Text);
            if (pvMode != "IN")
            {
                lbUserPay.Text = GsysSQL.fncFindFullEmpName(txtUserPay.Text);
            }
            else
            {
                lbUserPay.Text = " - ";
            }

            if(txtID.Text == "00021" || txtID.Text == "00022" || txtID.Text == "00023")
                tabControl1.SelectedIndex = 7;
            else
                tabControl1.SelectedIndex = 6;
        }

        private void btnPrv6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void btnPrv7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void btnNext7_Click(object sender, EventArgs e)
        {
            string lvUnit = GsysSQL.fncFindItemUnit(txtID.Text);
            lbDate.Text = txtDate.DateTime.ToString("dd/MM/yyyy");
            lbItem.Text = GsysSQL.fncFindItemName(txtID.Text);
            lbAmount.Text = txtAmount.Text + " " + lvUnit;
            lbUserResive.Text = GsysSQL.fncFindFullEmpName(txtUserResive.Text);
            if (pvMode != "IN")
            {
                lbUserPay.Text = GsysSQL.fncFindFullEmpName(txtUserPay.Text);
            }
            else
            {
                lbUserPay.Text = " - ";
            }

            tabControl1.SelectedIndex = 6;
        }
    }
}
