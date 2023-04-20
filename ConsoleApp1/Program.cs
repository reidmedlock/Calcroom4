

static int calculateArea(int lengthInFeet, int widthInFeet)
{
    return lengthInFeet * widthInFeet;
}

{
    int lengthInFeet = 0;
    int widthInFeet = 0;
    int classroom = 0;


    Console.Write("Enter length of the Classroom in feet: ");
    lengthInFeet = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter width of Classroom in feet: ");
    widthInFeet = Convert.ToInt32(Console.ReadLine());

    classroom = calculateArea(lengthInFeet, widthInFeet);

    Console.WriteLine("The classroom  is " + classroom + " square feet.");

    if (classroom < 250)
    {
        Console.WriteLine("The class is small.");
    }

    if (classroom > 650)
    {
        Console.WriteLine("The class is large.");
    }

    else if (classroom < 650 && classroom > 250)
    {
        Console.WriteLine("The class is medium.");
    }
}
Console.WriteLine("Thank you for using the Class Size Calculator!");




