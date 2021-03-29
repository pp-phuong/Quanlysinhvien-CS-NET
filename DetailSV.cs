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
        public delegate void delEdit(DataGridViewRow r);
        public delegate void delType(string type);
        public delType delegateType { get; set; }
        public delEdit delegateEdit { get; set; }
        public DetailSV()
        {
            InitializeComponent();
            SetCbbLSH();
            delegateType = new delType(setType);
        }
        public void SetCbbLSH()
        {
            foreach (DataRow i in CSDL.Instance.DTLSH.Rows)
            {
                cbb_LSH.Items.Add(i["NameClass"].ToString());
            }
            cbb_LSH.Text = "Chọn lớp";

        }
        private void setType(string type)
        {
            gb_ttsv.Text = type;
            if (type == "Chỉnh sửa thông tin sinh viên")
            {
                delegateEdit = new delEdit(getInforEdit);
            }
        }
        private void getInforEdit(DataGridViewRow dr)
        {
            txt_mssv.Text = dr.Cells["MSSV"].Value.ToString();
            txt_name.Text = dr.Cells["NameSV"].Value.ToString();
            dtp_birthday.Value = Convert.ToDateTime(dr.Cells["Birthday"].Value.ToString()); ;
            cbb_LSH.SelectedItem = dr.Cells["ID_Class"].Value.ToString();
            if (dr.Cells["Gender"].Value.ToString() == "true")
            {
                radio_male.Checked = true;
            }
            else radio_male.Checked = false;
            txt_mssv.Enabled = false;
        }
        private void btn_confirm_Click(object sender, EventArgs e)
        {

            DataRow dr = CSDL.Instance.DTSV.NewRow();
            dr["MSSV"] = txt_mssv.Text;
            dr["NameSV"] = txt_name.Text;
            if (radio_male.Checked == true)
            {
                dr["Gender"] = true;
            }
            else dr["Gender"] = false;
            dr["Birthday"] = dtp_birthday.Value;
            string nameClass = cbb_LSH.Text;
            int ID_Class = CSDL.Instance.getIDLSH(nameClass);
            dr["ID_Class"] = ID_Class;
            if (gb_ttsv.Text == "Chỉnh sửa thông tin sinh viên")
            {
                CSDL.Instance.updateSV(dr);
                MessageBox.Show("Chỉnh sửa sinh viên thành công !");
                this.Close();

            }
            else
            {
                if (CSDL.Instance.findMSSV(dr) == -1)
                {
                    CSDL.Instance.DTSV.Rows.Add(dr);
                    MessageBox.Show("Thêm sinh viên thành công !");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("MSSV đã tồn tại!");
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gb_ttsv_Enter(object sender, EventArgs e)
        {

        }
    }
}
