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
    public partial class QLSV : Form
    {

        public QLSV()
        {
            InitializeComponent();
            SetCbbLSH();
            SetCbbSort();
            showAllSV();
        }
        public void SetCbbLSH()
        {
            cbbLopSH.Items.Add("All");
            foreach (DataRow i in CSDL.Instance.DTLSH.Rows)
            {
                cbbLopSH.Items.Add(i["NameClass"].ToString());
            }
            cbbLopSH.Text = "All";

        }
        public void SetCbbSort()
        {
            foreach (DataColumn i in CSDL.Instance.DTSV.Columns)
            {
                cbb_sort.Items.Add(i.ToString());
            }
            cbb_sort.Text = "Chọn kiểu sắp xếp";

        }
        private void dataGridViewDSSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btn_show_Click(object sender, EventArgs e)
        {
            if (cbbLopSH.Text == "All")
            {
                showAllSV();
            }
            else
            {
                string nameClass = cbbLopSH.Text;
                int ID_Class = CSDL.Instance.getIDLSH(nameClass);
                dataGridViewDSSV.DataSource = CSDL.Instance.getSVbyClassID(ID_Class);
            }

        }
        private void showAllSV()
        {
            dataGridViewDSSV.DataSource = CSDL.Instance.DTSV;
        }

        private void cbbLopSH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nameClass = cbbLopSH.Text;
            if (nameClass == "All")
            {
                showAllSV();
            }
            else
            {
                int ID_Class = CSDL.Instance.getIDLSH(nameClass);
                dataGridViewDSSV.DataSource = CSDL.Instance.getSVbyClassID(ID_Class);
            }
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DetailSV f = new DetailSV();
            f.delegateType("Thêm sinh viên");
            f.Show();
            cbbLopSH.Text = "All";
            showAllSV();

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridViewDSSV.SelectedRows[0];

            DetailSV f = new DetailSV();
            f.delegateType("Chỉnh sửa thông tin sinh viên");
            f.delegateEdit(dr);
            f.Show();
            cbbLopSH_SelectedIndexChanged( sender,  e);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridViewDSSV.SelectedRows;
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn SV để xóa !");

            }
            else
            {
                string s = "";
                foreach (DataGridViewRow i in r)
                {
                    s += i.Cells["NameSV"].Value.ToString() + " ";
                    if (i.Cells == null)
                    {
                        MessageBox.Show("Vui lòng chọn toàn bộ nội dung SV để xóa !");
                    }
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa sinh viên " + s + " ?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        CSDL.Instance.delSVbyMSSV(i.Cells["MSSV"].Value.ToString());
                        MessageBox.Show("Xóa thành công!");
                        s = "";
                    }
                    else
                    {
                        s = "";
                        continue;
                    }
                }
            }

        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            if (cbb_sort.SelectedItem != null)
            {
                DataTable d = new DataTable();
                CSDL.Instance.sortSV(cbb_sort.SelectedItem.ToString(), d);
                dataGridViewDSSV.DataSource = d;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn kiểu sắp xếp !");
            }

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (cbb_search_type.SelectedItem != null)
            {
                string type = cbb_search_type.SelectedItem.ToString();
                string search_key = txt_search.Text;
                dataGridViewDSSV.DataSource = CSDL.Instance.searchSV(type, search_key);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn và nhập nội dung tìm kiếm !");
            }

        }
    }
}
