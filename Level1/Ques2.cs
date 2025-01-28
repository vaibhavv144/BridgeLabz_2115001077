clas Ques2{
public static int CalculateHandshakes(int numberOfStudents)
{
    // Use the combination formula to calculate maximum handshakes
    return (numberOfStudents * (numberOfStudents - 1)) / 2;
}
}