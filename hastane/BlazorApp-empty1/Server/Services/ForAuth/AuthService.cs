using hastane.Server.Context2;
using hastane.Server.Services.ForAuth;
using hastane.Shared;

namespace hastane.Server.Services.ForAuth
{
    public class AuthService : IAuthService  /*ctrl + . implement*/
    {
        //AuthService üzerine ctrl+. generate class

        //veritabanıyla baglantı icin
        private readonly DataContext _context2;
        private readonly IConfiguration _configuration;
        //middleware için
        private readonly Ihtt
        public AuthService(IConfiguration configuration, DataContext context2) 
        {
            _configuration = configuration;
            _context2 = context2;
        }

        public string GetUserEmail()
        {
            throw new NotImplementedException();
        }

        public int GetUserId()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<string>> Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<int>> Register(User users, string password)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<bool>> SelectAdmin(string email)
        {
            throw new NotImplementedException();
        }
    }
}
//AuthService sınıfının IAuthService adlı interfacei uyguladık(implement ettik)
//AuthService, IAuthService arayüzünde tanımlı tüm metotları zorunlu olarak içerip doldurmak zorundadır

//Interface'ler, bir sınıfın hangi metotları içermesi gerektiğini tanımlar ama o metotların nasıl yapılacağını söylemez.