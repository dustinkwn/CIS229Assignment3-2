using CIS229Assignment3_2.Models;
using IdentityApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace IdentityApi.Controllers
{
    public class IdentityController : Controller
    {
        [HttpGet]
        public JsonResult GetIdentities()
        {
            var identities = new List<Identity>
            {
                new Identity
                {
                    Active = true,
                    Term = "Spring 2025",
                    Group = "Undergraduate",
                    Role = "Student",
                    Profile = new ProfileInfo
                    {
                        FullName = "Alice Johnson",
                        Email = "alice@mail.com",
                        StudentId = "111"
                    },
                    Permissions = new List<string> { "Library Access", "Lab Use", "Cafeteria Access" }
                },
                new Identity
                {
                    Active = false,
                    Term = "Fall 2024",
                    Group = "Graduate",
                    Role = "Inactive Student",
                    Profile = new ProfileInfo
                    {
                        FullName = "Bob Smith",
                        Email = "bob.smith@email.com",
                        StudentId = "112"
                    },
                    Permissions = new List<string> { "Transcript View" }
                },
                new Identity
                {
                    Active = true,
                    Term = "Spring 2025",
                    Group = "Staff",
                    Role = "Student Employee",
                    Profile = new ProfileInfo
                    {
                        FullName = "Carol Miller",
                        Email = "carol.miller@email.com",
                        StudentId = "113"
                    },
                    Permissions = new List<string> { "Staff Portal", "HR Access", "Library Access" }
                }
            };

            return Json(identities);
        }
        [HttpPost]
        public IActionResult PostIdentity([FromBody] Identity identity)
        {
            if (identity == null)
            {
                return BadRequest("Invalid");
            }
            return Ok(identity);
        }
    }
}
