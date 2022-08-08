using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace conn
{
    public class Class1
    {
        
        public DataTable Print(string query)
        {
           
                string str = "Data Source = IN-5CG9524WGM\\SQLEXPRESS; Initial Catalog = dxc; Integrated Security = True";
                SqlConnection con = new SqlConnection(str);
            DataTable dt = new DataTable();

            con.Open();
                //SqlCommand cmd = new SqlCommand(query,con);
                //cmd.Connection = con;
                //cmd.CommandText = query;


            //cmd.ExecuteNonQuery();


            SqlDataAdapter da = new SqlDataAdapter(query,con);
            
            da.Fill(dt);
            
            
            con.Close();
               
                return dt;
          
            
                   
                       
        }
        

    } 
   
}
