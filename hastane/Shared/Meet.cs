using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hastane.Shared
{
    public class Meet
    {
        [Key]
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int? UserId { get; set; }
        public DateTime CreatedMeet { get; set; } = DateTime.UtcNow;
        public string? DoctorName { get; set; }
        public string? PoliclinicName { get; set; }
        public DateTime MeetDate { get; set; } /* gün ay yıl*/
        [Required(ErrorMessage = "Lütfen randevu saati seçiniz!")]
        public TimeSpan MeetTime { get; set; } /*saat*/
        public bool Status { get; set; } = true;
    }
}
