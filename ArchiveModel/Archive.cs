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
        public virtual Category Category { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Archive archive &&
                   Subject == archive.Subject &&
                   ReceptionDate == archive.ReceptionDate &&
                   EqualityComparer<Category>.Default.Equals(Category, archive.Category);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Subject, ReceptionDate, ArchiveFile, Category);
        }
    }
}
