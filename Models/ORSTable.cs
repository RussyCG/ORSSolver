using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ORSTable
    {
        private List<ORSRow> rows;
        private List<ORSColumn> columns;

        public ORSTable()
        {

        }
        
        public List<ORSColumn> Columns
        {
            get { return columns; }
            set { columns = value; }
        }

        public List<ORSRow> Rows
        {
            get { return rows; }
            set { rows = value; }
        }

        public void Add(ORSRow rowToAdd)
        {

        }

        public void Add(ORSColumn columnToAdd)
        {

        }
    }
}
