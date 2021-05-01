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
        //Example Url: webcal://svlw.protonet.info/calendar.ics?calendar_token=dsV46e-DDXhsLPsrztzV&project_id=218

        /// <summary>
        /// Filename of the file that stores the application settings.
        /// </summary>
        private const string SettingsFileName = "CalendarHeatinRoomPlaning.dat";

        /// <summary>
        /// Application Settings that the user can change/modify
        /// </summary>
        [BindProperty]
        public ApplicationSettings Settings { get; set; }

        public void OnGet()
        {
            if (System.IO.File.Exists(SettingsFileName))
            {
                // load previous stored settings
                System.IO.TextReader reader = null;
                try
                {
                    System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(ApplicationSettings));
                    reader = new System.IO.StreamReader(SettingsFileName);
                    Settings = serializer.Deserialize(reader) as ApplicationSettings;
                }
                finally
                {
                    if (reader != null)
                    {
                        reader.Close();
                    }
                }
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            // save settings
            System.IO.TextWriter writer = null;
            try
            {
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(ApplicationSettings));
                writer = new System.IO.StreamWriter(SettingsFileName);
                serializer.Serialize(writer, Settings);
            }
            finally
            {
                if( writer != null)
                {
                    writer.Close();
                }
            }

            return RedirectToPage("/Index");
        }
    }
}
