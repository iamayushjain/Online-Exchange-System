using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class Project : System.Web.UI.Page
{
    SqlDataAdapter da;
    DataSet ds;
    SqlConnection con = new SqlConnection("server=localhost;database=projdb;user id=sa;password=sql");
    SqlCommand cmd;
    SqlDataReader dtr;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            string selQry = "select cat_id,cat_name from cat_master";
            DataSet ds = BLogic.ReturnDataSet(selQry);
            DropDownList1.DataSource = ds.Tables[0];
            DropDownList1.DataTextField = "cat_name";
            DropDownList1.DataValueField = "cat_id";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "--select category--");


        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
           
            if (DropDownList1.SelectedItem.Text.ToString() == "Electronics")
            {
                if (DropDownList2.SelectedItem.Text.ToString() == "Laptops")
                {
                    FileUpload1.PostedFile.SaveAs(Server.MapPath("Products/Electronics/Laptops/" + FileUpload1.FileName));
                    Image1.ImageUrl = "~/Products/Electronics/Laptops/" + FileUpload1.FileName;
                }

                else if (DropDownList2.SelectedItem.Text.ToString() == "Mobiles")
                {
                    FileUpload1.PostedFile.SaveAs(Server.MapPath("Products/Electronics/Mobiles/" + FileUpload1.FileName));
                    Image1.ImageUrl = "~/Products/Electronics/Mobiles/" + FileUpload1.FileName;
                }

                else if (DropDownList2.SelectedItem.Text.ToString() == "Tablets")
                {
                    FileUpload1.PostedFile.SaveAs(Server.MapPath("Products/Electronics/Tablets/" + FileUpload1.FileName));
                    Image1.ImageUrl = "~/Products/Electronics/Tablets/" + FileUpload1.FileName;
                }
                else if (DropDownList2.SelectedItem.Text.ToString() == "TVs")
                {
                    FileUpload1.PostedFile.SaveAs(Server.MapPath("Products/Electronics/TVs/" + FileUpload1.FileName));
                    Image1.ImageUrl = "~/Products/Electronics/TVs/" + FileUpload1.FileName;
                }
            }
            else if (DropDownList1.SelectedItem.Text.ToString() == "Vehicles")
            {
                if (DropDownList2.SelectedItem.Text.ToString() == "Bikes")
                {
                    FileUpload1.PostedFile.SaveAs(Server.MapPath("Products/Vehicles/Bikes/" + FileUpload1.FileName));
                    Image1.ImageUrl = "~/Products/Vehicles/Bikes/" + FileUpload1.FileName;
                }
                else if (DropDownList2.SelectedItem.Text.ToString() == "Cars")
                {
                    FileUpload1.PostedFile.SaveAs(Server.MapPath("Products/Vehicles/Cars/" + FileUpload1.FileName));
                    Image1.ImageUrl = "~/Products/Vehicles/Cars/" + FileUpload1.FileName;
                }
                else if (DropDownList2.SelectedItem.Text.ToString() == "Scooters")
                {
                    FileUpload1.PostedFile.SaveAs(Server.MapPath("Products/Vehicles/Scooters/" + FileUpload1.FileName));
                    Image1.ImageUrl = "~/Products/Vehicles/Scooters/" + FileUpload1.FileName;
                }

            
                
            }
            else if (DropDownList1.SelectedItem.Text.ToString() == "Appliances")
            {
                if (DropDownList2.SelectedItem.Text.ToString() == "ACs")
                {
                    FileUpload1.PostedFile.SaveAs(Server.MapPath("Products/Appliances/ACs" + FileUpload1.FileName));
                    Image1.ImageUrl = "~/Products/Appliances/ACs" + FileUpload1.FileName;
                }
                else if (DropDownList2.SelectedItem.Text.ToString() == "CFLs")
                {
                    FileUpload1.PostedFile.SaveAs(Server.MapPath("Products/Appliances/CFLs" + FileUpload1.FileName));
                    Image1.ImageUrl = "~/Products/Appliances/CFLs" + FileUpload1.FileName;
                }
                else if (DropDownList2.SelectedItem.Text.ToString() == "Fans")
                {
                    FileUpload1.PostedFile.SaveAs(Server.MapPath("Products/Appliances/Fans" + FileUpload1.FileName));
                    Image1.ImageUrl = "~/Products/Appliances/Fans" + FileUpload1.FileName;
                }


            }
            else if (DropDownList1.SelectedItem.Text.ToString() == "Books")
            {
                if (DropDownList2.SelectedItem.Text.ToString() == "Fiction")
                {
                    FileUpload1.PostedFile.SaveAs(Server.MapPath("Products/Books/Fiction" + FileUpload1.FileName));
                    Image1.ImageUrl = "~/Products/Books/Fiction" + FileUpload1.FileName;
                }
                else if (DropDownList2.SelectedItem.Text.ToString() == "Non-Fiction")
                {
                    FileUpload1.PostedFile.SaveAs(Server.MapPath("Products/Books/Non-Fiction" + FileUpload1.FileName));
                    Image1.ImageUrl = "~/Products/Books/Non-Fiction" + FileUpload1.FileName;
                }
               


            }
            else if (DropDownList1.SelectedItem.Text.ToString() == "Furniture")
            {
                if (DropDownList2.SelectedItem.Text.ToString() == "Beds")
                {
                    FileUpload1.PostedFile.SaveAs(Server.MapPath("Products/Furniture/Beds" + FileUpload1.FileName));
                    Image1.ImageUrl = "~/Products/Furniture/Beds" + FileUpload1.FileName;
                }
                else if (DropDownList2.SelectedItem.Text.ToString() == "Chairs")
                {
                    FileUpload1.PostedFile.SaveAs(Server.MapPath("Products/Furniture/Chairs" + FileUpload1.FileName));
                    Image1.ImageUrl = "~/Products/Furniture/Chairs" + FileUpload1.FileName;
                }
                else if (DropDownList2.SelectedItem.Text.ToString() == "Sofas")
                {
                    FileUpload1.PostedFile.SaveAs(Server.MapPath("Products/Furniture/Sofas" + FileUpload1.FileName));
                    Image1.ImageUrl = "~/Products/Furniture/Sofas" + FileUpload1.FileName;
                }




            }

        }
        else
            Response.Write("Select any file to upload");

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string qry = "insert into prod3_master values('" + TextBox1.Text + "','" + DropDownList1.SelectedItem.Text + "','"+DropDownList1.SelectedItem.Text+"','" + TextBox3.Text + "'," + TextBox4.Text + ",'"+Image1.ImageUrl+"','"+TextBox5.Text+"','"+TextBox6.Text+"','"+TextBox7.Text+"','"+TextBox8.Text+"')";
        BLogic.ExecuteNonQry(qry);
        //cmd = new SqlCommand(qry, con);
        //con.Open();
        //cmd.ExecuteNonQuery();
        //con.Close();
        Response.Write("Ad posted successfully!");
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string subqry = "select sub_id,sub_name from sub_cat_master where sub_cat_id=" + DropDownList1.SelectedItem.Value;
        SqlCommand cmd = new SqlCommand(subqry, con);
        con.Open();
        dtr = cmd.ExecuteReader();
        DropDownList2.Items.Clear();
        while (dtr.Read())
        {
            DropDownList2.Items.Add(new ListItem(dtr[1].ToString()));
        }
        con.Close();
        //SqlDataReader dtr = BLogic.DataReader(subqry);
        //DropDownList2.Items.Clear
        //BLogic.BindDropDown(subqry, DropDownList1);
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}