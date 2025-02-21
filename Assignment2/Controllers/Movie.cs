using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    public class Movie : Controller
    {
        //public ContentResult GetMovie(int id , string title)
        //{
            

        //    ContentResult result = new ContentResult();

        //    result.Content = $"Movie with ID :{id} , Title :{title}";


        //    result.ContentType="text/html" ;    


        //    return result;
        //}


        public IActionResult GetMovie(int id,string title)
        {


            if (id < 10)
                return BadRequest();


            return Content($"Movie with ID :{id} , Title :{title}","text/html");
        }
    }
}
