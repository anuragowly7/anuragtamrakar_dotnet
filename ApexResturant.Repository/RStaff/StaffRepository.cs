using ApexResturant.Repository.Domain;
namespace ApexResturant.Repository.RStaff
{
   public class StaffRepository : GenericRepository<Staff>, IStaffRepository 
   { 
        public StaffRepository(ResturantContext dbContext) 
        {
            DbContext = dbContext; 
        }

    }
}