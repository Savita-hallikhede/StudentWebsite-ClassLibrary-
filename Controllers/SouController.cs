using Microsoft.AspNetCore.Mvc;
using Entity;
using System;
using System.Text.Json;
using System.Xml.Serialization;
namespace StudentWebsite_ClassLibrary_.Controllers
{
    public class SouController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            //Connverting object to Json File
            /*string filePath = "C:/Users/savit/OneDrive/Desktop/StudentWebsite/StudentWebsite(ClassLibrary)/std.json";
            Std std = new Std
            {
                StdId = Guid.NewGuid(),
                StdName = "Soumya",
                ClgId = Guid.NewGuid()
            };
            
            string streamofbytes = JsonSerializer.Serialize(std, new JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText(filePath, streamofbytes);

            return View();
        }*/

            // Converting object into Json File and saving as a Xml File
            string filePath = "C:/Users/savit/OneDrive/Desktop/StudentWebsite/StudentWebsite(ClassLibrary)/std1.xml";
            Std std = new Std
            {
                StdId = Guid.NewGuid(),
                StdName = "Soumya",
                ClgId = Guid.NewGuid()
            };

            XmlSerializer serializer = new XmlSerializer(typeof(Std));
            StreamWriter streamwriter = new StreamWriter(filePath);
            serializer.Serialize(streamwriter, std);
            return View();
        }

            [Route("Hello")]

            public IActionResult Hello()
            {
                return View();
            }
        }
    }

