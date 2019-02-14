using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVToEntity
{
    public class Student
    {
        [CsvField(0)]
        public string Name { get; set; }
        [CsvField(1)]
        public string SchoolName { get; set; }
        [CsvField(2)]
        public string Location { get; set; }
        public int Age { get; set; }
    }
}
