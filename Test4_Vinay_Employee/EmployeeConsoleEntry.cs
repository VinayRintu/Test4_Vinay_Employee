using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4_Vinay_Employee
{
    internal class EmployeeConsoleEntry
    {
        string? connection;
        SqlConnection? con;
        string? query;
        public void AddEmployee()
        {

            Console.WriteLine("Enter Employee Name ");
            string EmpName = Console.ReadLine();
            Console.WriteLine("Enter Employee Age");
            int EmpAge =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Gender");
            string EmpGender=Console.ReadLine();
            Console.WriteLine("Enter Employee ID Based on Employee");
            int EmpDeptID = int.Parse(Console.ReadLine());

            connection = "Server=VINDUJA\\MSSQLSERVER01;Database=Test;Trusted_Connection = true;TrustServerCertificate=True";
            con = new SqlConnection(connection);
            con.Open();
           
            query = "insert into  Employee values('" + EmpName + "'," + EmpAge + ",'"+EmpGender+"',"+EmpDeptID+")";
            SqlCommand cmd = new SqlCommand(query, con);
            int isDone = cmd.ExecuteNonQuery();
            con.Close();
            if (isDone == 1)
            {
                Console.WriteLine("Employee Record inserted Successfully");
            }
        }
    }
}
