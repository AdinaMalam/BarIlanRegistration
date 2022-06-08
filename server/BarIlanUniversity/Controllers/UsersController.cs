
using BarIlanUniversity.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BarIlanUniversity.Controllers
{       
    [ApiController]
    [Route("[controller]")]
    public class UsersController : Controller
    {

        [HttpPost("AddUser")]
        public async Task<IActionResult> AddUser([FromBody] User user)
        {
            int createdUser = -1;
            int createdPerson = -1;

            using (var context = new BarIlanBiologyRegistrationContext())
            {
                TinstitutionPerson tinstitutionPerson = new TinstitutionPerson()
                {
                    NvFirstName = user.firstName,
                    NvLastName = user.lastName,
                    NvEmail = user.email,
                    NvMobile = user.phone,
                    ICreatedByUserId = user.ICreatedByUserId,
                    DtCreateDate = user.DtCreateDate,
                    ILastModifyUserId = user.ILastModifyUserId,
                    DtLastModifyDate = user.DtLastModifyDate,
                    ISysRowStatus = user.ISysRowStatus

                };
                TinstitutionUser tinstitutionUser = new TinstitutionUser()
                {
                    NvUserName = user.firstName,
                    NvPassword = user.password,
                    IInstitutionId = user.IInstitutionId,
                    IInstitutionUserRoleId = user.IInstitutionUserRoleId,
                    ICreatedByUserId = user.ICreatedByUserId,
                    DtCreateDate = user.DtCreateDate,
                    ILastModifyUserId = user.ILastModifyUserId,
                    DtLastModifyDate = user.DtLastModifyDate,
                    ISysRowStatus = user.ISysRowStatus
                };
                context.TinstitutionUsers.AddAsync(tinstitutionUser);
                createdUser = await context.SaveChangesAsync();
                int id = tinstitutionUser.IUserId;
                tinstitutionPerson.IUserId = id;
                context.TinstitutionPeople.Add(tinstitutionPerson);
                createdPerson = await context.SaveChangesAsync();
            }
            if (createdUser > 0 && createdPerson >0)
            {
                return Ok(user);
            }

            return NotFound();
 


        }
        [HttpGet("GetSymbol/{schoolSymbol}")]
        public async Task<Tinstitution> GetSymbol(string schoolSymbol)
        {
            var context = new BarIlanBiologyRegistrationContext();
            var symbol = context.Tinstitutions.Where(x => x.NvSchoolSymbol == schoolSymbol).FirstOrDefault();
            if(symbol == null)
            {
                return null;
            }
            return symbol;
        }
    }
}
