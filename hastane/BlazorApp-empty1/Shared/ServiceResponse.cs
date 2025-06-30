using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hastane.Shared
{
    public class ServiceResponse<T>
    {
        public T Data { get; set; }
        public string Message { get; set; } = string.Empty; /*hata veya bilgi mesajı*/
        public bool Success { get; set; } = false; /*işlem başarılı mı?*/
    }
}
