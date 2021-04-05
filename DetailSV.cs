using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class DetailSV : Form
    {
        public delegate void delType(int mssv, int class_id);
        public delType delegateType { get; set; }
        public DetailSV()
        {
            InitializeComponent();
            SetCbbLSH();
            delegateType = new delType(setType);
        }
        public void SetCbbLSH()
        {

            cbb_LSH.Items.Add("Chọn lớp");
            foreach (LSH i in CDSL_Handle.Instance.ListLSH)
            {
                cbb_LSH.Items.Add(i.getName());
            }
            cbb_LSH.Text = "Chọn lớp";
        }
        private void setType(int mssv, int class_id)
        {
            if(mssv == -1)
            {
                gb_ttsv.Text = "Thêm sinh viên mới";
            }    
            else
            {
                gb_ttsv.Text = "Chỉnh sửa thông tin sinh viên";
                getInforEdit(mssv, class_id);

            }

        }
        private void getInforEdit(int mssv, int class_id)
        {
            SV s = CDSL_Handle.Instance.getSVbyMSSV(mssv);
            MessageBox.Show(s.ToString());
            txt_mssv.Text = s.MSSV.ToString();
            txt_name.Text = s.NameSV;
            dtp_birthday.Value = Convert.ToDateTime(s.Birthday);
                
            int indexClass = CDSL_Handle.Instance.getIndexLSH(class_id);
            cbb_LSH.SelectedItem = cbb_LSH.Items[indexClass+1];
            LSH lop = CDSL_Handle.Instance.getLSHById(class_id);
            

            if (s.Gender)
            {
                radio_male.Checked = true;
            }
            else radioFemale.Checked = true;
            txt_mssv.Enabled = false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {

            
            if (txt_mssv.Text == "" || txt_name.Text == "" || cbb_LSH.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ");

            }
            else
            {
                if (gb_ttsv.Text == "Chỉnh sửa thông tin sinh viên")
                {
                    CDSL_Handle.Instance.updateSV(getSV());
                    MessageBox.Show("Chỉnh sửa sinh viên thành công !");
                    this.Close();

                }
                else
                {
                    if (CDSL_Handle.Instance.addSV(getSV()))
                    {
                        MessageBox.Show("Thêm sinh viên thành công !");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("MSSV đã tồn tại!");
                    }
                }
            }

           
        }
        public SV getSV()
        {
            SV s = new SV();
            s.MSSV = Convert.ToInt32(txt_mssv.Text);
            s.NameSV = txt_name.Text;
            if (radio_male.Checked == true)
            {
                s.Gender = true;
            }
            else s.Gender = false;
            s.Birthday = dtp_birthday.Value;
            int id_class = CDSL_Handle.Instance.getIDLSH(cbb_LSH.Text);
            s.ClassID = id_class;

            return s;
        }
    }
}
