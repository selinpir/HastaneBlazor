//bir interfacedir
using hastane.Shared;

namespace hastane.Server.Services.ForAuth
{
    public interface IAuthService /*class degil interface yapmalıyız*/
    {
        Task<ServiceResponse<int>> Register(User users, string password);
        //yeni bir kullanıcıyı sisteme kaydeder
        Task<ServiceResponse<string>> Login(string email, string password);
        //kullanıcının giriş yapmasını sağlar
      
        Task<ServiceResponse<bool>> SelectAdmin(string email);
        //verilern e posta adresine sahip kullanıcıya admin yetkisi veriri
        //bool : işlem başarılı ise true, başarısız ise false döndürür
        int GetUserId();
        //sisteme şuan giriş yapan kullanıcının ıd sini döner
        string GetUserEmail();
        //sisteme şuan giriş yapan kullanıcının emailini sini döner
    }
}
