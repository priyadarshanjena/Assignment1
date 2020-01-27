using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter employee Id :");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name :");
            String emp_name = Console.ReadLine();
            Console.WriteLine("Enter Employee DepartmentName :");
            String dept_name = Console.ReadLine();

            Employee emp = new Employee(id, emp_name, dept_name);
            int eid = emp.GetId(emp);
            Console.WriteLine("Employee Id : {0}", eid);
            String ename = emp.GetName(emp);
            Console.WriteLine("Employee Name : {0}", ename);
            String edept = emp.GetDeptName(emp);
            Console.WriteLine("Employee DepartmentName : {0}", edept);

            Console.WriteLine("Enter Employee Id to update : ");
            int uid = Convert.ToInt32(Console.ReadLine());
            emp.Set(uid);
            Console.WriteLine("Enter Employee Name to update :");
            String uname = Console.ReadLine();
            emp.Set(uname, 0);

            Console.WriteLine("Enter Employee DepartmentName To Update :");
            String UdeptName = Console.ReadLine();
            emp.Set(UdeptName, null, 0);

        }
    }
   
}
