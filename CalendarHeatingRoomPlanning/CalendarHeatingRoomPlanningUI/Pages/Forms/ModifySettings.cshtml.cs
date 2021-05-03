using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CalendarHeatingRoomPlanning;

namespace CalendarHeatingRoomPlanningUI.Pages.Forms
{
    /// <summary>
    /// This page can be used by user to modify/change the application settings.
    /// </summary>
    public class ModifySettingsModel : PageModel
    {
        /// <summary>
        /// Application Settings that the user can change/modify
        /// </summary>
        [BindProperty]
        public ApplicationSettings Settings 
        { 
            get { return SettingsManager.Instance.Settings; }
            set { SettingsManager.Instance.Settings = value;  }
        }

        public void OnGet()
        {
            SettingsManager.Instance.Load();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            SettingsManager.Instance.Store();
            return RedirectToPage("/Index");
        }
    }
}
