using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Logic
    {
        private string test;
        private DataTable table;

        public Logic()
        {
            table = new DataTable();
        }

        public string Test
        {
            get
            {
                return test;
            }

            set
            {
                test = value;
            }
        }

        public DataTable Table
        {
            get
            {
                return table;
            }

            set
            {
                table = value;
            }
        }


    }
}
