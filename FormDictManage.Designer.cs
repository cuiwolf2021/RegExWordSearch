
namespace RegExWordSearch
{
    partial class FormDictManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewDictsManage = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.button2Lower = new System.Windows.Forms.Button();
            this.button2Higher = new System.Windows.Forms.Button();
            this.buttonRemoveDict = new System.Windows.Forms.Button();
            this.buttonImportDict = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listViewSearchManage = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 21);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(841, 404);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.button2Lower);
            this.tabPage1.Controls.Add(this.button2Higher);
            this.tabPage1.Controls.Add(this.buttonRemoveDict);
            this.tabPage1.Controls.Add(this.buttonImportDict);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(833, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "词典安装";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listViewDictsManage);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 289);
            this.panel1.TabIndex = 4;
            // 
            // listViewDictsManage
            // 
            this.listViewDictsManage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewDictsManage.FullRowSelect = true;
            this.listViewDictsManage.GridLines = true;
            this.listViewDictsManage.HideSelection = false;
            this.listViewDictsManage.Location = new System.Drawing.Point(9, 44);
            this.listViewDictsManage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewDictsManage.MultiSelect = false;
            this.listViewDictsManage.Name = "listViewDictsManage";
            this.listViewDictsManage.ShowGroups = false;
            this.listViewDictsManage.Size = new System.Drawing.Size(808, 236);
            this.listViewDictsManage.TabIndex = 1;
            this.listViewDictsManage.UseCompatibleStateImageBehavior = false;
            this.listViewDictsManage.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Text = "词典名称";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Name = "columnHeader2";
            this.columnHeader2.Text = "单词数量";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Name = "columnHeader3";
            this.columnHeader3.Text = "词典简介";
            this.columnHeader3.Width = 350;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "词典安装列表";
            // 
            // button2Lower
            // 
            this.button2Lower.Location = new System.Drawing.Point(183, 28);
            this.button2Lower.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2Lower.Name = "button2Lower";
            this.button2Lower.Size = new System.Drawing.Size(94, 29);
            this.button2Lower.TabIndex = 3;
            this.button2Lower.Text = "向下";
            this.button2Lower.UseVisualStyleBackColor = true;
            this.button2Lower.Click += new System.EventHandler(this.button2Lower_Click);
            // 
            // button2Higher
            // 
            this.button2Higher.Location = new System.Drawing.Point(63, 28);
            this.button2Higher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2Higher.Name = "button2Higher";
            this.button2Higher.Size = new System.Drawing.Size(94, 29);
            this.button2Higher.TabIndex = 2;
            this.button2Higher.Text = "向上";
            this.button2Higher.UseVisualStyleBackColor = true;
            this.button2Higher.Click += new System.EventHandler(this.button2Higher_Click);
            // 
            // buttonRemoveDict
            // 
            this.buttonRemoveDict.Location = new System.Drawing.Point(723, 28);
            this.buttonRemoveDict.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRemoveDict.Name = "buttonRemoveDict";
            this.buttonRemoveDict.Size = new System.Drawing.Size(94, 29);
            this.buttonRemoveDict.TabIndex = 1;
            this.buttonRemoveDict.Text = "卸载";
            this.buttonRemoveDict.UseVisualStyleBackColor = true;
            this.buttonRemoveDict.Click += new System.EventHandler(this.buttonRemoveDict_Click);
            // 
            // buttonImportDict
            // 
            this.buttonImportDict.Location = new System.Drawing.Point(598, 28);
            this.buttonImportDict.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonImportDict.Name = "buttonImportDict";
            this.buttonImportDict.Size = new System.Drawing.Size(94, 29);
            this.buttonImportDict.TabIndex = 0;
            this.buttonImportDict.Text = "导入";
            this.buttonImportDict.UseVisualStyleBackColor = true;
            this.buttonImportDict.Click += new System.EventHandler(this.ButtonImportDict_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(833, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "搜索组";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listViewSearchManage);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(6, 66);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(819, 289);
            this.panel2.TabIndex = 8;
            // 
            // listViewSearchManage
            // 
            this.listViewSearchManage.CheckBoxes = true;
            this.listViewSearchManage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewSearchManage.FullRowSelect = true;
            this.listViewSearchManage.GridLines = true;
            this.listViewSearchManage.HideSelection = false;
            this.listViewSearchManage.Location = new System.Drawing.Point(9, 44);
            this.listViewSearchManage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewSearchManage.MultiSelect = false;
            this.listViewSearchManage.Name = "listViewSearchManage";
            this.listViewSearchManage.ShowGroups = false;
            this.listViewSearchManage.Size = new System.Drawing.Size(809, 236);
            this.listViewSearchManage.TabIndex = 1;
            this.listViewSearchManage.UseCompatibleStateImageBehavior = false;
            this.listViewSearchManage.View = System.Windows.Forms.View.Details;
            this.listViewSearchManage.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewSearchManage_ItemChecked);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Name = "columnHeader1";
            this.columnHeader4.Text = "词典名称";
            this.columnHeader4.Width = 180;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Name = "columnHeader2";
            this.columnHeader5.Text = "单词数量";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Name = "columnHeader6";
            this.columnHeader6.Text = "词典简介";
            this.columnHeader6.Width = 350;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "搜索列表";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(723, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "向下";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(599, 27);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "向上";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCloseForm.Location = new System.Drawing.Point(729, 436);
            this.buttonCloseForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(105, 31);
            this.buttonCloseForm.TabIndex = 1;
            this.buttonCloseForm.Text = "关闭";
            this.buttonCloseForm.UseVisualStyleBackColor = true;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 479);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(846, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 16);
            // 
            // FormDictManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 501);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.buttonCloseForm);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDictManage";
            this.Text = "词典管理";
            this.Load += new System.EventHandler(this.FormDictManage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2Lower;
        private System.Windows.Forms.Button button2Higher;
        private System.Windows.Forms.Button buttonRemoveDict;
        private System.Windows.Forms.Button buttonImportDict;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.ListView listViewDictsManage;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listViewSearchManage;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}