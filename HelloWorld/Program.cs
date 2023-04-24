using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MyApp
{
    static void Main(string[] args)
    {
        double width, height, woodLength, glassArea;
        string widthString, heightString;

        string name = "McNeill Chimuka";
        string location = "Gweru, Zimbabwe";
        Console.WriteLine($"My name is {name}.I'm from {location}.");
        DateTime todayDate = DateTime.Now;
        Console.WriteLine("Current Date:"+todayDate.ToString("MM/dd/yyyy"));
        DateTime christmas = new DateTime(2023 , 12, 25);
        TimeSpan dateDiff = christmas - todayDate;
        int days = (int)dateDiff.TotalDays;
        Console.WriteLine($"There are {days} days until christmas ");
        Console.WriteLine("Enter your width in metres just digit only");
        widthString = Console.ReadLine();
        width = Double.Parse(widthString);
        Console.WriteLine("Enter your height in metres just the digit only ");
        heightString = Console.ReadLine();
        height = Double.Parse(heightString);
        woodLength = 2 * (width + height) * 3.25;
        glassArea = 2 * (width * height);
        Console.WriteLine($"The woodlength is {woodLength} feet");
        Console.WriteLine($"The glassArea is {glassArea} square meters");

        Console.ReadKey();
    }
}
