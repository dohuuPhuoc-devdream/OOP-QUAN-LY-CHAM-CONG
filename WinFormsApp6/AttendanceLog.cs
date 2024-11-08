using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp6
{
    public class AttendanceLog
    {
        public Employee Employee { get; set; }
        public List<Shift> Shifts { get; private set; } = new List<Shift>();

        public AttendanceLog(Employee employee)
        {
            Employee = employee;
        }

        public void StartShift()
        {
            Shifts.Add(new Shift(DateTime.Now));
        }

        public void EndShift()
        {
            if (Shifts.Count > 0)
            {
                Shifts.Last().EndCurrentShift(DateTime.Now);
            }
        }
    }

}
