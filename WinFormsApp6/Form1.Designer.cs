
//using static System.Net.Mime.MediaTypeNames;
//using System.Windows.Forms;
//using System.Xml.Linq;
//using System.ComponentModel;

//namespace WinFormsApp5
//{
//    partial class Form1 : Form
//    {
//        // private IContainer components = null;
//        /// <summary>
//                /// Required designer variable.
//                /// </summary>
//                private System.ComponentModel.IContainer components = null;

//        protected override void Dispose(bool disposing)
//        { 
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        private void InitializeComponent()
//        {
//            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
//            tabControl1 = new TabControl();
//            tabPage1 = new TabPage();
//            textDateOfBirth = new TextBox();
//            buttonKetThucCa = new Button();
//            buttonVaoCa = new Button();
//            textPhoneNumber = new TextBox();
//            label1 = new Label();
//            textAddress = new TextBox();
//            label7 = new Label();
//            label6 = new Label();
//            checkBox2 = new CheckBox();
//            checkBox1 = new CheckBox();
//            label5 = new Label();
//            label4 = new Label();
//            textPosition = new TextBox();
//            Room = new Label();
//            textRoom = new TextBox();
//            nameLabel = new Label();
//            textName = new TextBox();
//            MSNV = new Label();
//            textMSNV = new TextBox();
//            tabPage2 = new TabPage();
//            TabPage3 = new TabPage();
//            tabPage4 = new TabPage();
//            tabControl1.SuspendLayout();
//            tabPage1.SuspendLayout();
//            SuspendLayout();
//            // 
//            // tabControl1
//            // 
//            tabControl1.Controls.Add(tabPage1);
//            tabControl1.Controls.Add(tabPage2);
//            tabControl1.Controls.Add(TabPage3);
//            tabControl1.Controls.Add(tabPage4);
//            tabControl1.Location = new Point(0, 12);
//            tabControl1.Name = "tabControl1";
//            tabControl1.SelectedIndex = 0;
//            tabControl1.Size = new Size(1070, 557);
//            tabControl1.TabIndex = 0;
//            // 
//            // tabPage1
//            // 
//            tabPage1.Controls.Add(textDateOfBirth);
//            tabPage1.Controls.Add(buttonKetThucCa);
//            tabPage1.Controls.Add(buttonVaoCa);
//            tabPage1.Controls.Add(textPhoneNumber);
//            tabPage1.Controls.Add(label1);
//            tabPage1.Controls.Add(textAddress);
//            tabPage1.Controls.Add(label7);
//            tabPage1.Controls.Add(label6);
//            tabPage1.Controls.Add(checkBox2);
//            tabPage1.Controls.Add(checkBox1);
//            tabPage1.Controls.Add(label5);
//            tabPage1.Controls.Add(label4);
//            tabPage1.Controls.Add(textPosition);
//            tabPage1.Controls.Add(Room);
//            tabPage1.Controls.Add(textRoom);
//            tabPage1.Controls.Add(nameLabel);
//            tabPage1.Controls.Add(textName);
//            tabPage1.Controls.Add(MSNV);
//            tabPage1.Controls.Add(textMSNV);
//            tabPage1.Location = new Point(4, 29);
//            tabPage1.Name = "tabPage1";
//            tabPage1.Padding = new Padding(3);
//            tabPage1.Size = new Size(1062, 524);
//            tabPage1.TabIndex = 0;
//            tabPage1.Text = "Chấm Công";
//            tabPage1.UseVisualStyleBackColor = true;
//            // 
//            // textDateOfBirth
//            // 
//            textDateOfBirth.Location = new Point(335, 327);
//            textDateOfBirth.Name = "textDateOfBirth";
//            textDateOfBirth.Size = new Size(125, 27);
//            textDateOfBirth.TabIndex = 35;
//            // 
//            // buttonKetThucCa
//            // 
//            buttonKetThucCa.Location = new Point(837, 193);
//            buttonKetThucCa.Name = "buttonKetThucCa";
//            buttonKetThucCa.Size = new Size(120, 66);
//            buttonKetThucCa.TabIndex = 34;
//            buttonKetThucCa.Text = "Kết Thúc Ca";
//            buttonKetThucCa.UseVisualStyleBackColor = true;
//            // 
//            // buttonVaoCa
//            // 
//            buttonVaoCa.Location = new Point(644, 193);
//            buttonVaoCa.Name = "buttonVaoCa";
//            buttonVaoCa.Size = new Size(115, 66);
//            buttonVaoCa.TabIndex = 33;
//            buttonVaoCa.Text = "Vào Ca";
//            buttonVaoCa.UseVisualStyleBackColor = true;
//            // 
//            // textPhoneNumber
//            // 
//            textPhoneNumber.Location = new Point(728, 73);
//            textPhoneNumber.Name = "textPhoneNumber";
//            textPhoneNumber.Size = new Size(125, 27);
//            textPhoneNumber.TabIndex = 32;
//            // 
//            // label1
//            // 
//            label1.AutoSize = true;
//            label1.Location = new Point(651, 80);
//            label1.Name = "label1";
//            label1.Size = new Size(36, 20);
//            label1.TabIndex = 31;
//            label1.Text = "SĐT";
//            // 
//            // textAddress
//            // 
//            textAddress.Location = new Point(728, 11);
//            textAddress.Name = "textAddress";
//            textAddress.Size = new Size(241, 27);
//            textAddress.TabIndex = 30;
//            // 
//            // label7
//            // 
//            label7.AutoSize = true;
//            label7.Location = new Point(644, 14);
//            label7.Name = "label7";
//            label7.Size = new Size(57, 20);
//            label7.TabIndex = 29;
//            label7.Text = "Địa Chỉ";
//            // 
//            // label6
//            // 
//            label6.AutoSize = true;
//            label6.Location = new Point(175, 327);
//            label6.Name = "label6";
//            label6.Size = new Size(76, 20);
//            label6.TabIndex = 27;
//            label6.Text = "Ngày Sinh";
//            // 
//            // checkBox2
//            // 
//            checkBox2.AutoSize = true;
//            checkBox2.Location = new Point(409, 259);
//            checkBox2.Name = "checkBox2";
//            checkBox2.Size = new Size(51, 24);
//            checkBox2.TabIndex = 26;
//            checkBox2.Text = "Nữ";
//            checkBox2.UseVisualStyleBackColor = true;
//            // 
//            // checkBox1
//            // 
//            checkBox1.AutoSize = true;
//            checkBox1.Location = new Point(335, 258);
//            checkBox1.Name = "checkBox1";
//            checkBox1.Size = new Size(63, 24);
//            checkBox1.TabIndex = 25;
//            checkBox1.Text = "Nam";
//            checkBox1.UseVisualStyleBackColor = true;
//            // 
//            // label5
//            // 
//            label5.AutoSize = true;
//            label5.Location = new Point(175, 259);
//            label5.Name = "label5";
//            label5.Size = new Size(68, 20);
//            label5.TabIndex = 24;
//            label5.Text = "Giới Tính";
//            // 
//            // label4
//            // 
//            label4.AutoSize = true;
//            label4.Location = new Point(175, 193);
//            label4.Name = "label4";
//            label4.Size = new Size(63, 20);
//            label4.TabIndex = 23;
//            label4.Text = "Chức Vụ";
//            // 
//            // textPosition
//            // 
//            textPosition.Location = new Point(335, 193);
//            textPosition.Name = "textPosition";
//            textPosition.Size = new Size(125, 27);
//            textPosition.TabIndex = 22;
//            // 
//            // Room
//            // 
//            Room.AutoSize = true;
//            Room.Location = new Point(175, 133);
//            Room.Name = "Room";
//            Room.Size = new Size(54, 20);
//            Room.TabIndex = 21;
//            Room.Text = "Phòng";
//            // 
//            // textRoom
//            // 
//            textRoom.Location = new Point(335, 133);
//            textRoom.Name = "textRoom";
//            textRoom.Size = new Size(125, 27);
//            textRoom.TabIndex = 20;
//            // 
//            // nameLabel
//            // 
//            nameLabel.AutoSize = true;
//            nameLabel.Location = new Point(175, 73);
//            nameLabel.Name = "nameLabel";
//            nameLabel.Size = new Size(34, 20);
//            nameLabel.TabIndex = 19;
//            nameLabel.Text = "Tên";
//            // 
//            // textName
//            // 
//            textName.Location = new Point(335, 73);
//            textName.Name = "textName";
//            textName.Size = new Size(125, 27);
//            textName.TabIndex = 18;
//            // 
//            // MSNV
//            // 
//            MSNV.AutoSize = true;
//            MSNV.Location = new Point(175, 14);
//            MSNV.Name = "MSNV";
//            MSNV.Size = new Size(54, 20);
//            MSNV.TabIndex = 17;
//            MSNV.Text = "MSNV";
//            // 
//            // textMSNV
//            // 
//            textMSNV.Location = new Point(335, 11);
//            textMSNV.Name = "textMSNV";
//            textMSNV.Size = new Size(125, 27);
//            textMSNV.TabIndex = 16;
//            // 
//            // Form1
//            // 
//            AutoScaleDimensions = new SizeF(8F, 20F);
//            AutoScaleMode = AutoScaleMode.Font;
//            ClientSize = new Size(1068, 568);
//            Controls.Add(tabControl1);
//            Icon = (Icon)resources.GetObject("$this.Icon");
//            Name = "Form1";
//            Text = "Chấm Công";
//            tabControl1.ResumeLayout(false);
//            tabPage1.ResumeLayout(false);
//            tabPage1.PerformLayout();
//            ResumeLayout(false);
//        }

//        private TabControl tabControl1;
//        private TabPage tabPage1;
//        private TextBox textDateOfBirth;
//        private Button buttonKetThucCa;
//        private Button buttonVaoCa;
//        private TextBox textPhoneNumber;
//        private Label label1;
//        private TextBox textAddress;
//        private Label label7;
//        private Label label6;
//        private CheckBox checkBox2;
//        private CheckBox checkBox1;
//        private Label label5;
//        private Label label4;
//        private TextBox textPosition;
//        private Label Room;
//        private TextBox textRoom;
//        private Label nameLabel;
//        private TextBox textName;
//        private Label MSNV;
//        private TextBox textMSNV;
//        private TabPage tabPage2;
//        private TabPage TabPage3;
//        private TabPage tabPage4;
//    }
//}
//using System.ComponentModel;
//using System.Drawing;
//using System.Windows.Forms;

//namespace AttendanceApp
//{
//    partial class Form1 : Form
//    {
//        private IContainer components = null;
//        private Button btnSaveData;
//        private Button btnLoadData;
//        private TextBox txtName;
//        private TextBox txtPosition;
//        private TextBox txtDepartment;
//        private TextBox txtSalary;
//        private Button btnAddEmployee;
//        private ListBox listBoxEmployees;

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        private void InitializeComponent()
//        {
//            this.btnSaveData = new Button();
//            this.btnLoadData = new Button();
//            this.txtName = new TextBox();
//            this.txtPosition = new TextBox();
//            this.txtDepartment = new TextBox();
//            this.txtSalary = new TextBox();
//            this.btnAddEmployee = new Button();
//            this.listBoxEmployees = new ListBox();
//            this.SuspendLayout();
//            // 
//            // btnSaveData
//            // 
//            this.btnSaveData.Location = new Point(12, 12);
//            this.btnSaveData.Name = "btnSaveData";
//            this.btnSaveData.Size = new Size(75, 23);
//            this.btnSaveData.TabIndex = 0;
//            this.btnSaveData.Text = "Save Data";
//            this.btnSaveData.UseVisualStyleBackColor = true;
//            this.btnSaveData.Click += new EventHandler(this.btnSaveData_Click);
//            // 
//            // btnLoadData
//            // 
//            this.btnLoadData.Location = new Point(93, 12);
//            this.btnLoadData.Name = "btnLoadData";
//            this.btnLoadData.Size = new Size(75, 23);
//            this.btnLoadData.TabIndex = 1;
//            this.btnLoadData.Text = "Load Data";
//            this.btnLoadData.UseVisualStyleBackColor = true;
//            this.btnLoadData.Click += new EventHandler(this.btnLoadData_Click);
//            // 
//            // txtName
//            // 
//            this.txtName.Location = new Point(12, 41);
//            this.txtName.Name = "txtName";
//            this.txtName.Size = new Size(156, 20);
//            this.txtName.TabIndex = 2;
//            // 
//            // txtPosition
//            // 
//            this.txtPosition.Location = new Point(12, 67);
//            this.txtPosition.Name = "txtPosition";
//            this.txtPosition.Size = new Size(156, 20);
//            this.txtPosition.TabIndex = 3;
//            // 
//            // txtDepartment
//            // 
//            this.txtDepartment.Location = new Point(12, 93);
//            this.txtDepartment.Name = "txtDepartment";
//            this.txtDepartment.Size = new Size(156, 20);
//            this.txtDepartment.TabIndex = 4;
//            // 
//            // txtSalary
//            // 
//            this.txtSalary.Location = new Point(12, 119);
//            this.txtSalary.Name = "txtSalary";
//            this.txtSalary.Size = new Size(156, 20);
//            this.txtSalary.TabIndex = 5;
//            // 
//            // btnAddEmployee
//            // 
//            this.btnAddEmployee.Location = new Point(12, 145);
//            this.btnAddEmployee.Name = "btnAddEmployee";
//            this.btnAddEmployee.Size = new Size(156, 23);
//            this.btnAddEmployee.TabIndex = 6;
//            this.btnAddEmployee.Text = "Add Employee";
//            this.btnAddEmployee.UseVisualStyleBackColor = true;
//            this.btnAddEmployee.Click += new EventHandler(this.btnAddEmployee_Click);
//            // 
//            // listBoxEmployees
//            // 
//            this.listBoxEmployees.FormattingEnabled = true;
//            this.listBoxEmployees.Location = new Point(12, 174);
//            this.listBoxEmployees.Name = "listBoxEmployees";
//            this.listBoxEmployees.Size = new Size(156, 95);
//            this.listBoxEmployees.TabIndex = 7;
//            // 
//            // Form1
//            // 
//            this.ClientSize = new Size(234, 291);
//            this.Controls.Add(this.listBoxEmployees);
//            this.Controls.Add(this.btnAddEmployee);
//            this.Controls.Add(this.txtSalary);
//            this.Controls.Add(this.txtDepartment);
//            this.Controls.Add(this.txtPosition);
//            this.Controls.Add(this.txtName);
//            this.Controls.Add(this.btnLoadData);
//            this.Controls.Add(this.btnSaveData);
//            this.Name = "Form1";
//            this.Text = "Attendance System";
//            this.ResumeLayout(false);
//            this.PerformLayout();
//        }
//    }
//}
//using System.ComponentModel;
//using System.Drawing;
//using System.Windows.Forms;

//namespace AttendanceApp
//{
//    partial class Form1 : Form
//    {
//        private IContainer components = null;
//        private Button btnSaveData;
//        private Button btnLoadData;
//        private TextBox txtName;
//        private TextBox txtPosition;
//        private TextBox txtDepartment;
//        private TextBox txtSalary;
//        private Button btnAddEmployee;
//        private ListBox listBoxEmployees;

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        private void InitializeComponent()
//        {
//            this.btnSaveData = new Button();
//            this.btnLoadData = new Button();
//            this.txtName = new TextBox();
//            this.txtPosition = new TextBox();
//            this.txtDepartment = new TextBox();
//            this.txtSalary = new TextBox();
//            this.btnAddEmployee = new Button();
//            this.listBoxEmployees = new ListBox();
//            this.SuspendLayout();

//            // btnSaveData
//            this.btnSaveData.Location = new Point(20, 20);
//            this.btnSaveData.Name = "btnSaveData";
//            this.btnSaveData.Size = new Size(100, 30);
//            this.btnSaveData.TabIndex = 0;
//            this.btnSaveData.Text = "Save Data";
//            this.btnSaveData.UseVisualStyleBackColor = true;
//            this.btnSaveData.Click += new EventHandler(this.btnSaveData_Click);

//            // btnLoadData
//            this.btnLoadData.Location = new Point(130, 20);
//            this.btnLoadData.Name = "btnLoadData";
//            this.btnLoadData.Size = new Size(100, 30);
//            this.btnLoadData.TabIndex = 1;
//            this.btnLoadData.Text = "Load Data";
//            this.btnLoadData.UseVisualStyleBackColor = true;
//            this.btnLoadData.Click += new EventHandler(this.btnLoadData_Click);

//            // txtName
//            this.txtName.Location = new Point(20, 70);
//            this.txtName.Name = "txtName";
//            this.txtName.Size = new Size(250, 30);
//            this.txtName.TabIndex = 2;
//            this.txtName.Font = new Font("Arial", 10);
//            this.txtName.PlaceholderText = "Name";

//            // txtPosition
//            this.txtPosition.Location = new Point(20, 110);
//            this.txtPosition.Name = "txtPosition";
//            this.txtPosition.Size = new Size(250, 30);
//            this.txtPosition.TabIndex = 3;
//            this.txtPosition.Font = new Font("Arial", 10);
//            this.txtPosition.PlaceholderText = "Position";

//            // txtDepartment
//            this.txtDepartment.Location = new Point(20, 150);
//            this.txtDepartment.Name = "txtDepartment";
//            this.txtDepartment.Size = new Size(250, 30);
//            this.txtDepartment.TabIndex = 4;
//            this.txtDepartment.Font = new Font("Arial", 10);
//            this.txtDepartment.PlaceholderText = "Department";

//            // txtSalary
//            this.txtSalary.Location = new Point(20, 190);
//            this.txtSalary.Name = "txtSalary";
//            this.txtSalary.Size = new Size(250, 30);
//            this.txtSalary.TabIndex = 5;
//            this.txtSalary.Font = new Font("Arial", 10);
//            this.txtSalary.PlaceholderText = "Salary";

//            // btnAddEmployee
//            this.btnAddEmployee.Location = new Point(20, 230);
//            this.btnAddEmployee.Name = "btnAddEmployee";
//            this.btnAddEmployee.Size = new Size(250, 30);
//            this.btnAddEmployee.TabIndex = 6;
//            this.btnAddEmployee.Text = "Add Employee";
//            this.btnAddEmployee.UseVisualStyleBackColor = true;
//            this.btnAddEmployee.Click += new EventHandler(this.btnAddEmployee_Click);

//            // listBoxEmployees
//            this.listBoxEmployees.Location = new Point(300, 20);
//            this.listBoxEmployees.Name = "listBoxEmployees";
//            this.listBoxEmployees.Size = new Size(200, 400);
//            this.listBoxEmployees.TabIndex = 7;
//            this.listBoxEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

//            // Form1
//            this.ClientSize = new Size(550, 450);
//            this.Controls.Add(this.listBoxEmployees);
//            this.Controls.Add(this.btnAddEmployee);
//            this.Controls.Add(this.txtSalary);
//            this.Controls.Add(this.txtDepartment);
//            this.Controls.Add(this.txtPosition);
//            this.Controls.Add(this.txtName);
//            this.Controls.Add(this.btnLoadData);
//            this.Controls.Add(this.btnSaveData);
//            this.Name = "Form1";
//            this.Text = "Attendance System";
//            this.StartPosition = FormStartPosition.CenterScreen;
//            this.ResumeLayout(false);
//            this.PerformLayout();
//        }
//    }
//}
using System.Windows.Forms;

namespace WinFormsApp6
{
    partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            labelEmployeeId = new Label();
            textBoxEmployeeId = new TextBox();
            labelFullName = new Label();
            textBoxFullName = new TextBox();
            labelDepartment = new Label();
            textBoxDepartment = new TextBox();
            labelPosition = new Label();
            textBoxPosition = new TextBox();
            labelGender = new Label();
            radioButtonMale = new RadioButton();
            radioButtonFemale = new RadioButton();
            labelDateOfBirth = new Label();
            textBoxDateOfBirth = new TextBox();
            buttonStartShift = new Button();
            buttonEndShift = new Button();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            ColID = new DataGridViewTextBoxColumn();
            ColFullName = new DataGridViewTextBoxColumn();
            ColDepartment = new DataGridViewTextBoxColumn();
            ColPosition = new DataGridViewTextBoxColumn();
            ColGender = new DataGridViewTextBoxColumn();
            ColDateOfBirth = new DataGridViewTextBoxColumn();
            ColStartShift = new DataGridViewTextBoxColumn();
            ColEndShift = new DataGridViewTextBoxColumn();
            tabBangLuong = new TabPage();
            lblTotalShifts = new Label();
            lblNhapMaNV = new Label();
            txtEmployeeId = new TextBox();
            btnXemLuong = new Button();
            lblSalary = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabBangLuong.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabBangLuong);
            tabControl1.Location = new Point(-1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1232, 486);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(labelEmployeeId);
            tabPage1.Controls.Add(textBoxEmployeeId);
            tabPage1.Controls.Add(labelFullName);
            tabPage1.Controls.Add(textBoxFullName);
            tabPage1.Controls.Add(labelDepartment);
            tabPage1.Controls.Add(textBoxDepartment);
            tabPage1.Controls.Add(labelPosition);
            tabPage1.Controls.Add(textBoxPosition);
            tabPage1.Controls.Add(labelGender);
            tabPage1.Controls.Add(radioButtonMale);
            tabPage1.Controls.Add(radioButtonFemale);
            tabPage1.Controls.Add(labelDateOfBirth);
            tabPage1.Controls.Add(textBoxDateOfBirth);
            tabPage1.Controls.Add(buttonStartShift);
            tabPage1.Controls.Add(buttonEndShift);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1224, 453);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Chấm Công";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelEmployeeId
            // 
            labelEmployeeId.Location = new Point(21, 29);
            labelEmployeeId.Name = "labelEmployeeId";
            labelEmployeeId.Size = new Size(130, 20);
            labelEmployeeId.TabIndex = 15;
            labelEmployeeId.Text = "Mã Số Nhân Viên";
            // 
            // textBoxEmployeeId
            // 
            textBoxEmployeeId.Location = new Point(186, 26);
            textBoxEmployeeId.Name = "textBoxEmployeeId";
            textBoxEmployeeId.Size = new Size(200, 27);
            textBoxEmployeeId.TabIndex = 16;
            // 
            // labelFullName
            // 
            labelFullName.Location = new Point(21, 69);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(161, 20);
            labelFullName.TabIndex = 17;
            labelFullName.Text = "Họ Và Tên Nhân Viên";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(186, 66);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(200, 27);
            textBoxFullName.TabIndex = 18;
            // 
            // labelDepartment
            // 
            labelDepartment.Location = new Point(21, 109);
            labelDepartment.Name = "labelDepartment";
            labelDepartment.Size = new Size(100, 20);
            labelDepartment.TabIndex = 19;
            labelDepartment.Text = "Phòng Ban";
            // 
            // textBoxDepartment
            // 
            textBoxDepartment.Location = new Point(186, 106);
            textBoxDepartment.Name = "textBoxDepartment";
            textBoxDepartment.Size = new Size(200, 27);
            textBoxDepartment.TabIndex = 20;
            // 
            // labelPosition
            // 
            labelPosition.Location = new Point(21, 149);
            labelPosition.Name = "labelPosition";
            labelPosition.Size = new Size(100, 20);
            labelPosition.TabIndex = 21;
            labelPosition.Text = "Chức Vụ";
            // 
            // textBoxPosition
            // 
            textBoxPosition.Location = new Point(186, 149);
            textBoxPosition.Name = "textBoxPosition";
            textBoxPosition.Size = new Size(200, 27);
            textBoxPosition.TabIndex = 22;
            // 
            // labelGender
            // 
            labelGender.Location = new Point(21, 189);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(100, 20);
            labelGender.TabIndex = 23;
            labelGender.Text = "Giới Tính";
            // 
            // radioButtonMale
            // 
            radioButtonMale.Location = new Point(204, 189);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(67, 20);
            radioButtonMale.TabIndex = 24;
            radioButtonMale.Text = "Nam";
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.Location = new Point(321, 189);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(50, 20);
            radioButtonFemale.TabIndex = 25;
            radioButtonFemale.Text = "Nữ";
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.Location = new Point(21, 229);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(100, 20);
            labelDateOfBirth.TabIndex = 26;
            labelDateOfBirth.Text = "Ngày Sinh";
            // 
            // textBoxDateOfBirth
            // 
            textBoxDateOfBirth.Location = new Point(186, 229);
            textBoxDateOfBirth.Name = "textBoxDateOfBirth";
            textBoxDateOfBirth.Size = new Size(200, 27);
            textBoxDateOfBirth.TabIndex = 27;
            // 
            // buttonStartShift
            // 
            buttonStartShift.Location = new Point(148, 303);
            buttonStartShift.Name = "buttonStartShift";
            buttonStartShift.Size = new Size(100, 30);
            buttonStartShift.TabIndex = 28;
            buttonStartShift.Text = "Vào Ca";
            buttonStartShift.Click += buttonStartShift_Click;
            // 
            // buttonEndShift
            // 
            buttonEndShift.Location = new Point(286, 303);
            buttonEndShift.Name = "buttonEndShift";
            buttonEndShift.Size = new Size(100, 30);
            buttonEndShift.TabIndex = 29;
            buttonEndShift.Text = "Kết Thúc Ca";
            buttonEndShift.Click += buttonEndShift_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1224, 453);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Bảng Chấm Công";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColID, ColFullName, ColDepartment, ColPosition, ColGender, ColDateOfBirth, ColStartShift, ColEndShift });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 50;
            dataGridView1.Size = new Size(1208, 453);
            dataGridView1.TabIndex = 0;
            // 
            // ColID
            // 
            ColID.HeaderText = "ID";
            ColID.MinimumWidth = 6;
            ColID.Name = "ColID";
            ColID.Width = 125;
            // 
            // ColFullName
            // 
            ColFullName.HeaderText = "Họ và tên";
            ColFullName.MinimumWidth = 6;
            ColFullName.Name = "ColFullName";
            ColFullName.Width = 160;
            // 
            // ColDepartment
            // 
            ColDepartment.HeaderText = "Phòng ban";
            ColDepartment.MinimumWidth = 6;
            ColDepartment.Name = "ColDepartment";
            ColDepartment.Width = 150;
            // 
            // ColPosition
            // 
            ColPosition.HeaderText = "Chức vụ";
            ColPosition.MinimumWidth = 6;
            ColPosition.Name = "ColPosition";
            ColPosition.Width = 200;
            // 
            // ColGender
            // 
            ColGender.HeaderText = "Giới tính";
            ColGender.MinimumWidth = 6;
            ColGender.Name = "ColGender";
            ColGender.Width = 80;
            // 
            // ColDateOfBirth
            // 
            ColDateOfBirth.HeaderText = "Ngày sinh";
            ColDateOfBirth.MinimumWidth = 6;
            ColDateOfBirth.Name = "ColDateOfBirth";
            ColDateOfBirth.Width = 100;
            // 
            // ColStartShift
            // 
            ColStartShift.HeaderText = "Vào ca";
            ColStartShift.MinimumWidth = 6;
            ColStartShift.Name = "ColStartShift";
            ColStartShift.Width = 170;
            // 
            // ColEndShift
            // 
            ColEndShift.HeaderText = "Kết thúc ca";
            ColEndShift.MinimumWidth = 6;
            ColEndShift.Name = "ColEndShift";
            ColEndShift.Width = 170;
            // 
            // tabBangLuong
            // 
            tabBangLuong.Controls.Add(lblTotalShifts);
            tabBangLuong.Controls.Add(lblNhapMaNV);
            tabBangLuong.Controls.Add(txtEmployeeId);
            tabBangLuong.Controls.Add(btnXemLuong);
            tabBangLuong.Controls.Add(lblSalary);
            tabBangLuong.Location = new Point(4, 29);
            tabBangLuong.Name = "tabBangLuong";
            tabBangLuong.Size = new Size(1224, 453);
            tabBangLuong.TabIndex = 0;
            tabBangLuong.Text = "Bảng Lương";
            // 
            // lblTotalShifts
            // 
            lblTotalShifts.AutoSize = true;
            lblTotalShifts.Location = new Point(30, 98);
            lblTotalShifts.Name = "lblTotalShifts";
            lblTotalShifts.Size = new Size(99, 20);
            lblTotalShifts.TabIndex = 4;
            lblTotalShifts.Text = "Số ngày công";
            // 
            // lblNhapMaNV
            // 
            lblNhapMaNV.Location = new Point(29, 33);
            lblNhapMaNV.Name = "lblNhapMaNV";
            lblNhapMaNV.Size = new Size(100, 23);
            lblNhapMaNV.TabIndex = 0;
            lblNhapMaNV.Text = "Nhập mã nhân viên:";
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Location = new Point(150, 30);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(200, 27);
            txtEmployeeId.TabIndex = 1;
            // 
            // btnXemLuong
            // 
            btnXemLuong.Location = new Point(370, 30);
            btnXemLuong.Name = "btnXemLuong";
            btnXemLuong.Size = new Size(75, 27);
            btnXemLuong.TabIndex = 2;
            btnXemLuong.Text = "Xem Lương";
            btnXemLuong.Click += btnXemLuong_Click;
            // 
            // lblSalary
            // 
            lblSalary.Location = new Point(29, 145);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(400, 23);
            lblSalary.TabIndex = 3;
            lblSalary.Text = "Lương tháng sẽ hiển thị tại đây";
            // 
            // Form1
            // 
            ClientSize = new Size(1231, 480);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Chấm Công";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabBangLuong.ResumeLayout(false);
            tabBangLuong.PerformLayout();
            ResumeLayout(false);
        }

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label labelEmployeeId;
        private TextBox textBoxEmployeeId;
        private Label labelFullName;
        private TextBox textBoxFullName;
        private Label labelDepartment;
        private TextBox textBoxDepartment;
        private Label labelPosition;
        private TextBox textBoxPosition;
        private Label labelGender;
        private RadioButton radioButtonMale;
        private RadioButton radioButtonFemale;
        private Label labelDateOfBirth;
        private TextBox textBoxDateOfBirth;
        private Button buttonStartShift;
        private Button buttonEndShift;
        private TabPage tabPage2;
        private TabPage tabBangLuong;
        private Label lblNhapMaNV;
        private TextBox txtEmployeeId;
        private Button btnXemLuong;
        private Label lblSalary;
        private Button btnLuu;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colDepartment;
        private DataGridViewTextBoxColumn colPosition;
        private DataGridViewTextBoxColumn colGender;
        private DataGridViewTextBoxColumn colDateOfBirth;
        private DataGridViewTextBoxColumn colStartShift;
        private DataGridViewTextBoxColumn colEndShift;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn ColFullName;
        private DataGridViewTextBoxColumn ColDepartment;
        private DataGridViewTextBoxColumn ColPosition;
        private DataGridViewTextBoxColumn ColGender;
        private DataGridViewTextBoxColumn ColDateOfBirth;
        private DataGridViewTextBoxColumn ColStartShift;
        private DataGridViewTextBoxColumn ColEndShift;
        private Label lblTotalShifts;
    }
}
