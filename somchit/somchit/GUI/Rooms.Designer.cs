﻿using System.ComponentModel;

namespace somchit.GUI
{
    partial class Rooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rooms));
            System.Windows.Forms.Label room_noLabel;
            System.Windows.Forms.Label room_floorLabel;
            System.Windows.Forms.Label room_buildingLabel;
            System.Windows.Forms.Label room_statusLabel;
            this.roomsDataSet = new somchit.roomsDataSet();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new somchit.roomsDataSetTableAdapters.RoomsTableAdapter();
            this.tableAdapterManager = new somchit.roomsDataSetTableAdapters.TableAdapterManager();
            this.roomsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.roomsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.room_noLabel1 = new System.Windows.Forms.Label();
            this.room_floorTextBox = new System.Windows.Forms.TextBox();
            this.room_buildingTextBox = new System.Windows.Forms.TextBox();
            this.room_statusComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            room_noLabel = new System.Windows.Forms.Label();
            room_floorLabel = new System.Windows.Forms.Label();
            room_buildingLabel = new System.Windows.Forms.Label();
            room_statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingNavigator)).BeginInit();
            this.roomsBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // roomsDataSet
            // 
            this.roomsDataSet.DataSetName = "roomsDataSet";
            this.roomsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.roomsDataSet;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RoomsTableAdapter = this.roomsTableAdapter;
            this.tableAdapterManager.UpdateOrder = somchit.roomsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // roomsBindingNavigator
            // 
            this.roomsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.roomsBindingNavigator.AutoSize = false;
            this.roomsBindingNavigator.BindingSource = this.roomsBindingSource;
            this.roomsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.roomsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.roomsBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.roomsBindingNavigator.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.roomsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.roomsBindingNavigatorSaveItem});
            this.roomsBindingNavigator.Location = new System.Drawing.Point(0, 221);
            this.roomsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.roomsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.roomsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.roomsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.roomsBindingNavigator.Name = "roomsBindingNavigator";
            this.roomsBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.roomsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.roomsBindingNavigator.Size = new System.Drawing.Size(453, 35);
            this.roomsBindingNavigator.TabIndex = 0;
            this.roomsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 32);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(51, 32);
            this.bindingNavigatorAddNewItem.Text = "เพิ่ม";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(44, 32);
            this.bindingNavigatorDeleteItem.Text = "ลบ";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // roomsBindingNavigatorSaveItem
            // 
            this.roomsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("roomsBindingNavigatorSaveItem.Image")));
            this.roomsBindingNavigatorSaveItem.Name = "roomsBindingNavigatorSaveItem";
            this.roomsBindingNavigatorSaveItem.Size = new System.Drawing.Size(63, 32);
            this.roomsBindingNavigatorSaveItem.Text = "บันทึก";
            this.roomsBindingNavigatorSaveItem.Click += new System.EventHandler(this.roomsBindingNavigatorSaveItem_Click);
            // 
            // room_noLabel
            // 
            room_noLabel.AutoSize = true;
            room_noLabel.Location = new System.Drawing.Point(149, 34);
            room_noLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            room_noLabel.Name = "room_noLabel";
            room_noLabel.Size = new System.Drawing.Size(67, 18);
            room_noLabel.TabIndex = 1;
            room_noLabel.Text = "เลขที่ห้อง :";
            // 
            // room_noLabel1
            // 
            this.room_noLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "room_no", true));
            this.room_noLabel1.Location = new System.Drawing.Point(220, 35);
            this.room_noLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.room_noLabel1.Name = "room_noLabel1";
            this.room_noLabel1.Size = new System.Drawing.Size(182, 32);
            this.room_noLabel1.TabIndex = 2;
            this.room_noLabel1.Text = "label1";
            // 
            // room_floorLabel
            // 
            room_floorLabel.AutoSize = true;
            room_floorLabel.Location = new System.Drawing.Point(149, 74);
            room_floorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            room_floorLabel.Name = "room_floorLabel";
            room_floorLabel.Size = new System.Drawing.Size(33, 18);
            room_floorLabel.TabIndex = 3;
            room_floorLabel.Text = "ชั้น :";
            // 
            // room_floorTextBox
            // 
            this.room_floorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "room_floor", true));
            this.room_floorTextBox.Location = new System.Drawing.Point(220, 71);
            this.room_floorTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.room_floorTextBox.Name = "room_floorTextBox";
            this.room_floorTextBox.Size = new System.Drawing.Size(180, 24);
            this.room_floorTextBox.TabIndex = 4;
            // 
            // room_buildingLabel
            // 
            room_buildingLabel.AutoSize = true;
            room_buildingLabel.Location = new System.Drawing.Point(149, 110);
            room_buildingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            room_buildingLabel.Name = "room_buildingLabel";
            room_buildingLabel.Size = new System.Drawing.Size(51, 18);
            room_buildingLabel.TabIndex = 5;
            room_buildingLabel.Text = "อาคาร :";
            // 
            // room_buildingTextBox
            // 
            this.room_buildingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "room_building", true));
            this.room_buildingTextBox.Location = new System.Drawing.Point(220, 107);
            this.room_buildingTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.room_buildingTextBox.Name = "room_buildingTextBox";
            this.room_buildingTextBox.Size = new System.Drawing.Size(180, 24);
            this.room_buildingTextBox.TabIndex = 6;
            // 
            // room_statusLabel
            // 
            room_statusLabel.AutoSize = true;
            room_statusLabel.Location = new System.Drawing.Point(149, 146);
            room_statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            room_statusLabel.Name = "room_statusLabel";
            room_statusLabel.Size = new System.Drawing.Size(54, 18);
            room_statusLabel.TabIndex = 7;
            room_statusLabel.Text = "สถานะ :";
            // 
            // room_statusComboBox
            // 
            this.room_statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "room_status", true));
            this.room_statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.room_statusComboBox.FormattingEnabled = true;
            this.room_statusComboBox.Items.AddRange(new object[] {
            "ว่าง",
            "ไม่ว่าง"});
            this.room_statusComboBox.Location = new System.Drawing.Point(220, 143);
            this.room_statusComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.room_statusComboBox.Name = "room_statusComboBox";
            this.room_statusComboBox.Size = new System.Drawing.Size(180, 26);
            this.room_statusComboBox.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.room_floorTextBox);
            this.groupBox1.Controls.Add(room_noLabel);
            this.groupBox1.Controls.Add(this.room_statusComboBox);
            this.groupBox1.Controls.Add(this.room_noLabel1);
            this.groupBox1.Controls.Add(room_statusLabel);
            this.groupBox1.Controls.Add(room_floorLabel);
            this.groupBox1.Controls.Add(this.room_buildingTextBox);
            this.groupBox1.Controls.Add(room_buildingLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 197);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลห้อง";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::somchit.Properties.Resources.New_room_icon;
            this.pictureBox1.Location = new System.Drawing.Point(18, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(453, 256);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.roomsBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Rooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ข้อมูลห้องพัก";
            this.Load += new System.EventHandler(this.Rooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingNavigator)).EndInit();
            this.roomsBindingNavigator.ResumeLayout(false);
            this.roomsBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private roomsDataSet roomsDataSet;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private roomsDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private roomsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator roomsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton roomsBindingNavigatorSaveItem;
        private System.Windows.Forms.Label room_noLabel1;
        private System.Windows.Forms.TextBox room_floorTextBox;
        private System.Windows.Forms.TextBox room_buildingTextBox;
        private System.Windows.Forms.ComboBox room_statusComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}