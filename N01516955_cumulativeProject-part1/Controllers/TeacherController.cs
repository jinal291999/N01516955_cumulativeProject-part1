using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01516955_cumulativeProject_part1.Controllers
{
    public class TeacherController : ApiController
    {
        //// GET: Teacher
        //public ActionResult Index()
        //{
        //    return View();
        //}

        // GET: Teacher/List
        //showing a page of all teacher information
        [Route("/Teacher/List/{SearchKey}")]
        public ActionResult List(string SearchKey)
        {
            Debug.WriteLine(SearchKey);
            //connect a data access layer
            TeacherDataController controller = new TeacherDataController();

            List<Teacher> Teachers = controller.ListTeachers(SearchKey);

            return View(Teachers);
        }

        //GET: Teacher/Show/id
        [Route("Teacher/Show/{id}")]

        public ActionResult Show(int id)
        {
            TeacherDataController controller = new TeacherDataController();

            TeacherCourse TC = controller.FindTeacher(id);

            //routes the single teacher information to Show.cshtml
            return View(TC);
        }
    }
}
