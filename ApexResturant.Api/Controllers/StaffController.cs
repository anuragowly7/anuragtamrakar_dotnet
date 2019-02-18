using ApexResturant.Repository.Domain; 
using ApexResturant.Services.SStaff; 
using Microsoft.AspNetCore.Mvc;
namespace ApexResturant.Api.Controllers
{
    
[Route("api/staff")] 
public class StaffController : ControllerBase {
private readonly IStaffService _staffService;
public StaffController(IStaffService staffservice) {
     _staffService = staffservice; 
     }
[HttpGet] 
[Route("{id}")]
public IActionResult Get([FromRoute] int id) 
{
     var staff = _staffService.GetById(id);
if (staff == null) return NotFound();
return Ok(staff);
}
[HttpGet] 
[Route("")] public IActionResult GetAll()
    { 
     var staffs = _staffService.GetAll(); return Ok(staffs); 
     }

[HttpPost] 
[Route("")] 
public IActionResult Post([FromBody] Staff model) 
{
     _staffService.Insert(model);
     return Ok();
}

[HttpPut] 
[Route("")] 
public IActionResult Put([FromBody] Staff model) 
{ 
    _staffService.Update(model); 
    return Ok(); 
    }
[HttpDelete] 
[Route("")] 
public IActionResult Delete([FromBody] Staff model) 
{ 
    _staffService.Delete(model); 
    return Ok(); 
    }

}
}