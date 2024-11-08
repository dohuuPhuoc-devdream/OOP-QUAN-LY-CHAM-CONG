using System;
using System.Collections.Generic;
using System.Text.Json;


namespace WinFormsApp6
{
    public class TimeKeepingSystem
    {
        private List<Employee> Employees = new List<Employee>();
        private List<ShiftRecord> ShiftRecords = new List<ShiftRecord>();
        private FileManager<Employee> employeeFileManager = new FileManager<Employee>();
        private FileManager<ShiftRecord> shiftRecordFileManager = new FileManager<ShiftRecord>();

        public void LoadEmployees(string filePath)
        {
            Employees = employeeFileManager.DeserializeData(filePath);
        }

        public void SaveEmployees(string filePath)
        {
            employeeFileManager.SerializeData(Employees, filePath);
        }

        public void LoadShiftRecords(string filePath)
        {
            ShiftRecords = shiftRecordFileManager.DeserializeData(filePath);
        }

        public void SaveShiftRecords(string filePath)
        {
            shiftRecordFileManager.SerializeData(ShiftRecords, filePath);
        }

        public List<ShiftRecord> GetShiftRecords()
        {
            return ShiftRecords;
        }

        public void AddShiftRecord(ShiftRecord shiftRecord)
        {
            ShiftRecords.Add(shiftRecord);
        }

        // Phương thức tìm nhân viên theo ID
        private Employee FindEmployeeById(string employeeId)
        {
            foreach (Employee employee in Employees)
            {
                if (employee.Id == employeeId)
                {
                    return employee;
                }
            }
            return null;
        }
    }

}
