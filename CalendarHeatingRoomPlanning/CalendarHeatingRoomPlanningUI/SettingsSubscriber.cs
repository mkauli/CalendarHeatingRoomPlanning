///////////////////////////////////////////////////////////
//  Settings-Subscriber.cs
//  Implementation of the Interface Settings-Subscriber
//  Generated by Enterprise Architect
//  Created on:      03-Mai-2021 19:20:50
//  Original author: mkaul
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CalendarHeatingRoomPlanningUI
{
	/// <summary>
	/// This interface class specify the operations of the settings subscriber. The
	/// settings subscriber will be notified via it's Update() operation when the
	/// setting was changed.
	/// </summary>
	public interface SettingsSubscriber  
	{
		/// <summary>
		/// This operation will be called when the publisher notifies new setting data.
		/// </summary>
		/// <param name="publisher">Publisher that notifies the subscriber.</param>
		void Update(SettingsPublisher publisher);
	}
}