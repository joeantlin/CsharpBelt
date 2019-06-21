using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BeltExam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;


namespace BeltExam.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;

        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("UserID") == null)
            {
                return RedirectToAction("Login", "Login");
            }
            return RedirectToAction("Dashboard");
        }

        [Route("dashboard")]
        [HttpGet]
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetInt32("UserID") == null)
            {
                return RedirectToAction("Login", "Login");
            }
            List<Event> allEvents = dbContext.Events
                .Include(i => i.Participants)
                .ThenInclude(j => j.User)
                .Include(i => i.Creator)
                .ToList();
            ViewBag.AllEvents = allEvents;

            // List<User> allUsers = dbContext.Users
            //     .Include(i => i.Participants)
            //     .ThenInclude(j => j.Event)
            //     .ToList();
            // ViewBag.AllUsers = allUsers;
            
            int? IntVariable = HttpContext.Session.GetInt32("UserID");
            int sessionID = IntVariable ?? default(int);
            User thisUser = dbContext.Users
                .Include(i => i.Participants)
                .ThenInclude(j => j.Event)
                .Include(i => i.Events)
                .FirstOrDefault(k => k.Id == sessionID);
            ViewBag.ThisUser = thisUser;

            return View();
        }

        [Route("info/{ID}")]
        [HttpGet]
        public IActionResult Info(int ID)
        {
            if (HttpContext.Session.GetInt32("UserID") == null)
            {
                return RedirectToAction("Login", "Login");
            }
            Event thisEvent = dbContext.Events
                .Include(i => i.Participants)
                .ThenInclude(j => j.User)
                .Include(i => i.Creator)
                .FirstOrDefault(k => k.Id == ID);
            ViewBag.ThisEvent = thisEvent;

            int? IntVariable = HttpContext.Session.GetInt32("UserID");
            int sessionID = IntVariable ?? default(int);
            User thisUser = dbContext.Users
                .Include(i => i.Participants)
                .ThenInclude(j => j.Event)
                .Include(i => i.Events)
                .FirstOrDefault(k => k.Id == sessionID);
            ViewBag.ThisUser = thisUser;

            return View();
        }

        [Route("create")]
        [HttpGet]
        public IActionResult Create()
        {
            if (HttpContext.Session.GetInt32("UserID") == null)
            {
                return RedirectToAction("Login", "Login");
            }
            return View();
        }

        [Route("add")]
        [HttpPost]
        public IActionResult Add(Event thisEvent)
        {
            
            if (ModelState.IsValid)
            {
                DateTime Today = DateTime.Now;
                if (thisEvent.Date < Today)
                {
                    ModelState.AddModelError("Date", "You can't make Events in the past?");
                    return View("Create");
                }

                int? IntVariable = HttpContext.Session.GetInt32("UserID");
                int sessionID = IntVariable ?? default(int);
                thisEvent.UserID = sessionID; 
                dbContext.Events.Add(thisEvent);
                dbContext.SaveChanges();
                int EventId = thisEvent.Id;

                return RedirectToAction("Info", new {ID = EventId});
            }
            return View("Create");
        }

        [Route("delete/{ID}")]
        [HttpGet]
        public IActionResult Delete(int ID)
        {
            Event thisEvent = dbContext.Events
                .Include(i => i.Participants)
                .ThenInclude(j => j.User)
                .FirstOrDefault(k => k.Id == ID);
            dbContext.Events.Remove(thisEvent);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [Route("newparticipant/{ID}")]
        [HttpGet]
        public IActionResult NewParticipant(int ID)
        {
            int? IntVariable = HttpContext.Session.GetInt32("UserID");
            int sessionId = IntVariable ?? default(int);

            Participant newParticipant = new Participant();
            newParticipant.UserId = sessionId;
            newParticipant.EventId = ID;
            dbContext.Participants.Add(newParticipant);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [Route("deleteparticipant/{ID}")]
        [HttpGet]
        public IActionResult DeleteParticipant(int ID)
        {
            int? IntVariable = HttpContext.Session.GetInt32("UserID");
            int sessionId = IntVariable ?? default(int);

            Participant participant = dbContext.Participants
                .SingleOrDefault(i => i.UserId == sessionId && i.EventId == ID);
            dbContext.Participants.Remove(participant);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        // [Route("edit/{ID}")]
        // [HttpGet]
        // public IActionResult Edit(int ID)
        // {
        //     List<Event> thisEvent = dbContext.Events
        //         .Include(i => i.Participants)
        //         .ThenInclude(j => j.User)
        //         .FirstOrDefault(k => k.Id == ID);

        //     return View(thisEvent);
        // }

        // [Route("update/{ID}")]
        // [HttpPost]
        // public IActionResult Update(Event form, int ID)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         Event thisEvent = dbContext.Events
        //             .Include(i => i.Participants)
        //             .ThenInclude(j => j.User)
        //             .FirstOrDefault(k => k.Id == ID);
                
        //         thisEvent = form;
        //         dbContext.Save();
        //     }
        //     return View("Edit", new {ID = ID}, thisEvent);
        // }
       
    }
}
