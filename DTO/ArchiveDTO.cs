using ArchiveModel;

namespace DTO
{
    public class ArchiveDTO
    {
        public int? Id { get; set; }
        public string Subject { get; set; }
        public DateTime ReceptionDate { get; set; }
        public string ArchiveFile { get; set; }
        public string Category { get; set; }

        public Archive DtoToModel()
        {
            if (this == null)
                return null;

            Archive archive = new Archive();
            archive.Id = this.Id ?? 0;
            archive.Subject = this.Subject;
            archive.ArchiveFile = this.ArchiveFile;
            archive.ReceptionDate = this.ReceptionDate;
            archive.Category = new Category(this.Category);

            return archive;
            
        }

        public void ModelToDTO(Archive archive)
        {
          
            this.Id = archive.Id;
            this.Subject = archive.Subject;
            this.ArchiveFile = archive.ArchiveFile;
            this.ReceptionDate = archive.ReceptionDate;
            this.Category = archive.Category.Name;

        }
    }
}