@echo off

xsd Settings.xsd /c /out:..\CalendarHeatingRoomPlanning\CalendarHeatingRoomPlanningUI\Models /namespace:CalendarHeatingRoomPlanning
xsd CalendarDataModel.xsd /c /out:..\CalendarHeatingRoomPlanning\CalendarHeatingRoomPlanningUI\Models /namespace:CalendarHeatingRoomPlanning
