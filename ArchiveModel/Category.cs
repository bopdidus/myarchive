using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiveModel
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Category(string name)
        {
            Name = name;
        }

        public Category()
        {
        }

        public Category(Category category)
        {
            this.Id = category.Id;
            this.Name = category.Name;
        }

        public override string? ToString()
        {
            return this.Name;
        }

        public override bool Equals(object? obj)
        {
            return obj is Category category &&
                   Name == category.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }
    }
}
