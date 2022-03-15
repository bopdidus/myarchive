using ArchiveModel;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class RepoArchive : ICRUD<Archive, ArchiveDTO>
    {
        public Archive Create(ArchiveDTO objDTO)
        {
            Archive entityArchive = objDTO.DtoToModel();
            using (var db = new ArchiveContext())
            {
                var cat = db.Categories.FirstOrDefault(c => c.Name == objDTO.Category);
                entityArchive.Category = (Category)cat;
                entityArchive = db.Archives.Add(entityArchive).Entity;
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

        public ICollection<ArchiveDTO> GetAll()
        {
            List<ArchiveDTO> archiveDTOs = new List<ArchiveDTO>();
            using (var db = new ArchiveContext())
            {
                foreach(Archive item in db.Archives.Include("Category").ToList() )
                {
                    ArchiveDTO archiveDTO = new ArchiveDTO();
                    archiveDTO.ModelToDTO(item);
                    archiveDTOs.Add(archiveDTO);
                }
            }

            return archiveDTOs;
        }

        public Archive GetT(ArchiveDTO obj)
        {
            using (var db = new ArchiveContext())
            {
                return db.Archives.FirstOrDefault(a => a.Id == obj.Id && a.Subject == obj.Subject && a.ArchiveFile == obj.ArchiveFile && a.Category.Name == obj.Category);
            }
        }

        public Archive Update(ArchiveDTO obj)
        {
            Archive entityArchive = obj.DtoToModel();

            using (var db = new ArchiveContext())
            {
                entityArchive = db.Archives.Update(entityArchive).Entity;
                db.SaveChanges();
            }
            return entityArchive;
        }
    }
}
