using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp6
{
    public class ShiftRecord
    {
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string EmployeeId { get; set; }
        public ShiftRecord(DateTime startShiftTime)
        {
            StartTime = startShiftTime;
        }

        public void EndCurrentShiftTime(DateTime endShiftTime)
        {
            EndTime = endShiftTime;
        }

        public bool IsCompleteShift()
        {
            //// kiểm tra xem có đủ starttime và endtime để xem như là một ca hoàn thành
            if (StartTime.HasValue && EndTime.HasValue)
            {
                TimeSpan shiftduration = EndTime.Value - StartTime.Value;
                return shiftduration.TotalMilliseconds >= 4;
            }
            return false;
        }
    }


}
