using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpInfo
{
   public class Employee
    {
       public string employeeName { get; set; }
        public string employeeId { get; set; }
      public  string employeePhone { get; set; }
        public string employeeAddress { get; set; }
        private string _employeetweetId;
        public string empolyeeTweetId
        {
            get { return _employeetweetId; }
            set
            {
                if (value.StartsWith("@"))
                {
                    _employeetweetId = value;
                }
                else
                {
                    throw new Exception("please enter tweet id with @sign");
                }
            }
        }

    }
}
