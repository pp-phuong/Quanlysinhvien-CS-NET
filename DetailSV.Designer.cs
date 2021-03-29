
namespace QLSV
{
    partial class DetailSV
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
            this.gb_ttsv = new System.Windows.Forms.GroupBox();
            this.cbb_LSH = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radio_male = new System.Windows.Forms.RadioButton();
            this.label_birthday = new System.Windows.Forms.Label();
            this.dtp_birthday = new System.Windows.Forms.DateTimePicker();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_mssv = new System.Windows.Forms.TextBox();
            this.label_lsh = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_mssv = new System.Windows.Forms.Label();
            this.gb_ttsv.SuspendLayout();
            this.groupBoxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_ttsv
            // 
            this.gb_ttsv.Controls.Add(this.cbb_LSH);
            this.gb_ttsv.Controls.Add(this.btn_cancel);
            this.gb_ttsv.Controls.Add(this.btn_confirm);
            this.gb_ttsv.Controls.Add(this.groupBoxGender);
            this.gb_ttsv.Controls.Add(this.label_birthday);
            this.gb_ttsv.Controls.Add(this.dtp_birthday);
            this.gb_ttsv.Controls.Add(this.txt_name);
            this.gb_ttsv.Controls.Add(this.txt_mssv);
            this.gb_ttsv.Controls.Add(this.label_lsh);
            this.gb_ttsv.Controls.Add(this.label_name);
            this.gb_ttsv.Controls.Add(this.label_mssv);
            this.gb_ttsv.Location = new System.Drawing.Point(39, 46);
            this.gb_ttsv.Name = "gb_ttsv";
            this.gb_ttsv.Size = new System.Drawing.Size(329, 328);
            this.gb_ttsv.TabIndex = 0;
            this.gb_ttsv.TabStop = false;
            this.gb_ttsv.Text = "Thông tin Sinh viên";
            this.gb_ttsv.Enter += new System.EventHandler(this.gb_ttsv_Enter);
            // 
            // cbb_LSH
            // 
            this.cbb_LSH.FormattingEnabled = true;
            this.cbb_LSH.Location = new System.Drawing.Point(103, 106);
            this.cbb_LSH.Name = "cbb_LSH";
            this.cbb_LSH.Size = new System.Drawing.Size(121, 21);
            this.cbb_LSH.TabIndex = 7;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(116, 277);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(35, 277);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm.TabIndex = 5;
            this.btn_confirm.Text = "OK";
            this.btn_confirm.UseMnemonic = false;
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.radioFemale);
            this.groupBoxGender.Controls.Add(this.radio_male);
            this.groupBoxGender.Location = new System.Drawing.Point(20, 185);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(200, 73);
            this.groupBoxGender.TabIndex = 4;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Gender";
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(97, 32);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(59, 17);
            this.radioFemale.TabIndex = 0;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // radio_male
            // 
            this.radio_male.AutoSize = true;
            this.radio_male.Location = new System.Drawing.Point(15, 32);
            this.radio_male.Name = "radio_male";
            this.radio_male.Size = new System.Drawing.Size(48, 17);
            this.radio_male.TabIndex = 0;
            this.radio_male.TabStop = true;
            this.radio_male.Text = "Male";
            this.radio_male.UseVisualStyleBackColor = true;
            // 
            // label_birthday
            // 
            this.label_birthday.AutoSize = true;
            this.label_birthday.Location = new System.Drawing.Point(17, 141);
            this.label_birthday.Name = "label_birthday";
            this.label_birthday.Size = new System.Drawing.Size(54, 13);
            this.label_birthday.TabIndex = 3;
            this.label_birthday.Text = "Ngày sinh";
            // 
            // dtp_birthday
            // 
            this.dtp_birthday.Location = new System.Drawing.Point(103, 141);
            this.dtp_birthday.Name = "dtp_birthday";
            this.dtp_birthday.Size = new System.Drawing.Size(200, 20);
            this.dtp_birthday.TabIndex = 2;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(103, 72);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 1;
            // 
            // txt_mssv
            // 
            this.txt_mssv.Location = new System.Drawing.Point(103, 44);
            this.txt_mssv.Name = "txt_mssv";
            this.txt_mssv.Size = new System.Drawing.Size(100, 20);
            this.txt_mssv.TabIndex = 1;
            // 
            // label_lsh
            // 
            this.label_lsh.AutoSize = true;
            this.label_lsh.Location = new System.Drawing.Point(17, 106);
            this.label_lsh.Name = "label_lsh";
            this.label_lsh.Size = new System.Drawing.Size(71, 13);
            this.label_lsh.TabIndex = 0;
            this.label_lsh.Text = "Lớp sinh hoạt";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(17, 75);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 13);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name";
            // 
            // label_mssv
            // 
            this.label_mssv.AutoSize = true;
            this.label_mssv.Location = new System.Drawing.Point(17, 47);
            this.label_mssv.Name = "label_mssv";
            this.label_mssv.Size = new System.Drawing.Size(37, 13);
            this.label_mssv.TabIndex = 0;
            this.label_mssv.Text = "MSSV";
            // 
            // DetailSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 450);
            this.Controls.Add(this.gb_ttsv);
            this.Name = "DetailSV";
            this.Text = "DetailSV";
            this.gb_ttsv.ResumeLayout(false);
            this.gb_ttsv.PerformLayout();
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_ttsv;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radio_male;
        private System.Windows.Forms.Label label_birthday;
        private System.Windows.Forms.DateTimePicker dtp_birthday;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_mssv;
        private System.Windows.Forms.Label label_lsh;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_mssv;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ComboBox cbb_LSH;
    }
}