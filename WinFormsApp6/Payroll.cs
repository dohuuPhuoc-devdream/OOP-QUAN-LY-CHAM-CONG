using System;
using System.Collections.Generic;

namespace WinFormsApp6
{
    public class Payroll
    {
        private Employee employee;
        public List<ShiftRecord> ShiftRecords { get; set; } = new List<ShiftRecord>();
        public Payroll(Employee employee, List<ShiftRecord> shiftRecord)
        {
            this.employee = employee;
            this.ShiftRecords=shiftRecord;
        }
        public List<ShiftRecord> GetEmployeeShiftRecords()
        {
            List<ShiftRecord> employeeShifts = new List<ShiftRecord>();

            foreach (ShiftRecord shift in ShiftRecords)
            {
                if (shift.EmployeeId == employee.Id && shift.IsCompleteShift())
                {
                    employeeShifts.Add(shift);
                }
            }

            Console.WriteLine("Số ca làm việc tìm thấy cho nhân viên " + employee.Id + ": " + employeeShifts.Count);
            return employeeShifts;
        }


        // Xác định số ca tiêu chuẩn trong tháng, trừ Chủ nhật và các ngày lễ
        public int CalculateStandardShifts(int month, int year)
        {
            int standardShifts = 0;
            int daysInMonth = DateTime.DaysInMonth(year, month);

            for (int day = 1; day <= daysInMonth; day++)
            {
                DateTime date = new DateTime(year, month, day);
                if (date.DayOfWeek != DayOfWeek.Sunday && !IsCompanyHoliday(date))
                {
                    standardShifts++;
                }
            }
            return standardShifts;
        }

        // Giả sử có một danh sách các ngày lễ của công ty
        private bool IsCompanyHoliday(DateTime date)
        {
            List<DateTime> companyHolidays = new List<DateTime>
            {
                new DateTime(date.Year, 4, 30), // Ví dụ: ngày Giải phóng miền Nam
                new DateTime(date.Year, 5, 1),  // Ngày Quốc tế Lao động
                new DateTime(date.Year, 9,2),   // Ngày Quốc khánh

            };

            foreach (DateTime holiday in companyHolidays)
            {
                if (holiday == date)
                {
                    return true;
                }
            }
            return false;
        }
        public int CalculateTotalShifts()
        {
            // Debugging: Log the number of shift records
            Console.WriteLine($"Total Shift Records: {ShiftRecords.Count}");

            int completeShifts = GetEmployeeShiftRecords().Count;

            // Debugging: Log the number of complete shifts
            Console.WriteLine($"Complete Shifts: {completeShifts}");

            return completeShifts;

        }


        //Tính lương thực tế dựa trên số ca làm việc thực tế của nhân viên
        public double CalculateSalary(int month, int year)
        {
            int standardShifts = CalculateStandardShifts(month, year);
            int actualShifts = CalculateTotalShifts();
            double baseSalary = employee.BasicSalary; // Lấy lương cơ bản từ Employee
            double salary = (standardShifts > 0) ? ((double)actualShifts / standardShifts) * baseSalary : 0;
            return salary;
        }

    }
}

