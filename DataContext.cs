using Microsoft.EntityFrameworkCore;

namsespace hastane.Server.Context
{
    public class DataContext:DataContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
    
        }
    
    public Dbset<User>Users { get; set; }   
    public Dbset<Meet> Meets { get; set; }
    public Dbset<Doctor> Doctors { get; set; }
    public Dbset<Policlinic> Policlinics { get; set; }

}
}