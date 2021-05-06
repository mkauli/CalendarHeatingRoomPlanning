using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace CalendarHeatingRoomPlanningUI
{
    /// <summary>
    /// This class manages the login/logout.
    /// </summary>
    public class Authentification
    {
        /// <summary>
        /// Used for lazy initialization
        /// </summary>
        private static readonly Lazy<Authentification>
                lazy = new Lazy<Authentification>(() => new Authentification());

        /// <summary>
        /// Used to access the singleton
        /// </summary>
        public static Authentification Instance { get { return lazy.Value; } }

        public Authentification()
        {
        }

        /// <summary>
        /// Sets the current login status
        /// </summary>
        /// <param name="status">True: login was performed valid ; False: login was not performed</param>
        public void SetLoginStatus(HttpContext httpContext, Boolean status)
        {
            if (status)
            {
                httpContext.Session.SetString("Login", "true");
            }
            else
            {
                httpContext.Session.SetString("Login", "false");
            }
        }

        public bool IsAuthentificated(HttpContext httpContext)
        {
            string sessionLogin = httpContext.Session.GetString("Login");
            if ((sessionLogin == null) || (sessionLogin != "true"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
