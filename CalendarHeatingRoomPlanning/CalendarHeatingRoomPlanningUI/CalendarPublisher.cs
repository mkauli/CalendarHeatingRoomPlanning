///////////////////////////////////////////////////////////
//  CalendarPublisher.cs
//  Implementation of the Interface Calendar-Publisher
//  Generated by Enterprise Architect
//  Created on:      04-Mai-2021 10:47:55
//  Original author: mkaul
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CalendarHeatingRoomPlanningUI
{
    /// <summary>
    /// This interface class specify the operations of the calendar publisher. The
    /// calendar publisher will publish fetched calendar data to all registered
    /// subscribers.
    /// </summary>
    public interface CalendarPublisher
    {

        /// <summary>
        /// Registers new subscriber to the list of subscribers - when notify is called
        /// then all currently registered subscribers are called.
        /// </summary>
        /// <param name="subscriber"></param>
        void Attach(CalendarSubscriber subscriber);

        /// <summary>
        /// Removes the subscriber from the list of subscribers - when notify is called
        /// then all currently registered subscribers are called.
        /// </summary>
        /// <param name="subscriber"></param>
        void Detach(CalendarSubscriber subscriber);

        /// <summary>
        /// For all registered subscribers their Update() operation is called - used to
        /// notify the subscribers. This notify will be published to the subscribers when
        /// calendar data was fetched.
        /// </summary>
        void Notify();
    }
}