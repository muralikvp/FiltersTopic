using Microsoft.AspNetCore.Mvc;
using Starter.Filters;
using System;

namespace Starter.Controllers
{
    //HopeTutors/Student/AddStudent
    //HopeTutors/Student/UpdateStudent/12
    //HopeTutors/Student/UpdateStudent/
    //HopeTutors/Student/DeleteStudent/12

    [Route("Hope/[controller]")]
    public class StudentController : Controller
    {
        [HttpGet]
        [Route("AddStudent")]
        public string AddStudent()
        {
            return "Add Student";
        }

        [HttpGet]
        [Route("UpdateStudent")]
        public string UpdateStudent()
        {
            return "Update Student";
        }

        [AsyncFilter("Delete Student")]
        [HttpGet]
        [Route("DeleteStudent")]
        public string DeleteStudent()
        {
            return "Delete Student";
        }
    }
}
