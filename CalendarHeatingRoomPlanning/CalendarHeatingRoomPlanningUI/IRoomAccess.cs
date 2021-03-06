///////////////////////////////////////////////////////////
//  IRoomAccess.cs
//  Implementation of the Interface Room-Access
//  Generated by Enterprise Architect
//  Created on:      09-Mai-2021 13:15:41
//  Original author: mkaul
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CalendarHeatingRoomPlanningUI
{
    /// <summary>
    /// Interface to manage the available rooms.
    /// </summary>
    public interface IRoomAccess
    {

        /// <summary>
        /// Add a new room to the list of rooms.
        /// </summary>
        /// <param name="room"></param>
        void AddRoom(CalendarHeatingRoomPlanning.SingleRoom room);

        /// <summary>
        /// Deletes an already created room from the list of rooms.
        /// </summary>
        /// <param name="room"></param>
        void DeleteRoom(CalendarHeatingRoomPlanning.SingleRoom room);
    }
}