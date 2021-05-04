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
        public Ical.Net.Calendar Calendar 
        {
            get { return CalendarConnector.Instance.Calendar; }
            set { }
        }

        /// <summary>
        /// Destination of all calendar data processed by the CalendarConnector
        /// </summary>
        [BindProperty]
        public CalendarDataModel Data
        {
            get { return CalendarConnector.Instance.Data; }
            set { }
        }

        /// <summary>
        /// Constructor of the class - initialized properties.
        /// </summary>
        public ICalShowDataModel()
        {
        }

        public void OnGet()
        {
            CalendarConnector.Instance.FetchCalendarData();
        }
    }
}
