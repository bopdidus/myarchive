using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiveModel
{
    public class Archive
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public DateTime ReceptionDate { get; set; }
        public string ArchiveFile { get; set; }
        public Category GetCategory { get; set; }
    }
}
