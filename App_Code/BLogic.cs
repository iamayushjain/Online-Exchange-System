
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;



  public   class BLogic
    {
        
        static public  SqlConnection GetDbConnection()
        {
           SqlConnection con = new SqlConnection(
               ConfigurationManager.ConnectionStrings
               ["connection"].ToString());

           
           return con;
        }
       
        

        public static DataSet ReturnDataSet(string selQry)
        {
            SqlDataAdapter da = new SqlDataAdapter(selQry, GetDbConnection());
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
       
        public static DataTable ReturnDataTable(string selQry)
        {
            SqlDataAdapter da = new SqlDataAdapter(selQry, GetDbConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static int ExecuteNonQry(string qry)
        {
            SqlConnection con=GetDbConnection();
            SqlCommand cmd = new SqlCommand(qry, con);
            con.Open();
            int result=cmd.ExecuteNonQuery();
            
            con.Close();
            return result;
        }
        

        public static SqlDataReader DataReader(string selQry)
        {
            SqlConnection con = GetDbConnection();
            SqlCommand cmd = new SqlCommand(selQry, con);
            con.Open();
            SqlDataReader dtr = cmd.ExecuteReader();
            
            return dtr;
        }
        public static object ExcutScalar(string qry)
        {
            SqlConnection con = GetDbConnection();
            SqlCommand cmd = new SqlCommand(qry, con);
            con.Open();
            object ob = cmd.ExecuteScalar();
            con.Close();
            return ob;
        }
        public static void Fill_Grid(string qry, GridView  gridID)
        {
            DataSet ds = new DataSet();
            ds = ReturnDataSet(qry);
            gridID.DataSource = ds.Tables[0];
            gridID.DataBind();
            
        }
        public static void BindDropDown(string qry, DropDownList ddlId)
        {
            DataSet ds = new DataSet();
            ds = ReturnDataSet(qry);
            ddlId.DataSource = ds.Tables[0];
            ddlId.DataTextField=ds.Tables[0].Columns[0].ToString();
            ddlId.DataBind();
            
        }
        

        
        
    }



