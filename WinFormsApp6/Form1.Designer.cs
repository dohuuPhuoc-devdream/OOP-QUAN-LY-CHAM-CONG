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
