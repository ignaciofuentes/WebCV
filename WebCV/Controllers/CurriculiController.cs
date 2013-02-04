using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebCV.Models;

namespace WebCV.Controllers
{
    public class CurriculaController : ApiController
    {
        public Curriculum Get()
        {
            return new Curriculum
            {
                Name = "Ignacio Andrés Fuentes",
                BasicInfoItems = new SerializableDictionary {
                    {"Place of Birth", "Caracas, Venezuela"},
                    {"Language", "Spanish (native), English"},
                    {"Address", "Carrera 16 #94-14 Bogotá, Colombia."},
                    {"Home-Phone", "+5714611427 "},
                    {"Mobile-Phone", "+573102603473 "},
                    {"E-Mail", "nacho10f@gmail.com"}
                },
                ExperienceItems = new List<ExperienceItem> { 
                     new ExperienceItem{
                        CompanyName ="Viitru Colombia",
                        Location= "Bogotá, DF. Colombia.",
                        Timeframe ="October 2012 - Present",
                        JobDescription="Added to the responsibilities I maintain as the software architect, I am responsible for providing input on the technical aspect of every major decision of the company. As we are currently shifting the focus of the company to the development of mobile apps, I am in charge of selecting the tools our different teams will use (although most technical decisions are made as a team, I hold the final word in cases of discrepancies). Proper training of our staff, high quality standards and meeting deadlines for our projects are all part of my review criteria as CTO. ",
                        JobTitle="Software Architect"
                    },
                    new ExperienceItem{
                        CompanyName ="Viitru",
                        Location= "Caracas, Miranda. Venezuela.",
                        Timeframe ="April 2011 - October 2012",
                        JobDescription="It is my responsibility to do the necessary research (followed by training my coworkers) on the technologies "+
                                        "we use to build our application. As a software architect I made the important choices of developing using the "+
                                        "Microsoft stack with the addition of many open source .net products. Specifically, ASP.NET MVC and WEB API, MS SQL Server, "+
                                        "Entity Framework, Automapper, Ninject, Nuget, jquery, KnockoutJS, Twitter Bootstrap and Appharbor. I am also responsible "+
                                        "of structuring our app (solution) in a way that we can keep a sane separation of concerns without losing focus on "+
                                        "the importance of shipping our product in a timely fashion.",
                        JobTitle="Software Architect"
                    },
                    new ExperienceItem{
                        CompanyName ="TuColegionline",
                        Location= "Caracas, Miranda. Venezuela.",
                        Timeframe ="March 2010 – April 2011",
                        JobDescription="A partner and I co-founded TuColegionline.com which is a school management system targeting Venezuelan schools. My role was to build the software from a backend perspective. We developed it using Ruby on Rails and many ruby oriented open source projects. This company has now been renamed to Akdemia since my leaving.",
                        JobTitle="Co-Founder/Developer"
                    },
                    new ExperienceItem{
                        CompanyName ="Ramar Consultores",
                        Location= "Caracas, Miranda. Venezuela.",
                        Timeframe ="May 2009 – Septemeber 2009",
                        JobDescription="This was an internship position. I developed a mobile project management web application for a client that needed a custom solution to keep track of many construction projects. This web application was developed using PHP and the CodeIgniter MVC framework.",
                        JobTitle="Software Analyst"
                    }


                },
                EduactionItems = new SerializableDictionary { 
                    {"University", "Systems Engineering. Universidad Metropolitana (2005-2011), Caracas, Venezuela."}
                },
                SkillsParagraphs = new ParagraphList { 
                    "In web software development it is paramount to keep track of several types of technologies to actually be able to build complete and compelling software. This includes both front-end and back-end technologies. Throughout the last few years, I have developed experience with a myriad of .Net back-end technologies such as ASP.NET MVC, ASP.NET WEB API (Rest, HTTP), C#, Entity Framework, Linq-To-Sql, SQL Server 2008, AutoMapper, Ninject, MSTest, NUnit and Specflow. I have also had the chance to work with several open source back-end technologies like Ruby-On-Rails, Active Record, RSpec, Cucumber, PHP, CodeIgniter, MySQL and PostgreSQL. Added to this, I have developed moderate experience using several front-end technologies, including but not limited to HTML5, Javascript, CSS, jQuery, Knockout.JS, Backbone.JS, JSRender, Twitter Bootsrap and jQuery UI.",
                    "For backend development I try to keep a clean separation of concerns using (whenever is prudent) a Domain Driven Design (using Eric Evans book as reference) along with MVC (Restful if possible) as a delivery mechanism. I like to build software using TDD and BDD, making sure my tests have good code coverage.",
                    "For front-end development I favor clean HTML markup with unobtrusive javascript. For complex UIs I tend to follow the MVVM (Model-View-ViewModel) pattern recommended by the Knockout.JS Javascript framework, with the addition of following a Revealing Module Pattern to structure my code.",
                    "For collaborative development environments I have experience with Git, Github, SCRUM and PivotalTracker." 
                }

            };
        }
    }
}
