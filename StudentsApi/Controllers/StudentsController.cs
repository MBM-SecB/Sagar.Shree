
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StudentsApi.Models;
[Route("api/students")]
[ApiController]
public class StudentsController : ControllerBase
{
    [HttpGet]
    [Route("id")]
    public ActionResult GetAllStudents()
    {

        var students = new string[] { "Dipesh", "Swostika" };
        students = null;
        if (students == null)
        {
            return NotFound();
        }
        return Ok(students);
    }
    [HttpGet]
    [Route("{name}")]
    public ActionResult GetStudentByName(string name)
    {
        var students = new string[] { "Sagar", "Madan" };
        var searchedStudent = students.Where((x) => x == name).FirstOrDefault();
        if (searchedStudent != null)
        {


            return Ok(searchedStudent);
        }
        return NotFound();

    }

    [HttpPost]
    [Route("{add}")]
    public ActionResult CreateStudent(Student student)
    {
        if (student == null)
            return BadRequest();

        return Created("", student);

    }
}