// See https://aka.ms/new-console-template for more information
using Test4_Vinay_Employee;

EditEmployee objEditEmployee=new EditEmployee();
EmployeeConsoleEntry objConsoleEntry=new EmployeeConsoleEntry();


Console.WriteLine("Select One Option" + Environment.NewLine + "1.Add Employee Records By List" + Environment.NewLine + "2.Add Employee By Console" + Environment.NewLine + "3.Update Employee" + Environment.NewLine + "4.Delete Employee");
int option = int.Parse(Console.ReadLine());
switch (option)
{
    case 1:

        DB_Connection_Employee objDBConnection = new DB_Connection_Employee();
        objDBConnection.DBconnection();
        break;
    case 2:
        objConsoleEntry.AddEmployee();
        break;
    case 3:
        objEditEmployee.UpdateEmployeeData();
        break;
    case 4:
        objEditEmployee.DeleteEmployeeData();
        break;
}