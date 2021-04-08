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
            dr["MSSV"] = "102190184";

            dr["NameSV"] = "Trần Thị Phượng";
            dr["Gender"] = true;
            DateTime birth = new DateTime(2001, 07, 22);
            dr["Birthday"] = birth;
            dr["ID_Class"] = "1";
            DataRow dr2 = DTSV.NewRow();
            dr2["MSSV"] = "102190123";
            dr2["NameSV"] = "Lê Hoàng Ngọc Hân";
            dr2["Gender"] = true;
            DateTime birth2 = new DateTime(2001, 06, 06);
            dr2["Birthday"] = birth2;
            dr2["ID_Class"] = "2";
            DataRow dr3 = DTSV.NewRow();
            dr3["MSSV"] = "102190271";
            dr3["NameSV"] = "Trương Mỹ Duyên";
            dr3["Gender"] = false;
            DateTime birth3 = new DateTime(2001, 04, 27);
            dr3["Birthday"] = birth3;
            dr3["ID_Class"] = "2";
            DataRow dr4 = DTSV.NewRow();
            dr4["MSSV"] = "102381223";
            dr4["NameSV"] = "Võ Văn Thành";
            dr4["Gender"] = false;
            DateTime birth4 = new DateTime(2001, 04, 27);
            dr4["Birthday"] = birth3;
            dr4["ID_Class"] = "3";
            DTSV.Rows.Add(dr);
            DTSV.Rows.Add(dr2);
            DTSV.Rows.Add(dr3);
            DTSV.Rows.Add(dr4);
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
        public DataTable cloneDataSV(DataTable dt)
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
        public DataTable cloneDataLSH(DataTable dt)
        {
            dt.Columns.AddRange(new DataColumn[]
           {
                new DataColumn("ID_Class", typeof(int)),
                new DataColumn("NameClass", typeof(String)),

           });

            foreach (DataRow i in DTSV.Rows)
            {
                DataRow dr = dt.NewRow();
                dr["ID_Class"] = i["ID_Class"];
                dr["NameClass"] = i["NameClass"];
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
}
