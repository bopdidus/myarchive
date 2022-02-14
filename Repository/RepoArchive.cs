using ArchiveModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepoArchive : ICRUD<Archive>
    {
        public Archive Create(Archive obj)
        {
            Archive entityArchive = new Archive();
            using (var db = new ArchiveContext())
            {
                entityArchive = db.Archives.Add(obj).Entity;
                db.SaveChanges();
            }
            return entityArchive;
        }

        public void Delete(Archive obj)
        {
            using (var db = new ArchiveContext())
            {
                db.Archives.Remove(obj);
                db.SaveChanges();
            }
        }

        public ICollection<Archive> GetAll()
        {
            using (var db = new ArchiveContext())
            {
                return db.Archives.ToList();
            }
        }

        public Archive Update(Archive obj)
        {
            Archive entityArchive = new Archive();

            using (var db = new ArchiveContext())
            {
                entityArchive = db.Archives.Update(obj).Entity;
                db.SaveChanges();
            }
            return entityArchive;
        }
    }
}
