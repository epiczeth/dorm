using System.ComponentModel;
using System.Windows.Forms;
using somchit.RenterDataSetTableAdapters;

namespace somchit.GUI
{
    partial class Renter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label r_idLabel;
            System.Windows.Forms.Label r_namelastLabel;
            System.Windows.Forms.Label r_ageLabel;
            System.Windows.Forms.Label r_sexLabel;
            System.Windows.Forms.Label r_occuLabel;
            System.Windows.Forms.Label r_telLabel;
            System.Windows.Forms.Label r_pidLabel;
            System.Windows.Forms.Label r_issuedateLabel;
            System.Windows.Forms.Label r_expdateLabel;
            System.Windows.Forms.Label r_issueplaceLabel;
            System.Windows.Forms.Label r_hnumberLabel;
            System.Windows.Forms.Label r_mooLabel;
            System.Windows.Forms.Label r_soiLabel;
            System.Windows.Forms.Label r_roadLabel;
            System.Windows.Forms.Label r_tambonLabel;
            System.Windows.Forms.Label r_districtLabel;
            System.Windows.Forms.Label r_provinceLabel;
            System.Windows.Forms.Label r_postalcodeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Renter));
            this.renterDataSet = new somchit.RenterDataSet();
            this.rentersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentersTableAdapter = new somchit.RenterDataSetTableAdapters.RentersTableAdapter();
            this.tableAdapterManager = new somchit.RenterDataSetTableAdapters.TableAdapterManager();
            this.rentersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rentersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.r_idLabel1 = new System.Windows.Forms.Label();
            this.r_namelastTextBox = new System.Windows.Forms.TextBox();
            this.r_ageTextBox = new System.Windows.Forms.TextBox();
            this.r_sexComboBox = new System.Windows.Forms.ComboBox();
            this.r_occuTextBox = new System.Windows.Forms.TextBox();
            this.r_telTextBox = new System.Windows.Forms.TextBox();
            this.r_pidTextBox = new System.Windows.Forms.TextBox();
            this.r_issuedateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.r_expdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.r_issueplaceTextBox = new System.Windows.Forms.TextBox();
            this.r_hnumberTextBox = new System.Windows.Forms.TextBox();
            this.r_mooTextBox = new System.Windows.Forms.TextBox();
            this.r_soiTextBox = new System.Windows.Forms.TextBox();
            this.r_roadTextBox = new System.Windows.Forms.TextBox();
            this.r_tambonTextBox = new System.Windows.Forms.TextBox();
            this.r_districtTextBox = new System.Windows.Forms.TextBox();
            this.r_provinceTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.r_postalcodeTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            r_idLabel = new System.Windows.Forms.Label();
            r_namelastLabel = new System.Windows.Forms.Label();
            r_ageLabel = new System.Windows.Forms.Label();
            r_sexLabel = new System.Windows.Forms.Label();
            r_occuLabel = new System.Windows.Forms.Label();
            r_telLabel = new System.Windows.Forms.Label();
            r_pidLabel = new System.Windows.Forms.Label();
            r_issuedateLabel = new System.Windows.Forms.Label();
            r_expdateLabel = new System.Windows.Forms.Label();
            r_issueplaceLabel = new System.Windows.Forms.Label();
            r_hnumberLabel = new System.Windows.Forms.Label();
            r_mooLabel = new System.Windows.Forms.Label();
            r_soiLabel = new System.Windows.Forms.Label();
            r_roadLabel = new System.Windows.Forms.Label();
            r_tambonLabel = new System.Windows.Forms.Label();
            r_districtLabel = new System.Windows.Forms.Label();
            r_provinceLabel = new System.Windows.Forms.Label();
            r_postalcodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.renterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentersBindingNavigator)).BeginInit();
            this.rentersBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // r_idLabel
            // 
            r_idLabel.AutoSize = true;
            r_idLabel.Location = new System.Drawing.Point(23, 29);
            r_idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            r_idLabel.Name = "r_idLabel";
            r_idLabel.Size = new System.Drawing.Size(66, 18);
            r_idLabel.TabIndex = 1;
            r_idLabel.Text = "รหัสผู้เช่า :";
            // 
            // r_namelastLabel
            // 
            r_namelastLabel.AutoSize = true;
            r_namelastLabel.Location = new System.Drawing.Point(23, 69);
            r_namelastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            r_namelastLabel.Name = "r_namelastLabel";
            r_namelastLabel.Size = new System.Drawing.Size(68, 18);
            r_namelastLabel.TabIndex = 3;
            r_namelastLabel.Text = "ชื่อ - สกุล :";
            // 
            // r_ageLabel
            // 
            r_ageLabel.AutoSize = true;
            r_ageLabel.Location = new System.Drawing.Point(23, 105);
            r_ageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            r_ageLabel.Name = "r_ageLabel";
            r_ageLabel.Size = new System.Drawing.Size(38, 18);
            r_ageLabel.TabIndex = 5;
            r_ageLabel.Text = "อายุ :";
            // 
            // r_sexLabel
            // 
            r_sexLabel.AutoSize = true;
            r_sexLabel.Location = new System.Drawing.Point(23, 141);
            r_sexLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            r_sexLabel.Name = "r_sexLabel";
            r_sexLabel.Size = new System.Drawing.Size(38, 18);
            r_sexLabel.TabIndex = 7;
            r_sexLabel.Text = "เพศ :";
            // 
            // r_occuLabel
            // 
            r_occuLabel.AutoSize = true;
            r_occuLabel.Location = new System.Drawing.Point(23, 178);
            r_occuLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            r_occuLabel.Name = "r_occuLabel";
            r_occuLabel.Size = new System.Drawing.Size(48, 18);
            r_occuLabel.TabIndex = 9;
            r_occuLabel.Text = "อาชีพ :";
            // 
            // r_telLabel
            // 
            r_telLabel.AutoSize = true;
            r_telLabel.Location = new System.Drawing.Point(23, 214);
            r_telLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            r_telLabel.Name = "r_telLabel";
            r_telLabel.Size = new System.Drawing.Size(66, 18);
            r_telLabel.TabIndex = 11;
            r_telLabel.Text = "เบอร์โทร :";
            // 
            // r_pidLabel
            // 
            r_pidLabel.AutoSize = true;
            r_pidLabel.Location = new System.Drawing.Point(374, 70);
            r_pidLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            r_pidLabel.Name = "r_pidLabel";
            r_pidLabel.Size = new System.Drawing.Size(86, 18);
            r_pidLabel.TabIndex = 13;
            r_pidLabel.Text = "เลขประจำตัว :";
            // 
            // r_issuedateLabel
            // 
            r_issuedateLabel.AutoSize = true;
            r_issuedateLabel.Location = new System.Drawing.Point(374, 108);
            r_issuedateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            r_issuedateLabel.Name = "r_issuedateLabel";
            r_issuedateLabel.Size = new System.Drawing.Size(89, 18);
            r_issuedateLabel.TabIndex = 15;
            r_issuedateLabel.Text = "วันที่ออกบัตร :";
            // 
            // r_expdateLabel
            // 
            r_expdateLabel.AutoSize = true;
            r_expdateLabel.Location = new System.Drawing.Point(374, 144);
            r_expdateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            r_expdateLabel.Name = "r_expdateLabel";
            r_expdateLabel.Size = new System.Drawing.Size(80, 18);
            r_expdateLabel.TabIndex = 17;
            r_expdateLabel.Text = "วันหมดอายุ :";
            // 
            // r_issueplaceLabel
            // 
            r_issueplaceLabel.AutoSize = true;
            r_issueplaceLabel.Location = new System.Drawing.Point(374, 178);
            r_issueplaceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            r_issueplaceLabel.Name = "r_issueplaceLabel";
            r_issueplaceLabel.Size = new System.Drawing.Size(104, 18);
            r_issueplaceLabel.TabIndex = 19;
            r_issueplaceLabel.Text = "สถานที่ออกบัตร :";
            // 
            // r_hnumberLabel
            // 
            r_hnumberLabel.AutoSize = true;
            r_hnumberLabel.Location = new System.Drawing.Point(26, 28);
            r_hnumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            r_hnumberLabel.Name = "r_hnumberLabel";
            r_hnumberLabel.Size = new System.Drawing.Size(68, 18);
            r_hnumberLabel.TabIndex = 21;
            r_hnumberLabel.Text = "บ้านเลขที่ :";
            // 
            // r_mooLabel
            // 
            r_mooLabel.AutoSize = true;
            r_mooLabel.Location = new System.Drawing.Point(26, 64);
            r_mooLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            r_mooLabel.Name = "r_mooLabel";
            r_mooLabel.Size = new System.Drawing.Size(34, 18);
            r_mooLabel.TabIndex = 23;
            r_mooLabel.Text = "หมู่ :";
            // 
            // r_soiLabel
            // 
            r_soiLabel.AutoSize = true;
            r_soiLabel.Location = new System.Drawing.Point(26, 100);
            r_soiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            r_soiLabel.Name = "r_soiLabel";
            r_soiLabel.Size = new System.Drawing.Size(76, 18);
            r_soiLabel.TabIndex = 25;
            r_soiLabel.Text = "ตรอก/ซอย :";
            // 
            // r_roadLabel
            // 
            r_roadLabel.AutoSize = true;
            r_roadLabel.Location = new System.Drawing.Point(26, 136);
            r_roadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            r_roadLabel.Name = "r_roadLabel";
            r_roadLabel.Size = new System.Drawing.Size(42, 18);
            r_roadLabel.TabIndex = 27;
            r_roadLabel.Text = "ถนน :";
            // 
            // r_tambonLabel
            // 
            r_tambonLabel.AutoSize = true;
            r_tambonLabel.Location = new System.Drawing.Point(374, 29);
            r_tambonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            r_tambonLabel.Name = "r_tambonLabel";
            r_tambonLabel.Size = new System.Drawing.Size(46, 18);
            r_tambonLabel.TabIndex = 29;
            r_tambonLabel.Text = "ตำบล :";
            // 
            // r_districtLabel
            // 
            r_districtLabel.AutoSize = true;
            r_districtLabel.Location = new System.Drawing.Point(374, 65);
            r_districtLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            r_districtLabel.Name = "r_districtLabel";
            r_districtLabel.Size = new System.Drawing.Size(51, 18);
            r_districtLabel.TabIndex = 31;
            r_districtLabel.Text = "อำเภอ :";
            // 
            // r_provinceLabel
            // 
            r_provinceLabel.AutoSize = true;
            r_provinceLabel.Location = new System.Drawing.Point(374, 101);
            r_provinceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            r_provinceLabel.Name = "r_provinceLabel";
            r_provinceLabel.Size = new System.Drawing.Size(53, 18);
            r_provinceLabel.TabIndex = 33;
            r_provinceLabel.Text = "จังหวัด :";
            // 
            // r_postalcodeLabel
            // 
            r_postalcodeLabel.AutoSize = true;
            r_postalcodeLabel.Location = new System.Drawing.Point(374, 136);
            r_postalcodeLabel.Name = "r_postalcodeLabel";
            r_postalcodeLabel.Size = new System.Drawing.Size(92, 18);
            r_postalcodeLabel.TabIndex = 34;
            r_postalcodeLabel.Text = "รหัสไปรษณีย์ :";
            // 
            // renterDataSet
            // 
            this.renterDataSet.DataSetName = "RenterDataSet";
            this.renterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentersBindingSource
            // 
            this.rentersBindingSource.DataMember = "Renters";
            this.rentersBindingSource.DataSource = this.renterDataSet;
            // 
            // rentersTableAdapter
            // 
            this.rentersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RentersTableAdapter = this.rentersTableAdapter;
            this.tableAdapterManager.UpdateOrder = somchit.RenterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rentersBindingNavigator
            // 
            this.rentersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rentersBindingNavigator.AutoSize = false;
            this.rentersBindingNavigator.BindingSource = this.rentersBindingSource;
            this.rentersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rentersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rentersBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rentersBindingNavigator.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rentersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.rentersBindingNavigatorSaveItem});
            this.rentersBindingNavigator.Location = new System.Drawing.Point(0, 473);
            this.rentersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rentersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rentersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rentersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rentersBindingNavigator.Name = "rentersBindingNavigator";
            this.rentersBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.rentersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rentersBindingNavigator.Size = new System.Drawing.Size(744, 46);
            this.rentersBindingNavigator.TabIndex = 0;
            this.rentersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(51, 43);
            this.bindingNavigatorAddNewItem.Text = "เพิ่ม";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 43);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(44, 43);
            this.bindingNavigatorDeleteItem.Text = "ลบ";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 43);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 43);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 46);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 46);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 43);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 43);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 46);
            // 
            // rentersBindingNavigatorSaveItem
            // 
            this.rentersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rentersBindingNavigatorSaveItem.Image")));
            this.rentersBindingNavigatorSaveItem.Name = "rentersBindingNavigatorSaveItem";
            this.rentersBindingNavigatorSaveItem.Size = new System.Drawing.Size(63, 43);
            this.rentersBindingNavigatorSaveItem.Text = "บันทึก";
            this.rentersBindingNavigatorSaveItem.Click += new System.EventHandler(this.rentersBindingNavigatorSaveItem_Click);
            // 
            // r_idLabel1
            // 
            this.r_idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentersBindingSource, "r_id", true));
            this.r_idLabel1.Location = new System.Drawing.Point(131, 29);
            this.r_idLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.r_idLabel1.Name = "r_idLabel1";
            this.r_idLabel1.Size = new System.Drawing.Size(213, 32);
            this.r_idLabel1.TabIndex = 2;
            this.r_idLabel1.Text = "label1";
            // 
            // r_namelastTextBox
            // 
            this.r_namelastTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentersBindingSource, "r_namelast", true));
            this.r_namelastTextBox.Location = new System.Drawing.Point(131, 65);
            this.r_namelastTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.r_namelastTextBox.Name = "r_namelastTextBox";
            this.r_namelastTextBox.Size = new System.Drawing.Size(213, 24);
            this.r_namelastTextBox.TabIndex = 4;
            // 
            // r_ageTextBox
            // 
            this.r_ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentersBindingSource, "r_age", true));
            this.r_ageTextBox.Location = new System.Drawing.Point(131, 101);
            this.r_ageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.r_ageTextBox.Name = "r_ageTextBox";
            this.r_ageTextBox.Size = new System.Drawing.Size(95, 24);
            this.r_ageTextBox.TabIndex = 6;
            this.r_ageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.r_ageTextBox_KeyPress);
            // 
            // r_sexComboBox
            // 
            this.r_sexComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentersBindingSource, "r_sex", true));
            this.r_sexComboBox.FormattingEnabled = true;
            this.r_sexComboBox.Items.AddRange(new object[] {
            "ชาย",
            "หญิง"});
            this.r_sexComboBox.Location = new System.Drawing.Point(131, 137);
            this.r_sexComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.r_sexComboBox.Name = "r_sexComboBox";
            this.r_sexComboBox.Size = new System.Drawing.Size(95, 26);
            this.r_sexComboBox.TabIndex = 8;
            // 
            // r_occuTextBox
            // 
            this.r_occuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentersBindingSource, "r_occu", true));
            this.r_occuTextBox.Location = new System.Drawing.Point(131, 174);
            this.r_occuTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.r_occuTextBox.Name = "r_occuTextBox";
            this.r_occuTextBox.Size = new System.Drawing.Size(213, 24);
            this.r_occuTextBox.TabIndex = 10;
            // 
            // r_telTextBox
            // 
            this.r_telTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentersBindingSource, "r_tel", true));
            this.r_telTextBox.Location = new System.Drawing.Point(131, 210);
            this.r_telTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.r_telTextBox.Name = "r_telTextBox";
            this.r_telTextBox.Size = new System.Drawing.Size(213, 24);
            this.r_telTextBox.TabIndex = 12;
            this.r_telTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.r_telTextBox_KeyPress);
            // 
            // r_pidTextBox
            // 
            this.r_pidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentersBindingSource, "r_pid", true));
            this.r_pidTextBox.Location = new System.Drawing.Point(482, 66);
            this.r_pidTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.r_pidTextBox.Name = "r_pidTextBox";
            this.r_pidTextBox.Size = new System.Drawing.Size(213, 24);
            this.r_pidTextBox.TabIndex = 14;
            this.r_pidTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.r_pidTextBox_KeyDown);
            this.r_pidTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.r_pidTextBox_KeyPress);
            // 
            // r_issuedateDateTimePicker
            // 
            this.r_issuedateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rentersBindingSource, "r_issuedate", true));
            this.r_issuedateDateTimePicker.Location = new System.Drawing.Point(482, 102);
            this.r_issuedateDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.r_issuedateDateTimePicker.Name = "r_issuedateDateTimePicker";
            this.r_issuedateDateTimePicker.Size = new System.Drawing.Size(213, 24);
            this.r_issuedateDateTimePicker.TabIndex = 16;
            // 
            // r_expdateDateTimePicker
            // 
            this.r_expdateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rentersBindingSource, "r_expdate", true));
            this.r_expdateDateTimePicker.Location = new System.Drawing.Point(482, 138);
            this.r_expdateDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.r_expdateDateTimePicker.Name = "r_expdateDateTimePicker";
            this.r_expdateDateTimePicker.Size = new System.Drawing.Size(213, 24);
            this.r_expdateDateTimePicker.TabIndex = 18;
            // 
            // r_issueplaceTextBox
            // 
            this.r_issueplaceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentersBindingSource, "r_issueplace", true));
            this.r_issueplaceTextBox.Location = new System.Drawing.Point(482, 174);
            this.r_issueplaceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.r_issueplaceTextBox.Name = "r_issueplaceTextBox";
            this.r_issueplaceTextBox.Size = new System.Drawing.Size(213, 24);
            this.r_issueplaceTextBox.TabIndex = 20;
            // 
            // r_hnumberTextBox
            // 
            this.r_hnumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentersBindingSource, "r_hnumber", true));
            this.r_hnumberTextBox.Location = new System.Drawing.Point(134, 24);
            this.r_hnumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.r_hnumberTextBox.Name = "r_hnumberTextBox";
            this.r_hnumberTextBox.Size = new System.Drawing.Size(213, 24);
            this.r_hnumberTextBox.TabIndex = 22;
            this.r_hnumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.r_hnumberTextBox_KeyPress);
            // 
            // r_mooTextBox
            // 
            this.r_mooTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentersBindingSource, "r_moo", true));
            this.r_mooTextBox.Location = new System.Drawing.Point(134, 60);
            this.r_mooTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.r_mooTextBox.Name = "r_mooTextBox";
            this.r_mooTextBox.Size = new System.Drawing.Size(213, 24);
            this.r_mooTextBox.TabIndex = 24;
            this.r_mooTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.r_mooTextBox_KeyPress);
            // 
            // r_soiTextBox
            // 
            this.r_soiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentersBindingSource, "r_soi", true));
            this.r_soiTextBox.Location = new System.Drawing.Point(134, 96);
            this.r_soiTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.r_soiTextBox.Name = "r_soiTextBox";
            this.r_soiTextBox.Size = new System.Drawing.Size(213, 24);
            this.r_soiTextBox.TabIndex = 26;
            // 
            // r_roadTextBox
            // 
            this.r_roadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentersBindingSource, "r_road", true));
            this.r_roadTextBox.Location = new System.Drawing.Point(134, 132);
            this.r_roadTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.r_roadTextBox.Name = "r_roadTextBox";
            this.r_roadTextBox.Size = new System.Drawing.Size(213, 24);
            this.r_roadTextBox.TabIndex = 28;
            // 
            // r_tambonTextBox
            // 
            this.r_tambonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentersBindingSource, "r_tambon", true));
            this.r_tambonTextBox.Location = new System.Drawing.Point(482, 25);
            this.r_tambonTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.r_tambonTextBox.Name = "r_tambonTextBox";
            this.r_tambonTextBox.Size = new System.Drawing.Size(213, 24);
            this.r_tambonTextBox.TabIndex = 30;
            // 
            // r_districtTextBox
            // 
            this.r_districtTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentersBindingSource, "r_district", true));
            this.r_districtTextBox.Location = new System.Drawing.Point(482, 61);
            this.r_districtTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.r_districtTextBox.Name = "r_districtTextBox";
            this.r_districtTextBox.Size = new System.Drawing.Size(213, 24);
            this.r_districtTextBox.TabIndex = 32;
            // 
            // r_provinceTextBox
            // 
            this.r_provinceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentersBindingSource, "r_province", true));
            this.r_provinceTextBox.Location = new System.Drawing.Point(482, 97);
            this.r_provinceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.r_provinceTextBox.Name = "r_provinceTextBox";
            this.r_provinceTextBox.Size = new System.Drawing.Size(213, 24);
            this.r_provinceTextBox.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(r_pidLabel);
            this.groupBox1.Controls.Add(r_idLabel);
            this.groupBox1.Controls.Add(this.r_issueplaceTextBox);
            this.groupBox1.Controls.Add(this.r_telTextBox);
            this.groupBox1.Controls.Add(this.r_idLabel1);
            this.groupBox1.Controls.Add(r_issueplaceLabel);
            this.groupBox1.Controls.Add(r_telLabel);
            this.groupBox1.Controls.Add(r_namelastLabel);
            this.groupBox1.Controls.Add(this.r_pidTextBox);
            this.groupBox1.Controls.Add(this.r_expdateDateTimePicker);
            this.groupBox1.Controls.Add(this.r_occuTextBox);
            this.groupBox1.Controls.Add(this.r_namelastTextBox);
            this.groupBox1.Controls.Add(r_issuedateLabel);
            this.groupBox1.Controls.Add(r_occuLabel);
            this.groupBox1.Controls.Add(r_ageLabel);
            this.groupBox1.Controls.Add(r_expdateLabel);
            this.groupBox1.Controls.Add(this.r_sexComboBox);
            this.groupBox1.Controls.Add(this.r_ageTextBox);
            this.groupBox1.Controls.Add(this.r_issuedateDateTimePicker);
            this.groupBox1.Controls.Add(r_sexLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 264);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลส่วนตัว";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(r_postalcodeLabel);
            this.groupBox2.Controls.Add(this.r_postalcodeTextBox);
            this.groupBox2.Controls.Add(this.r_hnumberTextBox);
            this.groupBox2.Controls.Add(this.r_provinceTextBox);
            this.groupBox2.Controls.Add(r_hnumberLabel);
            this.groupBox2.Controls.Add(r_provinceLabel);
            this.groupBox2.Controls.Add(this.r_districtTextBox);
            this.groupBox2.Controls.Add(r_mooLabel);
            this.groupBox2.Controls.Add(r_districtLabel);
            this.groupBox2.Controls.Add(this.r_mooTextBox);
            this.groupBox2.Controls.Add(this.r_tambonTextBox);
            this.groupBox2.Controls.Add(r_soiLabel);
            this.groupBox2.Controls.Add(r_tambonLabel);
            this.groupBox2.Controls.Add(this.r_soiTextBox);
            this.groupBox2.Controls.Add(this.r_roadTextBox);
            this.groupBox2.Controls.Add(r_roadLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(718, 185);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ที่อยู่";
            // 
            // r_postalcodeTextBox
            // 
            this.r_postalcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentersBindingSource, "r_postalcode", true));
            this.r_postalcodeTextBox.Location = new System.Drawing.Point(482, 133);
            this.r_postalcodeTextBox.Name = "r_postalcodeTextBox";
            this.r_postalcodeTextBox.Size = new System.Drawing.Size(213, 24);
            this.r_postalcodeTextBox.TabIndex = 35;
            this.r_postalcodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.r_postalcodeTextBox_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Renter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 519);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rentersBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Renter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ข้อมูลผู้เช่า";
            this.Load += new System.EventHandler(this.Renter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.renterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentersBindingNavigator)).EndInit();
            this.rentersBindingNavigator.ResumeLayout(false);
            this.rentersBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RenterDataSet renterDataSet;
        private BindingSource rentersBindingSource;
        private RentersTableAdapter rentersTableAdapter;
        private TableAdapterManager tableAdapterManager;
        private BindingNavigator rentersBindingNavigator;
        private ToolStripButton bindingNavigatorAddNewItem;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorDeleteItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private ToolStripButton rentersBindingNavigatorSaveItem;
        private Label r_idLabel1;
        private TextBox r_namelastTextBox;
        private TextBox r_ageTextBox;
        private ComboBox r_sexComboBox;
        private TextBox r_occuTextBox;
        private TextBox r_telTextBox;
        private TextBox r_pidTextBox;
        private DateTimePicker r_issuedateDateTimePicker;
        private DateTimePicker r_expdateDateTimePicker;
        private TextBox r_issueplaceTextBox;
        private TextBox r_hnumberTextBox;
        private TextBox r_mooTextBox;
        private TextBox r_soiTextBox;
        private TextBox r_roadTextBox;
        private TextBox r_tambonTextBox;
        private TextBox r_districtTextBox;
        private TextBox r_provinceTextBox;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox r_postalcodeTextBox;
        private Timer timer1;
    }
}