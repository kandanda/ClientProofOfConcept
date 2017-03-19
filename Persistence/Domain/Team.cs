using System.ComponentModel.DataAnnotations;

namespace Persistence.Domain
{
    public class Team
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
