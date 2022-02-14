using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Archive
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public Category GetCategory { get; set; }
    }
}
