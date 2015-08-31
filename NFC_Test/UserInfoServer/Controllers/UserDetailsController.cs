using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;
using UserInfoServer.Models;

namespace UserInfoServer.Controllers
{
    public class UserDetailsController : ApiController
    {
        private ApplicationUserManager _userManager;
        private UserNfcContext _userNfcContext = new UserNfcContext();

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        // GET: api/UserDetails/5
        public string Get(string nfc)
        {
            var userNfc = _userNfcContext.UserNfcs.FirstOrDefault(un => un.Nfc == nfc);
            if (userNfc != null) 
            {
                var user = UserManager.FindById(userNfc.UserId);
                return user.Email;
            }

            return string.Empty;
        }
    }
}
