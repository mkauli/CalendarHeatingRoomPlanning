using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CalendarHeatingRoomPlanning;

namespace CalendarHeatingRoomPlanningUI.Pages.Forms
{
    public class ICalShowDataModel : PageModel
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
        /// Constructor of the class - initialized properties.
        /// </summary>
        public ICalShowDataModel()
        {
            Data = new List<string>();
        }

        public void OnGet()
        {
            // load data from webcal URl
            System.Net.WebClient client = new System.Net.WebClient();
            System.IO.Stream stream = client.OpenRead("http://svlw.protonet.info/calendar.ics?calendar_token=dsV46e-DDXhsLPsrztzV&project_id=218");
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
}