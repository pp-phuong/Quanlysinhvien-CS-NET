
namespace QLSV
{
    partial class QLSV
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
            this.dataGridViewDSSV = new System.Windows.Forms.DataGridView();
            this.label_lsh = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_sort = new System.Windows.Forms.ComboBox();
            this.btn_sort = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.cbbLopSH = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.cbb_search_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSSV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDSSV
            // 
            this.dataGridViewDSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSSV.Location = new System.Drawing.Point(11, 30);
            this.dataGridViewDSSV.Name = "dataGridViewDSSV";
            this.dataGridViewDSSV.ReadOnly = true;
            this.dataGridViewDSSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDSSV.Size = new System.Drawing.Size(573, 150);
            this.dataGridViewDSSV.TabIndex = 0;
            // 
            // label_lsh
            // 
            this.label_lsh.AutoSize = true;
            this.label_lsh.Location = new System.Drawing.Point(64, 27);
            this.label_lsh.Name = "label_lsh";
            this.label_lsh.Size = new System.Drawing.Size(71, 13);
            this.label_lsh.TabIndex = 1;
            this.label_lsh.Text = "Lớp sinh hoạt";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_sort);
            this.groupBox1.Controls.Add(this.btn_sort);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_edit);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.dataGridViewDSSV);
            this.groupBox1.Location = new System.Drawing.Point(56, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 254);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách SV";
            // 
            // cbb_sort
            // 
            this.cbb_sort.FormattingEnabled = true;
            this.cbb_sort.Location = new System.Drawing.Point(463, 214);
            this.cbb_sort.Name = "cbb_sort";
            this.cbb_sort.Size = new System.Drawing.Size(121, 21);
            this.cbb_sort.TabIndex = 6;
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(388, 212);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(46, 23);
            this.btn_sort.TabIndex = 5;
            this.btn_sort.Text = "Sort";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(145, 212);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(42, 23);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Del";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(76, 212);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(42, 23);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(11, 212);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(43, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(211, 47);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(43, 23);
            this.btn_show.TabIndex = 1;
            this.btn_show.Text = "Show";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // cbbLopSH
            // 
            this.cbbLopSH.FormattingEnabled = true;
            this.cbbLopSH.Location = new System.Drawing.Point(67, 49);
            this.cbbLopSH.Name = "cbbLopSH";
            this.cbbLopSH.Size = new System.Drawing.Size(121, 21);
            this.cbbLopSH.TabIndex = 3;
            this.cbbLopSH.Text = "Chọn lớp ";
            this.cbbLopSH.SelectedIndexChanged += new System.EventHandler(this.cbbLopSH_SelectedIndexChanged);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(552, 50);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 20);
            this.txt_search.TabIndex = 4;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(577, 76);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cbb_search_type
            // 
            this.cbb_search_type.FormattingEnabled = true;
            this.cbb_search_type.Items.AddRange(new object[] {
            "MSSV",
            "NameSV"});
            this.cbb_search_type.Location = new System.Drawing.Point(531, 23);
            this.cbb_search_type.Name = "cbb_search_type";
            this.cbb_search_type.Size = new System.Drawing.Size(121, 21);
            this.cbb_search_type.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tìm kiếm theo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nội dung tìm kiếm";
            // 
            // QLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 408);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_search_type);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.cbbLopSH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_lsh);
            this.Name = "QLSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLSV";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSSV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDSSV;
        private System.Windows.Forms.Label label_lsh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbb_sort;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.ComboBox cbbLopSH;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cbb_search_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}