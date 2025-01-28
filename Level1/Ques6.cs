class Ques6{
public static bool IsSpringSeason(int month, int day)
{
    // Check if the date is within the Spring season range (March 20 to June 20)
    if ((month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20))
    {
        return true; // Spring season
    }
    else
    {
        return false; // Not Spring season
    }
}
}