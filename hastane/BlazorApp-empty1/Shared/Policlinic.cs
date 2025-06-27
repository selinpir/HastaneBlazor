using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hastane.Shared
{
    public class Policlinic
    {
        [Key]
        public int Id { get; set; }
        public string PoliclinicName { get; set; }
    }
}
