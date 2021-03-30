using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLSV
{
    class CSDL
    {
        public DataTable DTSV { get; set; }
        public DataTable DTLSH { get; set; }
        internal static CSDL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CSDL();
                }
                return _Instance;

            }
            private set
            {
            }
        }
        private static CSDL _Instance;
        private CSDL()
        {
            DTSV = new DataTable();
            DTSV.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("MSSV", typeof(String)),
                new DataColumn("NameSV", typeof(String)),
                new DataColumn("Gender", typeof(bool)),
                new DataColumn("Birthday", typeof(DateTime)),
                new DataColumn("ID_Class", typeof(int))
            });

            DataRow dr = DTSV.NewRow();
            dr["MSSV"] = "1";

            dr["NameSV"] = "Trần Thị Phượng";
            dr["Gender"] = true;
            DateTime birth = new DateTime(2001, 07, 22);
            dr["Birthday"] = birth;
            dr["ID_Class"] = "1";
            DataRow dr2 = DTSV.NewRow();
            dr2["MSSV"] = "2";
            dr2["NameSV"] = "Lê Hoàng Ngọc Hân";
            dr2["Gender"] = true;
            DateTime birth2 = new DateTime(2001, 06, 06);
            dr2["Birthday"] = birth2;
            dr2["ID_Class"] = "2";
            DataRow dr3 = DTSV.NewRow();
            dr3["MSSV"] = "3";
            dr3["NameSV"] = "Trương Mỹ Duyên";
            dr3["Gender"] = false;
            DateTime birth3 = new DateTime(2001, 04, 27);
            dr3["Birthday"] = birth3;
            dr3["ID_Class"] = "2";

            if (findMSSV(dr) == -1)
            {
                DTSV.Rows.Add(dr);
            }
            if (findMSSV(dr2) == -1)
            {
                DTSV.Rows.Add(dr2);
            }

            if (findMSSV(dr3) == -1)
            {
                DTSV.Rows.Add(dr3);
            }

            // data lớp sinh hoạt
            DTLSH = new DataTable();
            DTLSH.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID_Class", typeof(int)),
                new DataColumn("NameClass", typeof(String)),

            });
            DataRow dr_ = DTLSH.NewRow();
            dr_["ID_Class"] = "1";
            dr_["NameClass"] = "19TCLC_DT4";
            DataRow dr_2 = DTLSH.NewRow();
            dr_2["ID_Class"] = "2";
            dr_2["NameClass"] = "19TCLC_DT5";
            DataRow dr_3 = DTLSH.NewRow();
            dr_3["ID_Class"] = "3";
            dr_3["NameClass"] = "19TCLC_DT6";

            DTLSH.Rows.Add(dr_);
            DTLSH.Rows.Add(dr_2);
            DTLSH.Rows.Add(dr_3);

        }

        public DataTable getSVbyClassID(int class_ID)
        {
            DataTable DTSV_classID = new DataTable();
            DTSV_classID.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("MSSV", typeof(String)),
                new DataColumn("NameSV", typeof(String)),
                new DataColumn("Gender", typeof(bool)),
                new DataColumn("Birthday", typeof(DateTime)),
                new DataColumn("ID_Class", typeof(int))
            });

            foreach (DataRow i in DTSV.Rows)
            {
                if (Convert.ToInt32(i["ID_Class"].ToString()) == class_ID)
                {
                    DataRow dr = DTSV_classID.NewRow();
                    dr["MSSV"] = i["MSSV"];
                    dr["NameSV"] = i["NameSV"];
                    dr["Gender"] = i["Gender"];
                    dr["Birthday"] = i["Birthday"];
                    dr["ID_Class"] = i["ID_Class"];
                    DTSV_classID.Rows.Add(dr);
                }
            }

            return DTSV_classID;
        }
        public DataRow getSVbyMSSV(string mssv)
        {
            foreach (DataRow i in DTSV.Rows)
            {
                if (i["MSSV"].ToString() == mssv)
                {
                    return i;
                }
            }
            return DTSV.Rows[0];
        }
        public void updateSV(DataRow i)
        {
            DataRow dr = getSVbyMSSV(i["MSSV"].ToString());
            dr["NameSV"] = i["NameSV"];
            dr["Gender"] = i["Gender"];
            dr["Birthday"] = i["Birthday"];
            dr["ID_Class"] = i["ID_Class"];
        }
        public DataRow getIDLSH(int index)
        {
            return DTLSH.Rows[index];
        }
        public int getIDLSH(string name)
        {
            foreach (DataRow i in DTLSH.Rows)
            {
                if (i["NameClass"].ToString() == name)
                {
                    return Convert.ToInt32(i["ID_Class"].ToString());
                }
            }
            return 0;
        }
        public void delSVbyMSSV(string id)
        {
            foreach (DataRow i in DTSV.Rows)
            {
                if (i["MSSV"].ToString() == id)
                {
                    DTSV.Rows.Remove(i);
                    return;
                }
            }
        }
        public DataTable cloneData(DataTable dt)
        {
            dt.Columns.AddRange(new DataColumn[]
           {
                new DataColumn("MSSV", typeof(String)),
                new DataColumn("NameSV", typeof(String)),
                new DataColumn("Gender", typeof(bool)),
                new DataColumn("Birthday", typeof(DateTime)),
                new DataColumn("ID_Class", typeof(int))
           });

            foreach (DataRow i in DTSV.Rows)
            {
                DataRow dr = dt.NewRow();
                dr["MSSV"] = i["MSSV"];
                dr["NameSV"] = i["NameSV"];
                dr["Gender"] = i["Gender"];
                dr["Birthday"] = i["Birthday"];
                dr["ID_Class"] = i["ID_Class"];
                dt.Rows.Add(dr);
            }
            return dt;

        }
        public DataTable sortSV(string type, DataTable dt)
        {
            dt =  cloneData(dt);
            type += " ASC";
            dt.DefaultView.Sort = type;
            dt = dt.DefaultView.ToTable();



            return dt;
        }
        public DataTable searchSV(string type, string search_key)
        {
            DataTable search_DTSV = new DataTable();
            search_DTSV.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("MSSV", typeof(String)),
                new DataColumn("NameSV", typeof(String)),
                new DataColumn("Gender", typeof(bool)),
                new DataColumn("Birthday", typeof(DateTime)),
                new DataColumn("ID_Class", typeof(int))
            });

            //foreach (DataRow i in DTSV.Rows)
            //{
            //    if  ( i[type].ToString() == search_key)
            //    {
            //        DataRow dr = search_DTSV.NewRow();
            //        dr["MSSV"] = i["MSSV"];
            //        dr["NameSV"] = i["NameSV"];
            //        dr["Gender"] = i["Gender"];
            //        dr["Birthday"] = i["Birthday"];
            //        dr["ID_Class"] = i["ID_Class"];
            //        search_DTSV.Rows.Add(dr);
            //    }

            //}
            DataRow[] filteredRow = DTSV.Select(type + " like '%" + search_key + "%'");
            foreach (DataRow i in filteredRow)
            {
                DataRow dr = search_DTSV.NewRow();
                dr["MSSV"] = i["MSSV"];
                dr["NameSV"] = i["NameSV"];
                dr["Gender"] = i["Gender"];
                dr["Birthday"] = i["Birthday"];
                dr["ID_Class"] = i["ID_Class"];
                search_DTSV.Rows.Add(dr);
            }
            return search_DTSV;
        }
        public int findMSSV(DataRow d)
        {
            foreach (DataRow i in DTSV.Rows)
            {
                if (i["MSSV"].ToString() == d["MSSV"].ToString())
                {
                    return Convert.ToInt32(i["MSSV"].ToString());
                }
            }
            return -1;
        }
    }
}
