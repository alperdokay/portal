using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FRC.Portal.Data.Domains;
using FRC.Portal.Services.Services;

namespace FRC.Portal.Web.Controllers
{
    public class TeamController : Controller
    {
        // GET: Team
        TeamService teamService = new TeamService();
        AccountService accountService = new AccountService();
        public ActionResult Index()
        {
            List<Team> teams = teamService.GetTeams();
            return View(teams);
        }

        public ActionResult Create()
        {
            List<Account> _users = accountService.GetAccounts();
            var users = _users.ToList().Select(c => new SelectListItem
            {
                Selected = false,
                Text = c.FullName,
                Value = c.Id.ToString()
            }).ToList();
            ViewBag.Users = users;
            return View();
        }
        [HttpPost]
        public ActionResult Create(Team _team)
        {
            if (teamService.Insert(_team))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Create");
            }
        }
        public ActionResult Update(int Id)
        {
            Team _team = teamService.Select(Id);
            List<Account> _users = accountService.GetTeamUsers();
            var users = _users.ToList().Select(c => new SelectListItem
            {
                Selected = false,
                Text = c.FullName,
                Value = c.Id.ToString()
            }).ToList();
            ViewBag.Users = users;
            return View(_team);
        }
    }
}