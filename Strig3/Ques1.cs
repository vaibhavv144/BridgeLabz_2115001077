class Ques1{
     static void DisplayTimeZones()
    {
        DateTimeOffset currentTime = DateTimeOffset.UtcNow;
        Console.WriteLine("Current Time in Different Time Zones:");

        Console.WriteLine("GMT: " + currentTime.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"));
        Console.WriteLine("IST: " + ConvertToTimeZone(currentTime, "India Standard Time"));
        Console.WriteLine("PST: " + ConvertToTimeZone(currentTime, "Pacific Standard Time"));
    }

    static string ConvertToTimeZone(DateTimeOffset time, string timeZoneId)
    {
        TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
        DateTimeOffset convertedTime = TimeZoneInfo.ConvertTime(time, timeZone);
        return convertedTime.ToString("yyyy-MM-dd HH:mm:ss");
    }

}