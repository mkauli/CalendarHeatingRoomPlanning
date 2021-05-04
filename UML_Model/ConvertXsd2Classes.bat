@echo off

xsd Settings.xsd /c /out:..\CalendarHeatingRoomPlanning\CalendarHeatingRoomPlanningUI\Models /namespace:CalendarHeatingRoomPlanning
rem xsd CalendarDataModel.xsd /c /out:..\CalendarHeatingRoomPlanning\CalendarHeatingRoomPlanningUI\Models /namespace:CalendarHeatingRoomPlanning
xsd RoomModel.xsd /c /out:..\CalendarHeatingRoomPlanning\CalendarHeatingRoomPlanningUI\Models /namespace:CalendarHeatingRoomPlanning
