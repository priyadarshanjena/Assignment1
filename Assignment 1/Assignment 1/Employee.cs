using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Assignment_1
{
   
        public class Employee
        {
            public delegate void MethodCall(String[] msg, int i);
            public event MethodCall call;
            public String[] s1 = new String[3];
            public int i;

            public void doAction()
            {
                call(s1, i);
            }
            private int Id;
            private String EmpName, DeptName;

            public Employee(int Id, String EmpName, String DeptName)
            {
                this.Id = Id;
                this.EmpName = EmpName;
                this.DeptName = DeptName;
            }
            public int GetId(Employee emp)
            {
                i = 0;
                s1[0] = MethodBase.GetCurrentMethod().Name;
                emp.call += new Employee.MethodCall(show_Action);
                emp.doAction();
                return this.Id;
            }
            public String GetName(Employee emp)
            {
                i = 1;
                s1[1] = MethodBase.GetCurrentMethod().Name;
                emp.call += new Employee.MethodCall(show_Action);
                emp.call -= new Employee.MethodCall(show_Action);
                emp.doAction();
                return this.EmpName;
            }

            public string GetDeptName(Employee emp)
            {
                i = 2;
                s1[2] = MethodBase.GetCurrentMethod().Name;
                emp.call += new Employee.MethodCall(show_Action);
                emp.call -= new Employee.MethodCall(show_Action);
                emp.doAction();
                return this.DeptName;
            }
            static void show_Action(String[] msg, int i)
            {
                System.Console.WriteLine(msg[i] + "method called");
            }
            public void Set(int UId)
            {
                String name = MethodBase.GetCurrentMethod().Name;
                Id = UId;
                System.Console.WriteLine("Updated Employee id is:" + Id);
            }
            public void Set(String UName, int UId)
            {
                String name = MethodBase.GetCurrentMethod().Name;
                EmpName = UName;
                System.Console.WriteLine("Update Employee Name is :" + EmpName);

            }
            public void Set(String UDeptName, String UName, int UId)
            {
                String name = MethodBase.GetCurrentMethod().Name;
                DeptName = UDeptName;
                System.Console.WriteLine("Updated Employee DepartmentName is:" + DeptName);
            }

        }
    
}
