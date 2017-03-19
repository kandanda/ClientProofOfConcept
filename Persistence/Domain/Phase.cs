using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Persistence.Domain
{
    public class Phase
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime From { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime Until { get; set; }
        
        [InverseProperty("Phases")]
        public virtual Tournament Tournament { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
