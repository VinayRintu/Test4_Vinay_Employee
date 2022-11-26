using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4_Vinay_Employee
{
    internal class EditEmployee
    {
        string? connection= "Server=VINDUJA\\MSSQLSERVER01;Database=Test;Trusted_Connection = true;TrustServerCertificate=True";
        SqlConnection? con;
        string? query;
        public void UpdateEmployeeData()
        {
            Console.WriteLine("Enter EmployeeID where to Update ");
            int eId=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Updated Employee Name");
            string eName=Console.ReadLine();
            
            con = new SqlConnection(connection);
            con.Open();
            query = "update Employee set EmpName='" + eName + "' where EmpID=" + eId + "";
            SqlCommand cmd=new SqlCommand(query, con);             
            int objDone = cmd.ExecuteNonQuery();
            con.Close();
            if(objDone == 1)
            {
                Console.WriteLine("Updated Record Successfully");
            }
        }
        public void DeleteEmployeeData()
        {
            Console.WriteLine("Enter EmployeeID  to Delete ");
            int eId = int.Parse(Console.ReadLine());

            con = new SqlConnection(connection);
            con.Open();
            query = "delete Employee where EmpID=" + eId + "";
            SqlCommand cmd = new SqlCommand(query, con);           
            int objDone = cmd.ExecuteNonQuery();
            cmd.Clone();
            if (objDone == 1)
            {
                Console.WriteLine("Employee Record Deleted Successfully");
            }
        }
    }
}
