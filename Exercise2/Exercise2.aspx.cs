using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;


public partial class Exercise2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void updateGridView(object sender, EventArgs e)
    {
        try
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT b.[site_id] 'Site ID', b.[name] 'Site Name' ");
            sql.Append("FROM [Employer_Master] a ");
            sql.Append("JOIN [Site] b ON a.[group_estab_no] = b.[linked_estab_no] ");
            sql.Append("WHERE  a.estab_name = '" + DropDownList1.SelectedValue + "' ");
            sql.Append("AND a.[date_time_deleted] IS NULL AND b.[date_time_deleted] IS NULL");
            SqlDataAdapter da = new SqlDataAdapter(sql.ToString(), System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "site");
            GridView2.DataSource = ds.Tables["site"].DefaultView;
            GridView2.DataBind();
        }
        catch(Exception ex)
        {
            GridView2.Columns.Clear();
            GridView2.DataBind();
        }
    }

}
