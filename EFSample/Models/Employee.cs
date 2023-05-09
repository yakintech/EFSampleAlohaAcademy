using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSample.Models
{
    public class Employee : BaseModel
    {
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }


        [MaxLength(100)]
        public string Surname { get; set; }

        public DateTime BirthDate { get; set; }

        public int CityId { get; set; }

        [ForeignKey("CityId")]
        public City City { get; set; }
    }
}
