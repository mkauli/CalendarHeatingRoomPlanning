using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CalendarHeatingRoomPlanning;

namespace CalendarHeatingRoomPlanningUI.Pages.Forms
{
    public class ICalShowDataModel : PageModel, SettingsSubscriber
    {
        /// <summary>
        /// Destination of all calendar data read from the URL
        /// </summary>
        [BindProperty]
        public Ical.Net.Calendar Calendar { get; set; }

        /// <summary>
        /// Temporary used data
        /// ToDo: can be removed in production version
        /// </summary>
        [BindProperty]
        public List<string> Data { get; set; }

        /// <summary>
        /// URL to the calendar webcal site - will be updated by the SettingsManager via its publisher feature.
        /// </summary>
        private string _ical_url;

        /// <summary>
        /// Constructor of the class - initialized properties.
        /// </summary>
        public ICalShowDataModel()
        {
            Data = new List<string>();
            _ical_url = SettingsManager.Instance.Settings.Calendar.ICalUrl;
        }

        public void OnGet()
        {
            try
            {
                // load data from webcal URl
                System.Net.WebClient client = new System.Net.WebClient();
                // validate url
                if((_ical_url.Length > 0) && (_ical_url.ToLower().StartsWith("http")))
                {
                    System.IO.Stream stream = client.OpenRead(_ical_url);
                    // System.IO.FileStream stream = new System.IO.FileStream("C:\\Temp\\calendar.ics", System.IO.FileMode.Open, System.IO.FileAccess.Read);
                    System.IO.StreamReader reader = new System.IO.StreamReader(stream);
                    string iCalData = reader.ReadToEnd();
                    string iCalDataNoComments = "";

                    // remove comment -> not processed by ical library
                    using (var iCalDataReader = new System.IO.StringReader(iCalData))
                    {
                        for (string line = iCalDataReader.ReadLine(); line != null; line = iCalDataReader.ReadLine())
                        {
                            if (line.Length == 0) continue;
                            if (line[0] != '/')
                            {
                                iCalDataNoComments += line + System.Environment.NewLine;
                            }
                        }
                    }
                    // let parse data from ical calendar            
                    Calendar = Ical.Net.Calendar.Load(iCalDataNoComments);

                    foreach (Ical.Net.CalendarComponents.CalendarEvent cal in Calendar.Children)
                    {
                        Data.Add("test");
                    }
                }
            }
            finally
            {
            }
        }

        /// <summary>
        /// This operation will be called when the publisher notifies new setting data.
        /// </summary>
        /// <param name="publisher">Publisher that notifies the subscriber.</param>
        public void Update(SettingsPublisher publisher)
        {
            _ical_url = SettingsManager.Instance.Settings.Calendar.ICalUrl;
        }
    }
}
