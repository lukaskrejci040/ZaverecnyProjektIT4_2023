using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class WorkHour
    {
        public WorkHour(int id, int employee, int contract, int workType, int hour, DateTime kdy)
        {
            Id = id;
            Employee = employee;
            Contract = contract;
            WorkType = workType;
            Hour = hour;
            Kdy = kdy;
        }

        public int Id { get; set; }
        public int Employee { get; set; }
        public int Contract { get; set; }
        public int WorkType { get; set; }
        public int Hour { get; set; }
        public DateTime Kdy { get; set; }

    }
}