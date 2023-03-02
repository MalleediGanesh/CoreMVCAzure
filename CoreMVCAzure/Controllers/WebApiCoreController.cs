using CoreMVCAzure.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCAzure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebApiCoreController : ControllerBase
    {
        private CoreContextDB db;

        public WebApiCoreController(CoreContextDB _db)
        {
            db = _db;
        }

        [HttpGet("AllDepartments")]
        public IActionResult AllDepartments()
        {
            try
            {
                var DeptList = db.Departments.ToList();
                if(DeptList!= null)
                {
                    return StatusCode(StatusCodes.Status200OK, DeptList);
                }
                else
                {
                    return StatusCode(StatusCodes.Status404NotFound, "NF");
                }
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest,ex);
            }
        }
    }
}
