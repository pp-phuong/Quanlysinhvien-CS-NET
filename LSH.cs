using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class LSH
    {
        public string NameClass { get; set; }
        public int  ID_Class { get; set; }

        public LSH()
        {
            NameClass = "1";
            ID_Class = 1;

        }
        public override string ToString()
        {
            return "id:" + ID_Class + ", NameCLass:" + NameClass;
        }
        public LSH(string name, int id)
        {
            NameClass = name;
            ID_Class = id;
        }
        public string getName()
        {
            return NameClass;
        }
        public int getID()
        {
            return ID_Class;
        }
    }
}
