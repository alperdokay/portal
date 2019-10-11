using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FRC.Portal.Data.Domains;
using FRC.Portal.Services.Services;

namespace FRC.Portal.Web.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        /* Account Controller will be the base of Account entity
         * Now, we just need to call the methods prepared for Account instances
         * to do so, we will use Account Service :)
         *
         * In order to create page views;
         * you need to use right-click somewhere in method (between parentheses)
         * then need to choose a layout, we have it in /Views/Shared/_Layout.cshtml
        */
        AccountService accountService = new AccountService();
        public ActionResult Index()
        {
            List<Account> accounts = accountService.GetUsers();
            return View(accounts);
        }
        public ActionResult Create()
        {
            return View();
        }
        // This will be running when the user click the button to submit a task
        [HttpPost]
        public ActionResult Create(Account account)
        {
            if (accountService.Insert(account))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Create");
            }
        }
        public ActionResult Update(int id)
        {
            Account account = accountService.Select(id);
            return View(account);
        }
        [HttpPost]
        public ActionResult Update(Account account)
        {
            if (accountService.Update(account))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Update", new { id = account.Id });
            }
        }
        public ActionResult Delete(int Id)
        {
            Account account = accountService.Select(Id);
            return View(account);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int Id)
        {
            if (accountService.Delete(Id))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Delete", new { id = Id });
            }
        }
    }
}