 class Ques2
 {
 public static void Leap(){
        Console.Write("Enter year (>= 1582): ");
        int year =Convert.ToInt32(Console.ReadLine());
        if (year >= 1582 && ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))){
            Console.WriteLine($" { year } is a Leap Year");
        }else{
            Console.WriteLine($"{year} is not a Leap Year");
        }

    }
}