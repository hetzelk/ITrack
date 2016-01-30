using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ITrack.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System.Web.Security;
using System.ComponentModel.DataAnnotations;

namespace ITrack.Controllers
{
    public class RoleAssignmentController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        RoleChange usersDb = new RoleChange();

        // GET: RoleAssignment
        [HttpGet]
        public ActionResult Index()
        {
            //var roles = context.Roles.ToList();
            //var allUsers = context.Users.ToList();
            var users = Membership.GetAllUsers();
            var Model = new RoleChange
            {
                Users = context.Users.Select(x => new SelectListItem
                {
                    Value = x.UserName,
                    Text = x.UserName
                }),
                Roles = context.Roles.Select(x => new SelectListItem
                {
                    Value = x.Name,
                    Text = x.Name
                })
            };
            return View(Model);
        }



        [HttpPost]
        public void  Index([Bind(Include = "EmployeeName,Roles" )] RoleChange roleChange)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var user = UserManager.FindByName(usersDb.selectedEmployee.ToString());
            var role = Roles.GetRolesForUser(user.Id);

            UserManager.RemoveFromRole(user.Id, role[0]);

            UserManager.AddToRole(user.Id, usersDb.selectedRole.ToString());
           
        }
    }
        //[HttpPost]
        //public ActionResult Index()

    
        //[HttpPost]
        //public ActionResult Index(string selectedUser)
        //{
        //    return Content("You have selected " + selectedUser);
        //}

        //public List<ApplicationUser> userDropDownList()
        //{
        //    var UserID = User.Identity.GetUserId();
        //    string userCompany = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(UserID).Company;
        //    List<ApplicationUser> UsersOfSameCompany = new List<ApplicationUser>();
        //    List<ApplicationUser> allUsers = context.Users.ToList();
        //    foreach (var user in allUsers)
        //    {
        //        if (user.Company == userCompany)
        //        {
        //            UsersOfSameCompany.Add(user);
        //        }
        //    }
        //    return UsersOfSameCompany;
        //}
        //public List<IdentityRole> rolesDropDownList()
        //{
        //    List<IdentityRole> Roles = context.Roles.ToList();
        //    return Roles;
            
        //}
    //}
}