///////////////////////////////////////////////////////////
//  CalendarSubscriber.cs
//  Implementation of the Interface Calendar-Subscriber
//  Generated by Enterprise Architect
//  Created on:      04-Mai-2021 10:48:07
//  Original author: mkaul
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CalendarHeatingRoomPlanningUI
{
    /// <summary>
    /// This interface class specify the operations of the calendar subscriber. The
    /// calendar subscriber will be notified via it's Update() operation when the
    /// calendar data was fetched.
    /// </summary>
    public interface CalendarSubscriber
    {

        /// <summary>
        /// This operation will be called when the publisher notifies new fetched calendar
        /// data.
        /// </summary>
        /// <param name="publisher"></param>
        void Update(CalendarPublisher publisher);
    }
}