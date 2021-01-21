using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom_Project_Telnov
{
    class Table
    {
        public static int line { get; set; }

        private string timeactual;
        private string table;
        private string waiter;
        private string guest;
        private string table_db;

        public Table(string timeactual, string table, string waiter, string guest, string table_db)
        {
            this.timeactual = timeactual;
            this.table = table;
            this.waiter = waiter;
            this.guest = guest;
            this.table_db = table_db;
        }
        
    }
}
