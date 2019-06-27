﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace StockOnline
{
    public class GsysSQL
    {
        //Execute Data
        public static DataTable fncGetQueryData(string lvSQL,DataTable dt)
        {
            string query = lvSQL;
            DataTable DTReturn = new DataTable();
            SqlDataAdapter DA = new SqlDataAdapter(query, System.Configuration.ConfigurationManager.ConnectionStrings["PSConnection"].ToString());
            DA.Fill(DTReturn);

            return DTReturn;
        }

        public static string fncExecuteQueryData(string lvSQL)
        {
            string lvReturn = "";
            try
            {
                string query = lvSQL;
                SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PSConnection"].ToString());
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                con.Close();
                con.Dispose();

                lvReturn = "Success";
                return lvReturn;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public static string fncExecuteQueryDataAccess(string lvSQL)
        {
            string lvReturn = "";
            try
            {
                string query = lvSQL;
                OleDbConnection MyConn = new OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PSAccess"].ToString());
                MyConn.Open();
                OleDbCommand Cmd = new OleDbCommand(lvSQL, MyConn);
                Cmd.ExecuteNonQuery();

                lvReturn = "Success";
                MyConn.Close();
                Cmd.Dispose();

                return lvReturn;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Function Check
        public static string fncCheckLogin(string lvUser,string lvPass)
        {
            #region //Connect Database 
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PSConnection"].ToString());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            #endregion  

            string lvReturn = "";

            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT * FROM SysUser WHERE us_UserID = '"+ lvUser + "' AND us_Password = '"+ lvPass + "' And us_Active = '1' ";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lvReturn = dr["us_UserID"].ToString();
                    GVar.gvFirstUrl = dr["us_URL"].ToString();
                    GVar.gvKet = dr["us_Ket"].ToString();
                    GVar.gvUserType = dr["us_Type"].ToString();
                }
            }
            dr.Close();
            con.Close();

            return lvReturn;
        }

        public static string fncCheckEmpType(string lvSearch)
        {
            #region //Connect Database 
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PSConnection"].ToString());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            #endregion  

            string lvReturn = "";

            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT EmpType_ID FROM Emp_Type WHERE EmpType_ID = '" + lvSearch + "' ";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lvReturn = dr["EmpType_ID"].ToString();
                }
            }
            dr.Close();
            con.Close();

            return lvReturn;
        }

        public static string fncCheckEmpPrefix(string lvSearch)
        {
            #region //Connect Database 
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PSConnection"].ToString());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            #endregion  

            string lvReturn = "";

            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT PrefixID FROM Emp_Prefix WHERE PrefixID = '" + lvSearch + "' ";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lvReturn = dr["PrefixID"].ToString();
                }
            }
            dr.Close();
            con.Close();

            return lvReturn;
        }

        public static string fncCheckEmpFaction(string lvSearch)
        {
            #region //Connect Database 
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PSConnection"].ToString());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            #endregion  

            string lvReturn = "";

            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT Faction_ID FROM Emp_Faction WHERE Faction_ID = '" + lvSearch + "' ";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lvReturn = dr["Faction_ID"].ToString();
                }
            }
            dr.Close();
            con.Close();

            return lvReturn;
        }

        public static string fncCheckEmpSection(string lvSearch)
        {
            #region //Connect Database 
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PSConnection"].ToString());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            #endregion  

            string lvReturn = "";

            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT Section_ID FROM Emp_Section WHERE Section_ID = '" + lvSearch + "' ";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lvReturn = dr["Section_ID"].ToString();
                }
            }
            dr.Close();
            con.Close();

            return lvReturn;
        }

        public static string fncCheckEmpPosition(string lvSearch)
        {
            #region //Connect Database 
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PSConnection"].ToString());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            #endregion  

            string lvReturn = "";

            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT Position_ID FROM Emp_Position WHERE Position_ID = '" + lvSearch + "' ";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lvReturn = dr["Position_ID"].ToString();
                }
            }
            dr.Close();
            con.Close();

            return lvReturn;
        }

        public static string fncCheckDocNo(string lvDocS,string lvDocNo)
        {
            #region //Connect Database 
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PSConnection"].ToString());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            #endregion  

            string lvReturn = "";

            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT M_DocNo FROM MiniCane_BillHD WHERE M_DocNo = '" + lvDocNo +"' ";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lvReturn = dr["M_DocNo"].ToString();
                }
            }
            dr.Close();
            con.Close();

            return lvReturn;
        }

        //Function Find
        public static string fncFindFactionName(string lvID)
        {
            #region //Connect Database 
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PSConnection"].ToString());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            #endregion  

            string lvReturn = "";

            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT Faction_Name FROM Emp_Faction WHERE Faction_ID = '" + lvID + "' ";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lvReturn = dr["Faction_Name"].ToString();
                }
            }
            else
            {
                lvReturn = lvID;
            }

            dr.Close();
            con.Close();

            return lvReturn;
        }

        public static string fncFindSectionName(string lvID)
        {
            #region //Connect Database 
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PSConnection"].ToString());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            #endregion  

            string lvReturn = "";

            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT Section_Name FROM Emp_Section WHERE Section_ID = '" + lvID + "' ";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lvReturn = dr["Section_Name"].ToString();
                }
            }
            else
            {
                lvReturn = lvID;
            }

            dr.Close();
            con.Close();

            return lvReturn;
        }

        public static string fncFindSectionID(string lvName)
        {
            #region //Connect Database 
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PSConnection"].ToString());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            #endregion  

            string lvReturn = "";

            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT Section_ID FROM Emp_Section WHERE Section_Name = '" + lvName + "' ";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lvReturn = dr["Section_ID"].ToString();
                }
            }
            else
            {
                lvReturn = lvName;
            }

            dr.Close();
            con.Close();

            return lvReturn;
        }

        public static string fncFindFactionID(string lvName)
        {
            #region //Connect Database 
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PSConnection"].ToString());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            #endregion  

            string lvReturn = "";

            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT Faction_ID FROM Emp_Faction WHERE Faction_Name = '" + lvName + "' ";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lvReturn = dr["Faction_ID"].ToString();
                }
            }
            else
            {
                lvReturn = lvName;
            }

            dr.Close();
            con.Close();

            return lvReturn;
        }

        public static string fncFindPositionName(string lvID)
        {
            #region //Connect Database 
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PSConnection"].ToString());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            #endregion  

            string lvReturn = "";

            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT Position_Name FROM Emp_Position WHERE Position_ID = '" + lvID + "' ";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lvReturn = dr["Position_Name"].ToString();
                }
            }
            else
            {
                lvReturn = lvID;
            }

            dr.Close();
            con.Close();

            return lvReturn;
        }

        public static string fncFindPrefixName(string lvID)
        {
            #region //Connect Database 
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PSConnection"].ToString());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            #endregion  

            string lvReturn = "";

            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT PrefixName FROM Emp_Prefix WHERE PrefixID = '" + lvID + "' ";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lvReturn = dr["PrefixName"].ToString();
                }
            }
            else
            {
                lvReturn = lvID;
            }

            dr.Close();
            con.Close();

            return lvReturn;
        }

        public static string fncFindEmpTypeName(string lvID)
        {
            #region //Connect Database 
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PSConnection"].ToString());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            #endregion  

            string lvReturn = "";

            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT EmpType_Name FROM Emp_Type WHERE EmpType_ID = '" + lvID + "' ";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lvReturn = dr["EmpType_Name"].ToString();
                }
            }
            else
            {
                lvReturn = lvID;
            }

            dr.Close();
            con.Close();

            return lvReturn;
        }

        public static string fncFindFullEmpName(string lvID)
        {
            #region //Connect Database 
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PSConnection"].ToString());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            #endregion  

            string lvReturn = "";

            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT * FROM Employee  WHERE Employee_ID = '" + lvID + "' ";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lvReturn = dr["Employee_NTitle"].ToString() + " " + dr["Employee_Name"].ToString() + " " + dr["Employee_LName"].ToString();
                }
            }
            else
            {
                lvReturn = lvID;
            }

            dr.Close();
            con.Close();

            return lvReturn;
        }
        public static string fncFindEmpName(string lvID)
        {
            #region //Connect Database 
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PSConnection"].ToString());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            #endregion  

            string lvReturn = "";

            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT Employee_Name FROM Employee WHERE Employee_ID = '" + lvID + "' ";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lvReturn = dr["Employee_Name"].ToString();
                }
            }
            else
            {
                lvReturn = lvID;
            }

            dr.Close();
            con.Close();

            return lvReturn;
        }

        public static string fncFindEmpIDByUser(string lvID)
        {
            #region //Connect Database 
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PSConnection"].ToString());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            #endregion  

            string lvReturn = "";

            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT us_EmpID FROM SysUser WHERE us_UserID = '" + lvID + "' ";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lvReturn = dr["us_EmpID"].ToString();
                }
            }
            else
            {
                lvReturn = lvID;
            }

            dr.Close();
            con.Close();

            return lvReturn;
        }

        public static string fncFindEmpLName(string lvID)
        {
            #region //Connect Database 
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PSConnection"].ToString());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            #endregion  

            string lvReturn = "";

            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT Employee_LName FROM Employee WHERE Employee_ID = '" + lvID + "' ";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lvReturn = dr["Employee_LName"].ToString();
                }
            }
            else
            {
                lvReturn = lvID;
            }

            dr.Close();
            con.Close();

            return lvReturn;
        }

        public static void fncFindPermission(string lvUserID,string lvDisplayCode)
        {
            #region //Connect Database 
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PSConnection"].ToString());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            #endregion  

            int lvReturn = 0;

            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT * FROM SysPermission WHERE Permission_Code = '" + lvDisplayCode + "' And Permission_UserID = '"+ lvUserID +"' ";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    GVar.gvPermitEntry = "Y";
                    GVar.gvPermitNew = dr["Permission_New"].ToString();
                    GVar.gvPermitEdit = dr["Permission_Edit"].ToString();
                    GVar.gvPermitDel = dr["Permission_Del"].ToString();
                    GVar.gvPermitApprove = dr["Permission_AppDoc"].ToString();
                    GVar.gvPermitCancel = dr["Permission_CancelDoc"].ToString();
                    GVar.gvPermitPrint = dr["Permission_Print"].ToString();
                }
            }
            else
            {
                GVar.gvPermitEntry = "N";
                GVar.gvPermitNew = "";
                GVar.gvPermitEdit = "";
                GVar.gvPermitDel = "";
                GVar.gvPermitApprove = "";
                GVar.gvPermitCancel = "";
                GVar.gvPermitPrint = "";
            }

            dr.Close();
            con.Close();
        }

        public static string FindSectionByEmpID(string lvEmpID)
        {
            #region //Connect Database 
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PSConnection"].ToString());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            #endregion  

            string lvReturn = "";

            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT Section_Name FROM Employee Inner Join Emp_Section On Section_ID = Employee_Section WHERE Employee_ID = '" + lvEmpID + "' ";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lvReturn = dr["Section_Name"].ToString();
                }
            }

            dr.Close();
            con.Close();

            return lvReturn;
        }

        public static string fncFindItemName(string lvID)
        {
            #region //Connect Database 
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PSConnection"].ToString());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            #endregion  

            string lvReturn = "";

            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT Item_Name FROM SysITEM_Stock WHERE Item_ID = '" + lvID + "' ";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lvReturn = dr["Item_Name"].ToString();
                }
            }

            dr.Close();
            con.Close();

            return lvReturn;
        }

        public static string fncFindItemUnit(string lvID)
        {
            #region //Connect Database 
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PSConnection"].ToString());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            #endregion  

            string lvReturn = "";

            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT Item_Unit FROM SysITEM_Stock WHERE Item_ID = '" + lvID + "' ";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lvReturn = dr["Item_Unit"].ToString();
                }
            }

            dr.Close();
            con.Close();

            return lvReturn;
        }

        public static string fncFindBal(string lvID)
        {
            #region //Connect Database 
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PSConnection"].ToString());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            #endregion  

            string lvReturn = "";

            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT Item_Amount FROM SysITEM_Stock WHERE Item_ID = '" + lvID + "' ";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lvReturn = dr["Item_Amount"].ToString();
                }
            }

            dr.Close();
            con.Close();

            return lvReturn;
        }

        public static string fncFindMinStock(string lvID)
        {
            #region //Connect Database 
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PSConnection"].ToString());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            #endregion  

            string lvReturn = "";

            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT Item_Min FROM SysITEM_Stock WHERE Item_ID = '" + lvID + "' ";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lvReturn = dr["Item_Min"].ToString();
                }
            }

            dr.Close();
            con.Close();

            return lvReturn;
        }

        //Document
        public static string fncGenDocNo(string lvDocCode)
        {
            #region //Connect Database 
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PSConnection"].ToString());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            #endregion  

            string lvReturn = "";

            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT * FROM SysDocNo WHERE S_MCode = '" + lvDocCode + "' ";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    //GenDoc
                    string lvShort = dr["S_ShortCode"].ToString();
                    int lvYearChk = DateTime.Now.Year;
                    if (lvYearChk < 2500) lvYearChk += 543;
                    string lvYear = (lvYearChk - 2500).ToString();
                    int lvMonth = DateTime.Now.Month;
                    int lvDay = DateTime.Now.Day;
                    string lvSection = "121";
                    int lvRunDoc = Gstr.fncToInt(dr["S_RunNo"].ToString());

                    string lvDocID = "";
                    if (dr["S_TypeGen"].ToString() == "YYMMDept")
                        lvDocID = lvShort + lvYear.ToString() + lvMonth.ToString("00") + lvSection + lvRunDoc.ToString(dr["S_Format"].ToString());
                    else if (dr["S_TypeGen"].ToString() == "YYMMdd")
                        lvDocID = lvShort + lvYear.ToString() + lvMonth.ToString("00") + lvDay.ToString("00") + lvRunDoc.ToString(dr["S_Format"].ToString());
                    else
                        lvDocID = lvShort + lvRunDoc.ToString(dr["S_Format"].ToString());

                    lvReturn = lvDocID;
                }
            }
            else
            {
                lvReturn = "";
            }

            dr.Close();
            con.Close();

            return lvReturn;
        }

        //Log
        public static string fncKeepLogData(string lvUser, string lvDisplay, string lvActivity)
        {
            string lvReturn = "";
            try
            {
                string lvDate = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");

                string lvSQL = "insert into Log_History (Log_UserID, Log_Display, Log_Activity, Log_DateTime) ";
                lvSQL += "Values ('" + lvUser + "', '" + lvDisplay + "', '" + lvActivity + "', '" + lvDate + "')";

                string query = lvSQL;
                SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PS_LogConnection"].ToString());
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                lvReturn = "Success";
                return lvReturn;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}