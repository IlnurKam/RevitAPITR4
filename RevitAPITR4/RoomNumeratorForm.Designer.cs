using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace RevitAPITR4
//{
//     class RoomNumeratorForm
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.components = new System.ComponentModel.Container();
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(800, 450);
//            this.Text = "RoomNumeratorForm";
//        }

//        #endregion
//    }
//}
{
    partial class RoomNumeratorForm /*: System.Windows.Forms.Form*/
    {
        private RoomNum m_data;
        private IContainer components;
        private GroupBox allViewsGroupBox;
        private GroupBox RoomsGroupBox;
        private Button oKButton;
        private Button cancelButton;
        private TextBox sufBox;
        private Label label3;
        private TextBox startNumBox;
        private Label label2;
        private TextBox prefBox;
        private Label label1;
        private Label label4;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem dirNum;
        private ToolStripMenuItem toolStripMenuItem0;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private Button SelectBut;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButtonVyd;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private Label label6;
        private Label label5;
        private NumericUpDown accurUpDown;
        private ToolTip toolTip1;
        private GroupBox groupBox1;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private Label label7;

        public RoomNumeratorForm(RoomNum data)
        {
            this.m_data = data;
            this.InitializeComponent();
            foreach (System.Windows.Forms.Control control in (ArrangedElementCollection)this.accurUpDown.Controls)
                this.toolTip1.SetToolTip(control, "Точность определения положения помещений, мин. 0, макс 900");
        }

        public RoomNumeratorForm(RoomNum data, IContainer components, GroupBox allViewsGroupBox, GroupBox roomsGroupBox, Button oKButton, Button cancelButton, TextBox sufBox, Label label3, TextBox startNumBox, Label label2, TextBox prefBox, Label label1, Label label4, MenuStrip menuStrip2, ToolStripMenuItem dirNum, ToolStripMenuItem toolStripMenuItem0, ToolStripMenuItem toolStripMenuItem1, ToolStripMenuItem toolStripMenuItem2, ToolStripMenuItem toolStripMenuItem3, ToolStripMenuItem toolStripMenuItem4, ToolStripMenuItem toolStripMenuItem5, ToolStripMenuItem toolStripMenuItem6, ToolStripMenuItem toolStripMenuItem7, Button selectBut, RadioButton radioButton2, RadioButton radioButton1, RadioButton radioButtonVyd, ToolStripSeparator toolStripSeparator1, ToolStripSeparator toolStripSeparator2, ToolStripSeparator toolStripSeparator3, Label label6, Label label5, NumericUpDown accurUpDown, ToolTip toolTip1, GroupBox groupBox1, RadioButton radioButton5, RadioButton radioButton4, RadioButton radioButton3, Label label7, Button autoTagButton, ComboBox tagTypesComboBox, Label tagTypeLabel, Label levelLabel, ComboBox levelsComboBox, ComboBox comboBox1, Label label9, ComboBox comboBox2, Label label10, Button button1, Button button2, Label label8, Label label11) : this(data)
        {
            this.components = components;
            this.allViewsGroupBox = allViewsGroupBox;
            RoomsGroupBox = roomsGroupBox;
            this.oKButton = oKButton;
            this.cancelButton = cancelButton;
            this.sufBox = sufBox;
            this.label3 = label3;
            this.startNumBox = startNumBox;
            this.label2 = label2;
            this.prefBox = prefBox;
            this.label1 = label1;
            this.label4 = label4;
            this.menuStrip2 = menuStrip2;
            this.dirNum = dirNum;
            this.toolStripMenuItem0 = toolStripMenuItem0;
            this.toolStripMenuItem1 = toolStripMenuItem1;
            this.toolStripMenuItem2 = toolStripMenuItem2;
            this.toolStripMenuItem3 = toolStripMenuItem3;
            this.toolStripMenuItem4 = toolStripMenuItem4;
            this.toolStripMenuItem5 = toolStripMenuItem5;
            this.toolStripMenuItem6 = toolStripMenuItem6;
            this.toolStripMenuItem7 = toolStripMenuItem7;
            SelectBut = selectBut;
            this.radioButton2 = radioButton2;
            this.radioButton1 = radioButton1;
            this.radioButtonVyd = radioButtonVyd;
            this.toolStripSeparator1 = toolStripSeparator1;
            this.toolStripSeparator2 = toolStripSeparator2;
            this.toolStripSeparator3 = toolStripSeparator3;
            this.label6 = label6;
            this.label5 = label5;
            this.accurUpDown = accurUpDown;
            this.toolTip1 = toolTip1;
            this.groupBox1 = groupBox1;
            this.radioButton5 = radioButton5;
            this.radioButton4 = radioButton4;
            this.radioButton3 = radioButton3;
            this.label7 = label7;
            this.autoTagButton = autoTagButton;
            this.tagTypesComboBox = tagTypesComboBox;
            this.tagTypeLabel = tagTypeLabel;
            this.levelLabel = levelLabel;
            this.levelsComboBox = levelsComboBox;
            this.comboBox1 = comboBox1;
            this.label9 = label9;
            this.comboBox2 = comboBox2;
            this.label10 = label10;
            this.button1 = button1;
            this.button2 = button2;
            this.label8 = label8;
            this.label11 = label11;
        }

        private void AllViewsForm_Load(object sender, EventArgs e)
        {
            this.m_data.Prefix = Settings.Default["pref"].ToString();
            this.prefBox.Text = this.m_data.Prefix;
            this.m_data.Step = (double)Settings.Default["step"];
            this.accurUpDown.Value = new Decimal(this.m_data.Step);
            this.m_data.Suffix = Settings.Default["suffix"].ToString();
            this.sufBox.Text = this.m_data.Suffix;
            this.m_data.StartNum = Convert.ToInt32(Settings.Default["starnum"].ToString());
            this.startNumBox.Text = this.m_data.StartNum.ToString();
            this.m_data.DirNum = Convert.ToInt32(Settings.Default["dirNum"].ToString());
            this.m_data.Point = (double)Settings.Default["point"];
            if (this.m_data.Point == 0.0)
                this.radioButton3.Checked = true;
            if (this.m_data.Point == 1.0)
                this.radioButton4.Checked = true;
            if (this.m_data.Point == 2.0)
                this.radioButton5.Checked = true;
            int dirNum = this.m_data.DirNum;
            if (dirNum == 0)
            {
                this.dirNum.Text = this.toolStripMenuItem0.Text;
                this.dirNum.Image = this.toolStripMenuItem0.Image;
            }
            if (dirNum == 1)
            {
                this.dirNum.Text = this.toolStripMenuItem1.Text;
                this.dirNum.Image = this.toolStripMenuItem1.Image;
            }
            if (dirNum == 2)
            {
                this.dirNum.Text = this.toolStripMenuItem2.Text;
                this.dirNum.Image = this.toolStripMenuItem2.Image;
            }
            if (dirNum == 3)
            {
                this.dirNum.Text = this.toolStripMenuItem3.Text;
                this.dirNum.Image = this.toolStripMenuItem3.Image;
            }
            if (dirNum == 4)
            {
                this.dirNum.Text = this.toolStripMenuItem4.Text;
                this.dirNum.Image = this.toolStripMenuItem4.Image;
            }
            if (dirNum == 5)
            {
                this.dirNum.Text = this.toolStripMenuItem5.Text;
                this.dirNum.Image = this.toolStripMenuItem5.Image;
            }
            if (dirNum == 6)
            {
                this.dirNum.Text = this.toolStripMenuItem6.Text;
                this.dirNum.Image = this.toolStripMenuItem6.Image;
            }
            if (dirNum == 7)
            {
                this.dirNum.Text = this.toolStripMenuItem7.Text;
                this.dirNum.Image = this.toolStripMenuItem7.Image;
            }
            if (((ICollection<Element>)this.m_data.Rooms).Count != 0)
                return;
            this.radioButtonVyd.Enabled = false;
            this.radioButton1.Checked = true;
        }

        private void SaveDefaults()
        {
            if (this.radioButton1.Checked)
                this.m_data.AllRooms = true;
            Settings.Default["pref"] = (object)this.prefBox.Text;
            this.m_data.Prefix = this.prefBox.Text;
            Settings.Default["suffix"] = (object)this.sufBox.Text;
            this.m_data.Suffix = this.sufBox.Text;
            Settings.Default["starnum"] = (object)Convert.ToInt32(this.startNumBox.Text);
            this.m_data.StartNum = Convert.ToInt32(this.startNumBox.Text);
            Settings.Default["dirNum"] = (object)this.m_data.DirNum;
            this.m_data.Step = Convert.ToDouble(this.accurUpDown.Value) / 304.8;
            Settings.Default["step"] = (object)(this.m_data.Step * 304.8);
            Settings.Default["point"] = (object)this.m_data.Point;
            Settings.Default.Save();
        }

        private void oKButton_Click(object sender, EventArgs e) => this.SaveDefaults();

        private void startNumBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = e.KeyChar;
            if (char.IsDigit(keyChar) || keyChar == '\b')
                return;
            e.Handled = true;
        }

        private void toolStripMenuItem0_Click(object sender, EventArgs e)
        {
            this.dirNum.Image = this.toolStripMenuItem0.Image;
            this.dirNum.Text = this.toolStripMenuItem0.Text;
            this.m_data.DirNum = 0;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.dirNum.Image = this.toolStripMenuItem1.Image;
            this.dirNum.Text = this.toolStripMenuItem1.Text;
            this.m_data.DirNum = 1;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.dirNum.Image = this.toolStripMenuItem2.Image;
            this.dirNum.Text = this.toolStripMenuItem2.Text;
            this.m_data.DirNum = 2;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.dirNum.Image = this.toolStripMenuItem3.Image;
            this.dirNum.Text = this.toolStripMenuItem3.Text;
            this.m_data.DirNum = 3;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) => this.SelectBut.Enabled = this.radioButton2.Checked;

        private void SelectBut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.SaveDefaults();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.dirNum.Image = this.toolStripMenuItem4.Image;
            this.dirNum.Text = this.toolStripMenuItem4.Text;
            this.m_data.DirNum = 4;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.dirNum.Image = this.toolStripMenuItem5.Image;
            this.dirNum.Text = this.toolStripMenuItem5.Text;
            this.m_data.DirNum = 5;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            this.dirNum.Image = this.toolStripMenuItem6.Image;
            this.dirNum.Text = this.toolStripMenuItem6.Text;
            this.m_data.DirNum = 6;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.dirNum.Image = this.toolStripMenuItem7.Image;
            this.dirNum.Text = this.toolStripMenuItem7.Text;
            this.m_data.DirNum = 7;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = e.KeyChar;
            if (char.IsDigit(keyChar) || keyChar == '\b')
                return;
            e.Handled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) => this.m_data.Point = 0.0;

        private void radioButton4_CheckedChanged(object sender, EventArgs e) => this.m_data.Point = 1.0;

        private void radioButton5_CheckedChanged(object sender, EventArgs e) => this.m_data.Point = 2.0;

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.autoTagButton = new System.Windows.Forms.Button();
            this.tagTypesComboBox = new System.Windows.Forms.ComboBox();
            this.tagTypeLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.levelsComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // autoTagButton
            // 
            this.autoTagButton.Location = new System.Drawing.Point(346, 60);
            this.autoTagButton.Name = "autoTagButton";
            this.autoTagButton.Size = new System.Drawing.Size(156, 23);
            this.autoTagButton.TabIndex = 11;
            this.autoTagButton.Text = "Всем помещениям на виде";
            this.autoTagButton.UseVisualStyleBackColor = true;
            // 
            // tagTypesComboBox
            // 
            this.tagTypesComboBox.FormattingEnabled = true;
            this.tagTypesComboBox.Location = new System.Drawing.Point(97, 62);
            this.tagTypesComboBox.Name = "tagTypesComboBox";
            this.tagTypesComboBox.Size = new System.Drawing.Size(175, 21);
            this.tagTypesComboBox.TabIndex = 9;
            // 
            // tagTypeLabel
            // 
            this.tagTypeLabel.AutoSize = true;
            this.tagTypeLabel.Location = new System.Drawing.Point(10, 65);
            this.tagTypeLabel.Name = "tagTypeLabel";
            this.tagTypeLabel.Size = new System.Drawing.Size(52, 13);
            this.tagTypeLabel.TabIndex = 8;
            this.tagTypeLabel.Text = "Начать с";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(9, 38);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(53, 13);
            this.levelLabel.TabIndex = 7;
            this.levelLabel.Text = "Префикс";
            // 
            // levelsComboBox
            // 
            this.levelsComboBox.FormattingEnabled = true;
            this.levelsComboBox.Location = new System.Drawing.Point(97, 35);
            this.levelsComboBox.Name = "levelsComboBox";
            this.levelsComboBox.Size = new System.Drawing.Size(175, 21);
            this.levelsComboBox.Sorted = true;
            this.levelsComboBox.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Суффикс";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(97, 90);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(175, 21);
            this.comboBox2.Sorted = true;
            this.comboBox2.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(105, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Нумерация";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Выбрать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(346, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Выделенным";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Направление";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(390, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Применить к";
            // 
            // RoomNumeratorForm
            // 
            this.ClientSize = new System.Drawing.Size(515, 153);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.autoTagButton);
            this.Controls.Add(this.tagTypesComboBox);
            this.Controls.Add(this.tagTypeLabel);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.levelsComboBox);
            this.Name = "RoomNumeratorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button autoTagButton;
        private ComboBox tagTypesComboBox;
        private Label tagTypeLabel;
        private Label levelLabel;
        private ComboBox levelsComboBox;
        private ComboBox comboBox1;
        private Label label9;
        private ComboBox comboBox2;
        private Label label10;
        private Button button1;
        private Button button2;
        private Label label8;
        private Label label11;
    }
}
