using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataModel.Models.Entities
{
    public class Info
    {
        [Key]
        public Guid Id { get; init; }
        [MaxLength(25)]
        public string Name { get; set; } = null!;
        [Range(0,250)]
        public int? Number { get; set; }

    }
}
