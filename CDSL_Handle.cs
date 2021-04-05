using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class CDSL_Handle
    {
        public List<SV> ListSV { get; set; }
        public List<LSH> ListLSH { get; set; }
        public delegate bool Compare(object a, object b);
        public Compare cmp;
        private static CDSL_Handle _Instance;

        internal static CDSL_Handle Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CDSL_Handle();
                }
                return _Instance;

            }
            private set
            {
            }
        }
        private CDSL_Handle()
        {

            ListSV = new List<SV>();
            foreach( DataRow i in CSDL.Instance.DTSV.Rows)
            {
                
                ListSV.Add(createSV(i));
            }
            ListLSH = new List<LSH>();
            foreach ( DataRow i in CSDL.Instance.DTLSH.Rows)
            {

                ListLSH.Add(createLSH(i));
            }    
        }
        public SV createSV(DataRow i)
        {
            SV s = new SV();
            s.MSSV = Convert.ToInt32(i["MSSV"].ToString());
            s.NameSV = i["NameSV"].ToString();
            s.Gender = Convert.ToBoolean(i["Gender"].ToString());
            s.Birthday = Convert.ToDateTime(i["Birthday"].ToString());
            s.ClassID = Convert.ToInt32(i["ID_Class"].ToString());
            return s;
        }   
        public LSH createLSH(DataRow i )
        {
            LSH l = new LSH();
            l.ID_Class = Convert.ToInt32(i["ID_Class"].ToString());
            l.NameClass = i["NameClass"].ToString();
            return l;
        }
        
        public void updateSV(SV s)
        {
            int index = findIndexByMSSV(s.MSSV);
            SV sv = ListSV[index];
            sv.NameSV = s.NameSV;
            sv.Gender = s.Gender;
            sv.Birthday = s.Birthday;
            sv.ClassID = s.ClassID;
        }

        public bool addSV(SV s)
        {
            if (findIndexByMSSV(s.MSSV) == -1)
            {
                ListSV.Add(s);
                return true;
            }
            else
            {
                return false;
            }                
        }
        public void deleteSV(int mssv)
        {
            foreach (SV i in ListSV)
            {
                if (i.MSSV == mssv)
                {
                    ListSV.Remove(i);
                    return;
                }
            }
        }

        public List<SV> sortSV(string type, List<SV> l, int classID)
        {
            if ("Birthday" == type)
            {
                cmp = SV.Compare_Birth;
            }
            if ("MSSV" == type)
            {
                cmp = SV.Compare_MSSV;
            }
            if ("NameSV" == type)
            {
                cmp = SV.Compare_Name;
            }
            if ("ClassID" == type)
            {
                cmp = SV.Compare_ClassID;
            }
            if ("Gender" == type)
            {
                cmp = SV.Compare_Gender;
            }
            foreach (SV i in getSVbyClassID(classID))
            {
                l.Add(i);
            }
            for (int i = 0; i < l.Count; i++)
            {
                for (int j = i + 1; j < l.Count; j++)
                {
                    if (cmp(l[j], l[i]))
                    {
                        SV temp = new SV();
                        temp = l[i];
                        l[i] = l[j];
                        l[j] = temp;
                    }
                }
               
            }
            return l;
        }
        public List<SV> searchSV(string type, string search_key, int class_id)
        {
            List<SV> l = new List<SV>();
            List<SV> result = new List<SV>();
           
            if (class_id != -1 )
            {
                l = getSVbyClassID(class_id);
            }
            else
            {
                l = cloneDataSV(l);
            }
            if (search_key == "")
            {
                return l;
            }
            if ("MSSV" == type)
            {
                result = l.FindAll(i => i.MSSV == Convert.ToInt32(search_key));
            }
            if ("NameSV" == type)
            {
                //result = ListSV.FindAll(i => i.NameSV.Contains(search_key));
                foreach (SV s in l)
                {
                    if (s.NameSV.Contains(search_key))
                    {
                        result.Add(s);
                    }
                }
            }
            
           
            return result;
        }
        public int getIndexLSH(int id)
        {
            return ListLSH.IndexOf(getLSHById(id));
        }
        public int getIDLSH(string name)
        {
            foreach (LSH i in ListLSH)
            {
                if (i.NameClass == name)
                {
                    return i.ID_Class;
                }
            }
            return 0;
        }
        public LSH getLSHById(int id)
        {
            foreach (LSH i in ListLSH)
            {
                if (i.ID_Class == id)
                {
                    return i;
                }
            }
            return null;
        }
        public List<SV> getSVbyClassID(int class_ID)
        {
            List<SV> list = new List<SV>();

            if (class_ID == 0)
            {
                list = cloneDataSV(list);
            }
            else
            {
                foreach (SV i in ListSV)
                {
                    if (i.ClassID == class_ID)
                    {
                        list.Add(i);
                    }
                }
            }
            return list;
        }
        public SV getSVbyMSSV(int mssv)
        {
            foreach (SV i in ListSV)
            {
                if (i.MSSV == mssv)
                {
                    return i;
                }
            }
            return null;
        }

        public int findIndexByMSSV(int mssv)
        {
            foreach (SV i in ListSV)
            {
                if (i.MSSV == mssv)
                {
                    return ListSV.IndexOf(i);
                }
            }
            return -1;
        }
        public List<SV> cloneDataSV(List<SV> l)
        {
            l = new List<SV>();
            foreach (SV i in ListSV)
            {

                l.Add(i);
            }
            return l;

        }
        public  List<LSH> cloneDataLSH(List<LSH> l)
        {
            l = new List<LSH>();
            foreach (LSH i in ListLSH)
            {
                l.Add(i);
            }
            return l;
        }
    }

}
