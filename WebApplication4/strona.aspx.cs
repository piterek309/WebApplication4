using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == true)
            {
                Label1.Text = ("Dziękujemy, Twoje dane zostały zapisane");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection apkazaliczenie = new SqlConnection("Server=tcp:aplikacja62632.database.windows.net,1433;Initial Catalog=Aplikacja62632DB;Persist Security Info=False;User ID=Goliński;Password=Wsb62632;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            {
                SqlCommand insert = new SqlCommand("EXEC dbo.InsertFullname @Fullname", apkazaliczenie);
                insert.Parameters.AddWithValue("@Fullname", TextBox1.Text);
                apkazaliczenie.Open();
                insert.ExecuteNonQuery();
                apkazaliczenie.Close();
                
                if (IsPostBack)
                {
                    TextBox1.Text = "";
                }
            }
        }
    }
}