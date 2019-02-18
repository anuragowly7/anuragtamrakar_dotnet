using ApexResturant.Repository.Domain;
using ApexResturant.Repository.RStaff;

namespace ApexResturant.Services.SStaff
{
    public class StaffService : GenericService<Staff>, IStaffService
    {
        public StaffService(IStaffRepository staffRepository) : base(staffRepository)
        {
                
        }
    }
}
