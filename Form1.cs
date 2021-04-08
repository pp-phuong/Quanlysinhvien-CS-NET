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
        DialogResult result;

        public QLSV()
        {
            InitializeComponent();
            SetCbbLSH();
            SetCbbSort();
            show();
        }
        public void SetCbbLSH()
        {
            cbbLopSH.Items.Add("All");
            foreach (LSH i in CDSL_Handle.Instance.ListLSH)
            {
                cbbLopSH.Items.Add(i.getName());
            }
            cbbLopSH.Text = "All";

        }
        public void SetCbbSort()
        {
            SV s = new SV();

            foreach (var property in s.GetType().GetProperties())
            {
                cbb_sort.Items.Add(property.Name);
            }
            cbb_sort.Text = "Chọn kiểu sắp xếp";
        }
        private void show()
        {
            int ID_Class = getIdClassCurrent();
            
            dataGridViewDSSV.DataSource = CDSL_Handle.Instance.getSVbyClassID(ID_Class);

            dataGridViewDSSV.Refresh();
            if (CDSL_Handle.Instance.getSVbyClassID(ID_Class).Count == 0)
            {
                MessageBox.Show("Không có sinh viên nào !");
            }
        }
        private void btn_show_Click(object sender, EventArgs e)
        {
            show();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
                DetailSV f = new DetailSV();
                f.delegateType(-1, 0);
                f.Show();
                cbbLopSH.Text = "All";
                show();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridViewDSSV.SelectedRows[0];
            // get mssv of sv
            int mssv = Convert.ToInt32(dr.Cells["MSSV"].Value);
            // get class id of sv
            int id_class = Convert.ToInt32(dr.Cells["ClassID"].Value);
            DetailSV f = new DetailSV();
            f.delegateType(mssv, id_class);
            f.Show();
            show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridViewDSSV.SelectedRows;
            // check xem đã chọn full row nào chưa
            if (r == null || r[0].Cells["MSSV"].Value == null)
            {
                MessageBox.Show("Vui lòng chọn SV để xóa !");

            }
            else
            {
                string s = "";
                foreach (DataGridViewRow i in r)
                {   
                    // check nếu row chưa được chọn
                    s += i.Cells["NameSV"].Value.ToString() + " ";
                    if (i.Cells == null)
                    {
                        MessageBox.Show("Vui lòng chọn toàn bộ nội dung SV để xóa !");
                    }
                    else
                    {
                         result = MessageBox.Show("Bạn chắc chắn muốn xóa sinh viên " + s + " ?", "Confirmation", MessageBoxButtons.YesNo);
                    }
                    if ( result == DialogResult.Yes)
                    {
                        // get mssv hiện tại để xóa sv theo id
                        int mssv = Convert.ToInt32( i.Cells["MSSV"].Value);
                        CDSL_Handle.Instance.deleteSV(mssv);
                        MessageBox.Show("Xóa thành công!");
                        btn_show_Click(sender, e);
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
                List<SV> l = new List<SV>();
                // get current class id for sort in that class
                int class_id = getIdClassCurrent();
                CDSL_Handle.Instance.sortSV(cbb_sort.SelectedItem.ToString(), l, class_id);
                dataGridViewDSSV.DataSource = l;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn kiểu sắp xếp !");
            }

        }

     
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            search();
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        }
        private void search()
        {
          
            if (cbb_search_type.SelectedItem != null)
            {
                string type = cbb_search_type.SelectedItem.ToString();
                string search_key = txt_search.Text;
                int class_id = getIdClassCurrent();
                dataGridViewDSSV.DataSource = CDSL_Handle.Instance.searchSV(type, search_key, class_id); 
            }
            else
            {
                MessageBox.Show("Vui lòng chọn và nhập nội dung tìm kiếm !");
            }
        }
       
        private void cbbLopSH_SelectedIndexChanged(object sender, EventArgs e)
        {
            show();
        }
        private int getIdClassCurrent()
        {
            string nameClass = cbbLopSH.Text;
            int ID_Class = 0;
            if( nameClass == "All")
            {
                ID_Class = 0;
            }    
            else
            {
                ID_Class = CDSL_Handle.Instance.getIDLSH(nameClass);
            }
            return ID_Class;
        }

        
    }
}
