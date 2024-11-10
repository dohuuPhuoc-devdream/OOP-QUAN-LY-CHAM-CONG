using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        private List<Employee> employees = new List<Employee>();
        private AttendanceLog currentAttendanceLog;
        private TimeKeepingSystem timeKeepingSystem = new TimeKeepingSystem();
        private DataGridView dataGridView1 = new DataGridView();
        private FileManager<Employee> employeeFileManager = new FileManager<Employee>();
        private List<ShiftRecord> ShiftRecords = new List<ShiftRecord>();
        private FileManager<ShiftRecord> shiftRecordFileManager = new FileManager<ShiftRecord>();

        public Form1()
        {
            InitializeComponent();
            LoadEmployees();
            textBoxEmployeeId.KeyDown += TextBoxEmployeeID_KeyDown;
            LoadShiftRecords();
            PopulateDataGridView();
            SaveShiftRecords();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            SaveShiftRecords();
        }
        private void PopulateDataGridView()
        {
            for (int i = 0; i < ShiftRecords.Count; i++)
            {
                ShiftRecord shiftRecord = ShiftRecords[i];
                Employee employee = GetEmployeeById(shiftRecord.EmployeeId);
                if (employee != null)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1);
                    row.Cells[0].Value = employee.Id;
                    row.Cells[1].Value = employee.Fullname;
                    row.Cells[2].Value = employee.Department;
                    row.Cells[3].Value = employee.Position;
                    row.Cells[4].Value = employee.GenDer;
                    row.Cells[5].Value = employee.DateOfbirth;
                    row.Cells[6].Value = shiftRecord.StartTime.HasValue ? shiftRecord.StartTime.Value.ToString() : string.Empty;
                    row.Cells[7].Value = shiftRecord.EndTime.HasValue ? shiftRecord.EndTime.Value.ToString() : string.Empty;
                    dataGridView1.Rows.Add(row);
                }
            }
        }
        private void LoadEmployees()
        {
            if (File.Exists(@"C:\Users\DO HUU PHUOC\OneDrive\Máy tính\employees.json"))
            {
                string json = File.ReadAllText(@"C:\Users\DO HUU PHUOC\OneDrive\Máy tính\employees.json");
                employees = JsonSerializer.Deserialize<List<Employee>>(json);
            }
        }
        private void SaveEmployees()
        {
            string json = JsonSerializer.Serialize(employees, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(@"C:\Users\DO HUU PHUOC\OneDrive\Máy tính\employees.json", json);

        }
            private Employee GetEmployeeById(string id)
        {
            foreach (Employee emp in employees)
            {
                if (emp.Id == id)
                    return emp;
            }
            return null;
        }
        private void LoadShiftRecords()
        {
            ShiftRecords = shiftRecordFileManager.DeserializeData(@"C:\Users\DO HUU PHUOC\OneDrive\Máy tính\shift.json");
        }

        private void SaveShiftRecords()
        {
            shiftRecordFileManager.SerializeData(ShiftRecords, @"C:\Users\DO HUU PHUOC\OneDrive\Máy tính\shift.json");
        }
        private void TextBoxEmployeeID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Kiểm tra xem có nhấn phím Enter hay không
            {
                string employeeCode = textBoxEmployeeId.Text.Trim();
                Employee employee = employees.Find(emp => emp.Id == employeeCode);

                if (employee != null)
                {
                    // Nếu tìm thấy nhân viên, hiển thị thông tin
                    textBoxFullName.Text = employee.Fullname;
                    textBoxDepartment.Text = employee.Department;
                    textBoxPosition.Text = employee.Position;
                    if (employee.GenDer == "Nam")
                    {
                        radioButtonMale.Checked = true;
                    }
                    else if (employee.GenDer == "Nữ")
                    {
                        radioButtonFemale.Checked = true;
                    }
                    textBoxDateOfBirth.Text = employee.DateOfbirth;
                }
                else
                {
                    // Nếu không tìm thấy, hiện thông báo
                    MessageBox.Show("Không tìm thấy nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Xóa các textbox để tránh hiển thị thông tin cũ
                    textBoxFullName.Clear();
                    textBoxDepartment.Clear();
                    textBoxPosition.Clear();
                    radioButtonMale.Checked = false;
                    radioButtonFemale.Checked = false;
                    textBoxDateOfBirth.Clear();
                }
            }
        }

        private void buttonStartShift_Click(object sender, EventArgs e)
        {
            string id = textBoxEmployeeId.Text;
            Employee employee = GetEmployeeById(id);

            if (employee != null)
            {
                if (currentAttendanceLog != null && currentAttendanceLog.Employee.Id == employee.Id && currentAttendanceLog.Shifts.Any() && !currentAttendanceLog.Shifts.Last().EndShift.HasValue)
                {
                    MessageBox.Show("Bạn đang trong ca làm việc. Vui lòng kết thúc ca trước khi bắt đầu ca mới.");
                    return;
                }
                DialogResult result = MessageBox.Show("Bạn có muốn xác nhận vào ca?", "Xác Nhận", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    currentAttendanceLog = new AttendanceLog(employee);
                    currentAttendanceLog.StartShift();
                    ShiftRecords.Add(new ShiftRecord(DateTime.Now) { EmployeeId = employee.Id });
                    MessageBox.Show("Bạn đã vào ca thành công");
                }
                SaveShiftRecords();
            }
            else
            {
                MessageBox.Show("Nhân viên không tồn tại.");
            }
            string employeeID = textBoxEmployeeId.Text;
            string employeeFullName = textBoxFullName.Text;
            string employeeDepartment = textBoxDepartment.Text;
            string employeePosition = textBoxPosition.Text;
            string employeeDateOfBirth = textBoxDateOfBirth.Text;

            string employeeGender = radioButtonMale.Checked ? "Nam" : radioButtonFemale.Checked ? "Nữ" : "Không xác định";
            string emmployeeStartShift = currentAttendanceLog.Shifts.Last().StartShift.ToString();
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
            row.Cells[0].Value = employeeID;
            row.Cells[1].Value = employeeFullName;
            row.Cells[2].Value = employeeDepartment;
            row.Cells[3].Value = employeePosition;
            row.Cells[4].Value = employeeGender;
            row.Cells[5].Value = employeeDateOfBirth;
            row.Cells[6].Value = emmployeeStartShift;

            //Thêm hàng mới
            dataGridView1.Rows.Add(row);

        }

        private void buttonEndShift_Click(object sender, EventArgs e)
        {
            if (currentAttendanceLog != null && currentAttendanceLog.Shifts.Any())
            { 
                DialogResult result = MessageBox.Show("Bạn có muốn kết thúc ca?", "Xác Nhận", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    currentAttendanceLog.EndShift();
                    ShiftRecords.Last().EndCurrentShiftTime(DateTime.Now);
                    ShiftRecords.FindLast(sr => sr.EmployeeId == currentAttendanceLog.Employee.Id)?.EndCurrentShiftTime(DateTime.Now);
                    ShiftRecord shiftRecord = ShiftRecords.FindLast(sr => sr.EmployeeId == currentAttendanceLog.Employee.Id);
                    MessageBox.Show("Bạn đã Kết Thúc ca thành công");
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == textBoxEmployeeId.Text)
                        {
                            string emmployeeEndShift = currentAttendanceLog.Shifts.Last().EndShift.ToString();
                            row.Cells[7].Value = emmployeeEndShift;
                        }
                    }
                }
                SaveShiftRecords();
                SaveEmployees();

            }
            else
            {
                MessageBox.Show("Vui lòng bắt đầu ca trước.");

            }
            }

        private void ClearInputFields()
        {
            textBoxEmployeeId.Clear();
            textBoxFullName.Clear();
            textBoxDepartment.Clear();
            textBoxPosition.Clear();
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            textBoxDateOfBirth.Clear();
        }
        private void btnXemLuong_Click(object sender, EventArgs e)
        {
            string employeeId = txtEmployeeId.Text.Trim();
            Employee selectedEmployee = GetEmployeeById(employeeId);

            if (string.IsNullOrEmpty(employeeId))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên.", "Thông báo");
                return;
            }
            //// Tính toán và hiển thị lương
            if (selectedEmployee != null)
            {
                Employee employee = GetEmployeeById(employeeId);
                Console.WriteLine($"Selected Employee ID: {selectedEmployee.Id}, Name: {selectedEmployee.FullName}");

                List<ShiftRecord> employeeShiftRecords = ShiftRecords.Where(sr => sr.EmployeeId == selectedEmployee.Id).ToList();

                Console.WriteLine($"Number of Shift Records for Employee ID {selectedEmployee.Id}: {employeeShiftRecords.Count}");
                for (int i = 0; i < ShiftRecords.Count; i++)
                {
                    if (ShiftRecords[i].EmployeeId == selectedEmployee.Id )
                    {
                        employeeShiftRecords.Add(ShiftRecords[i]);
                    }
                }
                if (employeeShiftRecords.Count > 0)
                {
                    Payroll payroll = new Payroll(selectedEmployee, ShiftRecords);

                    // Thiết lập tháng và năm
                    int month = DateTime.Now.Month;
                    int year = DateTime.Now.Year;
                    // Tính lương
                    int actualShifts = payroll.CalculateTotalShifts(); // Tính tổng số ca thực tế đã làm
                    int standardShifts = payroll.CalculateStandardShifts(month, year); // Tính số ca chuẩn trong tháng
                    double Totalsalary = payroll.CalculateSalary(month, year);
                    lblTotalShifts.Text = $"Số ngày công {employeeId} : {actualShifts}/{standardShifts}";
                    // Hiển thị lương trên giao diện
                    lblSalary.Text = $"Lương tháng của nhân viên {employeeId} : {Totalsalary.ToString("C", new System.Globalization.CultureInfo("vi-VN"))}"; // Hiển thị với định dạng tiền tệ
                }
                else
                {
                    lblSalary.Text = "Không tìm thấy nhân viên hoặc không có ca làm việc nào.";
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên với mã: " + employeeId);
            }
            
        }
       
    }
}
