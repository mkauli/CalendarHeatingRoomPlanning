using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalendarHeatingRoomPlanningUI.Pages.Forms
{
    /// <summary>
    /// This page can be used by user to modify/change the specified rooms.
    /// </summary>
    public class ModifyRoomsModel : PageModel
    {
        /// <summary>
        /// Rooms that are already specified.
        /// </summary>
        [BindProperty]
        public CalendarHeatingRoomPlanning.RoomModel Rooms
        {
            get { return RoomManager.Instance.Rooms;  }
            set { }
        }
 
        public IActionResult OnGet()
        {
            if (!Authentification.Instance.IsAuthentificated(HttpContext))
            {
                return new RedirectToPageResult("/Index");
            }

            return Page();
        }
        //public IActionResult OnPost()
        //{
        //    if (ModelState.IsValid == false)
        //    {
        //        return Page();
        //    }

        //    return RedirectToPage("/Index");
        //}
    }
}
