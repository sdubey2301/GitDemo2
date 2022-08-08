using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using conn.Entities;
using System.Data;

namespace conn.Operations
{
    public class OEmployee
    {
       public int Add(EEmployee empl)
        {
            SqlConnection con = new SqlConnection("Data Source = IN-5CG9524WGM\\SQLEXPRESS; Initial Catalog = dxc; Integrated Security = True");

            con.Open();
            //string query = "insert into Emp values('" + empl.Name + "' , " + empl.age + ", " + empl.contactno + ") ";


            SqlCommand cmd = new SqlCommand("InsertEmp_SP",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", empl.Name);
            cmd.Parameters.AddWithValue("@age", empl.age);
            cmd.Parameters.AddWithValue("@contactno", empl.contactno);
            int effectedRows = cmd.ExecuteNonQuery();
            return effectedRows;
        }

        public int Update(EEmployee empl)
        {
            SqlConnection con = new SqlConnection("Data Source = IN-5CG9524WGM\\SQLEXPRESS; Initial Catalog = dxc; Integrated Security = True");
            

            con.Open();
            //string query = "UPDATE Emp SET Name = '" + empl.Name + "', age = " + empl.age + ",contactno = " + empl.contactno + "where EmpID = " + empl.EmpID;

            SqlCommand cmd = new SqlCommand("UpdateEmp_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpID", empl.EmpID);
            cmd.Parameters.AddWithValue("@Name", empl.Name);
            cmd.Parameters.AddWithValue("@age", empl.age);
            cmd.Parameters.AddWithValue("@contactno", empl.contactno);
            int effectedRows = cmd.ExecuteNonQuery();

            return effectedRows;
        }

        public int Delete(EEmployee empl)
        {
            SqlConnection con = new SqlConnection("Data Source = IN-5CG9524WGM\\SQLEXPRESS; Initial Catalog = dxc; Integrated Security = True");


            con.Open();
            //string query = "DELETE FROM Emp where EmpID = " + empl.EmpID;

            SqlCommand cmd = new SqlCommand("DeleteEmp_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpID", empl.EmpID);
            int effectedRows = cmd.ExecuteNonQuery();
            return effectedRows;
        }
        
        public DataTable Search(EEmployee ee)
        {
            SqlConnection con = new SqlConnection("Data Source = IN-5CG9524WGM\\SQLEXPRESS; Initial Catalog = dxc; Integrated Security = True");


            string query = "SELECT * FROM Emp where \"" + ee.Property + "\"like '%" + ee.EnterValue + "%'";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt; 
            
            

        }
    }
}
