//============================================================================================================
// # 3 Напишите программу, которая будет 
// выдавать название дня недели по заданному номеру.
//============================================================================================================

string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputDayOfWeek = int.Parse(inputLine);

    //     string[] DayOfWeek = new string[7];
    //     DayOfWeek[0] = "Monday";
    //     DayOfWeek[1] = "Tuesday";
    //     DayOfWeek[2] = "Wednesday";
    //     DayOfWeek[3] = "Thurthday";
    //     DayOfWeek[4] = "Friday";
    //     DayOfWeek[5] = "Saturday";
    //     DayOfWeek[6] = "Sunday";

    //     if (inputDayOfWeek > 7 || inputDayOfWeek < 1)
    //     {
    //         Console.WriteLine("there's no exist");
    //     }
    //     else
    //         {
    //             Console.WriteLine(DayOfWeek[inputDayOfWeek - 1]);
    //         }
    // } 

     string? outDayOfWeek = string.Empty;

//     switch (inputDayOfWeek)
//     {
//         case 1: outDayOfWeek = "Monday"; break;
//         case 2: outDayOfWeek = "Tuesday"; break;
//         case 3: outDayOfWeek = "Wednesday"; break;
//         case 4: outDayOfWeek = "Thurthday"; break;
//         case 5: outDayOfWeek = "Friday"; break;
//         case 6: outDayOfWeek = "Saturday"; break;
//         case 7: outDayOfWeek = "Sunday"; break;
//         default: outDayOfWeek = "there is no exist"; break;
//     }
outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inputDayOfWeek));
  
Console.WriteLine(outDayOfWeek);
}
