using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
class Challenges
{
    public static void Main(string[] args)
    {
        //Below is the code for the user to choose a coding challenge from any of the ones listed
        Console.WriteLine("Welcome to my coding challenges! There will be a lot of different \nfunctions you can try. Feel free to try any you want!");
        Console.WriteLine("\nListed below will be coding challenges you can use and try by typing in the one you want. Just look through the list, and when prompted, type the coding challenge you would like to try.");
        //Add more challenge options when more are coded
        Console.WriteLine("\n" +
            "\nChallenge #1 (Sum of Numbers) " +
            "\nChallenge #2 (Minutes to Seconds) " +
            "\nChallenge #3 (Increasing A Number By One) " +
            "\nChallenge #4 (Calculation of Circut Power) " +
            "\nChallenge #5 (Years of Age to Days) " +
            "\nChallenge #6 (Calculate the Area of a Triangle)" +
            "\nChallenge #7 (Number Less than Zero?)" +
            "\nChallenge #8 (Added Numbers Are Less than 100?)" +
            "\nChallenge #9 (Numbers Equal to Each Other?)" +
            "\nChallenge #10 ('Something' Is Added To A Sentence)" +
            "\nChallenge #11 (It's Opposite Day!)" +
            "\nChallenge #12 (Converting Hours)" +
            "\nChallenge #13 (Internal Angles of a Polygon)" +
            "\nChallenge #14 (Include 'Edabit')" +
            "\nChallenge #15 (Is It Really 'True?')" +
            "\nChallenge #16 (Basketball Points)" +
            "\nChallenge #17 (Perimeter of a Rectangle)" +
            "\nChallenge #18 (Hello There!)" +
            "\nChallenge #19 (How Many Legs?)" +
            "\nChallenge #20 (Football Points)" +
            "\nChallenge #21 (What Month Is It?)" +
            "\nChallenge #22 (Min & Max Values)" +
            "\nChallenge #23 (Absolute Addition)" +
            "\nChallenge #24 (Calculating Exponents)" +
            "\nChallenge #25 (Multiply By Length)" +
            "\nChallenge #26 (Hamming Distance)" +
            "\nChallenge #27 (Is Shuffle Still On?)" +
            "\nChallenge #28 (What's The Smallest Number?)" +
            "\nChallenge #29 (Factorial Numbers)" +
            "\nChallenge #30 (How Many Vowels?)");

        Console.WriteLine("\n\nWhen prompted you can choose which function you want to use by typing the name of the function " +
            "(please do not include the challenge and the number)!\n");

        Console.WriteLine("If you would like to end the function before or after using it, please enter 'End Program.'\n\n");

        while (true)
        {
            string response = Console.ReadLine();

            if (response == "Sum of Numbers")
            {
                SumofNumbers();
                break;
            }
            if (response == "Minutes to Seconds")
            {
                MinutetoSeconds();
                break;
            }
            if (response == "Increasing A Number By One")
            {
                IncreasingANumberByOne();
                break;
            }
            if (response == "Calculation of Circut Power")
            {
                CalculationofCircutPower();
                break;
            }
            if (response == "Years of Age to Days")
            {
                YearsofAgetoDays();
                break;
            }
            if (response == "Calculate the Area of a Triangle")
            {
                CalculatetheAreaofaTriangle();
                break;
            }
            if (response == "Number Less than Zero?")
            {
                NumberLessthanZero();
                break;
            }
            if (response == "Added Numbers Are Less than 100?")
            {
                AddedNumbersAreLessthanOneHundred();
                break;
            }
            if (response == "Numbers Equal to Each Other?")
            {
                NumbersEqualtoEachOther();
                break;
            }
            if (response == "'Something' Is Added To A Sentence")
            {
                GiveMeSomething();
                break;
            }
            if (response == "It's Opposite Day!")
            {
                Opposite();
                break;
            }
            if (response == "Converting Hours")
            {
                howManySeconds();
                break;
            }
            if (response == "Internal Angles of a Polygon")
            {
                SumPolygon();
                break;
            }
            if (response == "Include 'Edabit'")
            {
                nameString();
                break;
            }
            if (response == "Is It Really 'True?'")
            {
                Truthful();
                break;
            }
            if (response == "Basketball Points")
            {
                BasketballPointers();
                break;
            }
            if (response == "Perimeter of a Rectangle")
            {
                Perimeter();
                break;
            }
            if (response == "Hello There!")
            {
                HelloName();
                break;
            }
            if (response == "How Many Legs?")
            {
                AnimalLegs();
                break;
            }
            if (response == "Football Points")
            {
                FootballPoints();
                break;
            }
            if (response == "What Month Is It?")
            {
                Months();
                break;
            }
            if (response == "Absolute Addition")
            {
                AbsoluteValue();
                break;
            }
            if (response == "Calculating Exponents")
            {
                Exponents();
                break;
            }
            if (response == "Min & Max Values")
            {
                MinMaxValue();
                break;
            }
            if (response == "Multiply By Length")
            {
                MultiplyByLength();
                break;
            }
            if (response == "Is Shuffle Still On?")
            {
                BackwardName();
                break;
            }
            if (response == "Hamming Distance")
            {
                HammingDistance();
                break;
            }
            if (response == "What's The Smallest Number?")
            {
                SmallNumber();
                break;
            }
            if (response == "Factorial Numbers")
            {
                FactorialNumbers(); 
                break;
            }
            if(response == "How Many Vowels?")
            {
                Vowels();
                break;
            }



            else if (response == "End Program")
            {
                break;
            }
            else
            {
                Console.WriteLine("\nOops. Sorry, something went wrong. I don't understand what you want to do. Please try again...\n");
            }
        }
    }

    public static void SumofNumbers()
    {
        //The code below is for the sum of numbers
        Console.WriteLine("\nToday we are going to write a numer sum function. " +
                "You will be able \nto add numbers together with whichever numbers you choose for the function.\n " +
                "\nPlease input your first number for the sum.\n");

        var number1 = Console.ReadLine();
        int number1Int = int.Parse(number1);

        Console.WriteLine("\nGot it! Your first number is: " + number1Int + "\n\nCool! Please input your second number.\n");

        var number2 = Console.ReadLine();
        int number2Int = int.Parse(number2);

        Console.WriteLine("\nGot it! Your second number is: " + number2Int + "\n...");

        Console.WriteLine("\nOk, the sum of the number: " + number1Int + ", and the number: " + number2Int + ", is equal to: " + Sum(number1Int, number2Int) + "!\n");
    }

    public static void MinutetoSeconds()
    {
        //Below is the code for conversion of time (minutes to seconds)
        Console.WriteLine("\nNext, we are now going to use a convert function. We will be able to convert any number from minutes to seconds.\n \nWhich number would you like to convert from minutes to seconds?\n");

        var number3 = Console.ReadLine();
        int number3Int = int.Parse(number3);

        Console.WriteLine("\nGreat! I will convert: " + number3 + " minute(s) to seconds.\n ...");

        Console.WriteLine("\n" + number3 + " minute(s) converts to " + Convert(number3Int) + " seconds!\n");
    }

    public static void IncreasingANumberByOne()
    {
        //Below is the code for the adding of +1 to numbers
        Console.WriteLine("\nNow we are going to write a function that takes a number and increases it by +1! " +
            "You will be able to choose \nthe number you would like to increase by +1.\n " +
            "\nWhat number would you like to increase by +1?\n");

        var number4 = Console.ReadLine();
        int number4Int = int.Parse(number4);

        Console.WriteLine("\nOk, " + number4Int + " will now be increased by an increment of +1.\n ... \n");
        Console.WriteLine("The number has now been increased to " + PlusOne(number4Int) + "!\n");
    }

    public static void CalculationofCircutPower()
    {
        //Below is the code for the multiplication between Current & Voltage
        Console.WriteLine("\nHere is a function that will take the amount of Volatage and the Current, and multiply them together to get the Circut Power amount!");
        Console.WriteLine("\nPlease choose the amount of Voltage you want to calcute with the Current.\n");

        var number5 = Console.ReadLine();
        int number5Int = int.Parse(number5);

        Console.WriteLine("\nGreat! " + number5 + " is the amount of Voltage you chose. Please choose the amount for the Current.\n");

        var number6 = Console.ReadLine();
        int number6Int = int.Parse(number6);

        Console.WriteLine("\nCool! You chose " + number6 + " for the amount of the Current! I will now calculate the Voltage and Current amounts.\n \n ... \n");
        Console.WriteLine("The Voltage amount: " + number5 + ", and the Current amount: " + number6 + ", equal to: " + CircuitPower(number5Int, number6Int) + "!");
    }

    public static void YearsofAgetoDays()
    {
        // Below is the code for the conversion from years of age to days

        Console.WriteLine("\n\nThis new function will now convert anyones age from years into days. " +
            "\nWhen you are prompted, please enter the age in years you want to convert into days.");

        Console.WriteLine("\nPlease choose the age in years you want to convert into days.\n");

        var number7 = Console.ReadLine();
        int number7Int = int.Parse(number7);

        Console.WriteLine("\nAlright, I will now convert " + number7 + " years of age into days. \n \n ... \n");
        Console.WriteLine("\nOk! The age " + number7 + " in years is equal to " + CalcAge(number7Int) + " days!");
    }

    public static void CalculatetheAreaofaTriangle()
    {
        //Below is the code for the area of a triangle by choosing the height and base

        Console.WriteLine("\n\nToday, this functionn will be used to calculate the area of a triangle with the base and height given by the user. " +
            "\nThe base and height can be either whole numbers or decimals, and can result in a whole or decimal solution for the area of the triangle.");

        Console.WriteLine("\nFirst, please choose a number for the base of the triangle for the area.\n");

        //The float variable is used for numbers that can be decimals when calculating, where integers cannot be used because they are a whole number
        var number8 = Console.ReadLine();
        float number8Float = float.Parse(number8);

        Console.WriteLine("\nCool! Next, please choose a number for the height of the triangle for the area.\n");

        var number9 = Console.ReadLine();
        float number9Float = float.Parse(number9);

        Console.WriteLine("\nGot it! So, the base number of " + number8 + ", and the height number of " + number9 + ", will now be calculated for the area of the triangle. \n\n ... \n");
        Console.WriteLine("The area of the triangle from the base and height is " + triArea(number8Float, number9Float) + "!");
    }

    public static void NumberLessthanZero()
    {
        //Below is the code for a function that will determine if the number you chose was less than or equal to 0

        Console.WriteLine("\n\nThis is a function that will determine if the number you chose is either less than or equal to zero! " +
            "If the number is less than or equal to zero, the function will show it as 'true,' but if it is bigger than zero, it will show it as 'false.'");

        Console.WriteLine("\nPlease choose a number you want to know if it is less than or equal to zero.\n");

        var number10 = Console.ReadLine();
        float number10Float = float.Parse(number10);

        Console.WriteLine("\nOk! The number you chose is " + number10 + ". And the function has determined that the number is " + lessThanOrEqualToZero(number10Float) + ".");
    }

    public static void AddedNumbersAreLessthanOneHundred()
    {
        //Below is the code for a function that determines if the number you chose to add together is less than 100

        Console.WriteLine("\n\nToday's function is a function that will allow you to choose any two numbers to add together, " +
            "and the function will determine if the sum of those numbers is less than 100.");

        Console.WriteLine("\nFirst, please choose the first number you want to use for addition.\n");

        var number11 = Console.ReadLine();
        int number11Int = int.Parse(number11);

        Console.WriteLine("\nGot it! Now please choose the second number for additon.\n");

        var number12 = Console.ReadLine();
        int number12Int = int.Parse(number12);

        Console.WriteLine("\nOk! The numbers you choose will be added together, and result in the number " + Sum(number11Int, number12Int) + ".");
        Console.WriteLine("\n\nNow the function will determine if the number is less than 100. " +
            "If the number is less than 100, it will result in being 'true,' if the number more than 100, it will result in being 'false.'");

        Console.WriteLine("\n\nThe function has determined that the addition number is " + lessThan100(number11Int, number12Int) + ".");
    }

    public static void NumbersEqualtoEachOther()
    {
        //Below is the code for a function that checks if two integers are equal to each other

        Console.WriteLine("\n\nNow, this function will allow you to choose two integer numbers, where it will check each number and see if they are equal to each other. " +
            "If the numbers are equal to each other, the function will show as 'true,' if they aren't, it will show as 'false.'");

        Console.WriteLine("\nFirst, please choose the first number you want the function to determine.\n");

        var number13 = Console.ReadLine();
        int number13Int = int.Parse(number13);

        Console.WriteLine("\nGot it! Now please choose the second number you want the function to determine.\n");

        var number14 = Console.ReadLine();
        int number14Int = int.Parse(number14);

        Console.WriteLine("\nOk, the numbers you chose, (" + number13Int + " & " + number14Int + "), will now be determined to see if they are equal to each other or not.");
        Console.WriteLine("\n\nThe function has determined that the numbers you chose as " + IsEqual(number13Int, number14Int) + ".");
    }

    public static void GiveMeSomething()
    {

        Console.WriteLine("\n\nThis function will put the word 'something' infront of whatever you want to write. Then it will print the results for you to see what the sentence is.");
        Console.WriteLine("\nPlease type a sentence you want the word 'something' to be placed in front of.\n");

        var response = Console.ReadLine();
        string putSomething = string.Format(response);

        Console.WriteLine("\nOk. This is the response you put: " + putSomething + " \n(This will now have the word 'something' put in front of it.) \n\n...\n");
        Console.WriteLine("\nThe new response for your sentence is: " + Something(putSomething) + ".");

    }

    public static void Opposite()
    {
        Console.WriteLine("\n\nThis function will give the opposite statement to the response you put, whether it is true or false.");
        Console.WriteLine("\nPlease enter the 'true' or 'false' statement you want to have an opposite response to.\n");

        var response = Console.ReadLine();
        string opposite = string.Format(response);

        Console.WriteLine("\nCool! The statement you chose was '" + opposite + ".'");
        Console.WriteLine("\nNow the function will create an opposite response to the statement you entered.");
        Console.WriteLine("\nThe opposite response is '" + Reverse(opposite) + ".'");
    }


    public static void howManySeconds()
    {
        Console.WriteLine("\n\nToday, this function will be able to convert any amount of hours you input into minutes and seconds! When prompted, please choose the amount of hours you want to convert.");
        Console.WriteLine("\nPlease enter the amount of hours you want to convert.\n");

        var number15 = Console.ReadLine();
        float number15float = float.Parse(number15);

        Console.WriteLine("\nGot it! The amount of hours you chose was " + number15float + ". The amount of minutes for these hours is " + HoursMinutes(number15float) + ".");
        Console.WriteLine("\nAnd the amount of seconds for these hours is " + HoursSeconds(number15float) + ".");
    }

    public static void SumPolygon()
    {
        Console.WriteLine("\n\nThis function will help you determine the sum of the internal angles of a polygon from the amount of sides you input for the polygon you want. (Triangle = 3, Square = 4, etc.)");
        Console.WriteLine("\nThen, once you input the amount of sides, the function will run the amount of sides of the polygon through an equation that will result the sum of the internal angels of the polygon" +
            "in degrees. Please remember the shape/polygon must have more than 3 sides or it will not work!");
        Console.WriteLine("\nPlease input the amount of sides your polygon has, so it can be calculated.\n");

        while (true)
        {
            var number16 = Console.ReadLine();
            int number16int = int.Parse(number16);

            if (number16int > 2)
            {
                Console.WriteLine("\nOk! With the polygon you chose having " + number16int + " sides, the sum of the internal angles of the polygon is " + Polygon(number16int) + " degrees.");
                break;
            }

            else if (number16int < 3)
            {
                Console.WriteLine("\nSorry. This polygon cannot be made with this ammount go sides. Please have the polygon have more than or equal to 3 sides in order to have a calculation made.\n");
            }
        }
    }

    public static void nameString()
    {
        Console.WriteLine("\n\nToday, this function will have you write a name, and will have 'Edabit' added at the end of the name. When prompted please enter the name you want to use.");
        Console.WriteLine("\nPlease choose a name you want to use.\n");

        var response = Console.ReadLine();
        string stringName = string.Format(response);

        Console.WriteLine("\nGot it! So the name you chose was " + stringName + ". The new name for the one you chose, (after adding 'Edabit'), is " + Name(stringName) + ".");
    }


    public static void Truthful()
    {
        Console.WriteLine("\n\nThis function will determine if the 'truth statements' (true/false) chosen are only 'true' to each other. " +
            "If one is false, and the other is true, (or if both are false), the function determines the boolean values to be false to each other. When prompted, please choose the truth statements for the function.");
        Console.WriteLine("\nPlease chose the first truth statement for the function.\n");

        var variableOne = Console.ReadLine();
        bool variable = bool.Parse(variableOne);

        Console.WriteLine("\nGot it! Now please choose the next truth statement.\n");

        var variableTwo = Console.ReadLine();
        bool variableS = bool.Parse(variableTwo);

        Console.WriteLine("\nOk. So the truth statements you have chosen will be run through the function to determine if they are truly 'true' statements.");
        Console.WriteLine("\nThe function has determined that the variables chosen, " + variable + " & " + variableS + ", are " + And(variable, variableS) + ".");
    }

    public static void BasketballPointers()
    {
        Console.WriteLine("\n\nToday, this function will calculate the amount of basketball 2 pointers, and 3 pointers scored, when putting the amount of times the basketball team has scored those points. " +
            "Then, when both values are put in, the function will add the points all together and give you the final sum of points by the basketball team.");
        Console.WriteLine("\nWhen you have gotten the amount of times the basketball team have gotten 2 pointers, please enter the number below.\n");

        var number17 = Console.ReadLine();
        int number17Int = int.Parse(number17);

        Console.WriteLine("\nGot it! When you have gotten the amount of times the team have gotten 3 pointers, please enter the number below.\n");

        var number18 = Console.ReadLine();
        int number18Int = int.Parse(number18);

        Console.WriteLine("\nOk, so the amount of 2 pointers the basketball team has gotten is " + number17Int + ", and the amount of 3 pointers the team has gotten is " + number18Int + ". " +
            "Now the function will calculate the total amount of points the team has gotten.");
        Console.WriteLine("\nThe function has determined that the basketball team has gotten " + BasketBall(number17Int, number18Int) + " points in total.");

    }

    public static void Perimeter()
    {
        Console.WriteLine("\n\nThis function will allow you to put two integers for a rectangle's side lengths (width & length), in order to calculate the perimeter for the rectangle. " +
            "When prompted, please put the first side length of the rectangle.");
        Console.WriteLine("\nPlease enter the first side length (length).\n");

        var number19 = Console.ReadLine();
        int number19Int = int.Parse(number19);

        Console.WriteLine("\nGot it! Now please enter the second side length (width).\n");

        var number20 = Console.ReadLine();
        int number20Int = int.Parse(number20);

        Console.WriteLine("\nOk. The side lengths of the rectangle are " + number19Int + " (length) & " + number20Int + " (width). Now they will be put through the function to calculate the perimeter of the rectangle.");
        Console.WriteLine("\nThe perimeter of the rectangle is " + Rectangle(number19Int, number20Int) + ".");
    }

    public static void HelloName()
    {
        Console.WriteLine("\n\nThis function will be able to write a 'Hello' message with the name inputted into the function. " +
            "When you have the name you want to have a 'Hello' message written for, please enter it when prompted.");
        Console.WriteLine("\nPlease enter the name you want for the message.\n");

        var Hello = Console.ReadLine();
        string helloMessage = string.Format(Hello);

        Console.WriteLine("\nOk, so you have chosen the person by the name of " + helloMessage + ". Now the function will write the message for you.");
        Console.WriteLine("\nThe function has written: " + Message(helloMessage));
    }

    public static void AnimalLegs()
    {
        Console.WriteLine("\n\nToday, this function will be able to tell a farmer how many animal legs they have from their chickens, cows and pigs! " +
            "They will input the amount of animals they have for each category, and the function will calculate how many legs there are total. When prompted, please input the amount of chickens there are.");
        Console.WriteLine("\nPlease enter the amount of chickens there are.\n");

        var TwoLegs = Console.ReadLine();
        int chickenLegs = int.Parse(TwoLegs);

        Console.WriteLine("\nOk, now please enter the amount of cows there are.\n");

        var FourLegs = Console.ReadLine();
        int cowLegs = int.Parse(FourLegs);

        Console.WriteLine("\nGot it! Now please enter the amount of pigs there are.\n");

        var LegsFour = Console.ReadLine();
        int pigLegs = int.Parse(LegsFour);

        Console.WriteLine("\nOk! With your inputs about the amount of chickens, cows and pigs there are, the function will now calculate how many animal legs there are in total.");
        Console.WriteLine("\nThe function has calculated that there are " + Animals(chickenLegs, cowLegs, pigLegs) + " animal legs.");

    }

    public static void FootballPoints()
    {
        Console.WriteLine("\n\nToday, this function will calculate the total points won from a football team from their game. " +
            "The function will ask for the wins from the team, then the draws, and finally the losses from the entire game. When prompted please have the wins, draws and losses ready from the football team.\n");
        Console.WriteLine("\nPlease enter the amount of wins the football team had.\n");

        var number21 = Console.ReadLine();
        int number21Int = int.Parse(number21);

        Console.WriteLine("\nNow please enter the amount of draws the football team had.\n");

        var number22 = Console.ReadLine();
        int number22Int = int.Parse(number22);

        Console.WriteLine("\nFinally, please enter the amount of losses the football team had.\n");

        var number23 = Console.ReadLine();
        int number23Int = int.Parse(number22);

        Console.WriteLine("\nOk! The function has all the wins, draws and losses from the team. Now it will calculate the total amount of points they have from the entire football game.");
        Console.WriteLine("\nThe function calculated that the football team has a total of " + Football(number21Int, number22Int, number23Int) + " points from the entire game.");
    }

    public static void Months()
    {
        Console.WriteLine("\nToday, this function will be able to take an input of the numbers 1-12 to say what month it is for the number input. " +
            "When prompted, please input a number from 1-12 for the function to determine the month.");
        Console.WriteLine("\nPlease choose a number from 1-12.\n");

        var number24 = Console.ReadLine();
        int monthNumber = int.Parse(number24);

        Console.WriteLine("\nGot it! The function will take the number and give the result of the corresponding month.");
        Console.WriteLine("\nThe function determines the month to be " + MonthName(monthNumber) + ".");
    }

    public static void MinMaxValue()
    {
        Console.WriteLine("\nThis function will take 5 numbers of your choice and determine the minimum & maximum numbers in the set, " +
            "and display the value from the smallest and the greatest. When prompted, please choose the numbers you want.");
        Console.WriteLine("\nPlease choose the 5 numbers you want minimum and maximum values for.");

        int[] nos = new int[5];

        int numberIndex = 0;

        int iMax = 0;
        int iMin = int.MaxValue;

        while (numberIndex < 5)
        {
            Console.WriteLine("\nEnter number " + (numberIndex + 1) + ": \n");
            nos[numberIndex] = int.Parse(Console.ReadLine());
            numberIndex += 1;
        }

        for (int i = 0; i < nos.Length; i++)
        {
            if (nos[i] > iMax) iMax = nos[i];
            if (nos[i] < iMin) iMin = nos[i];
        }

        Console.WriteLine("\nGot it! Now the function will determine the minimum and maximum numbers from your selection.");
        Console.WriteLine("\nThe function determined that the minimum value is {0}.", iMin);
        Console.WriteLine("And the maximum value is {0}.", iMax);
    }

    public static void AbsoluteValue()
    {
        Console.WriteLine("\nThis function will take 5 numbers from your input, either negative or positive, and return the sum of all the numbers in an absolute value, (which means they are all positive). " +
            "When prompted, please choose 5 numbers you want.");
        Console.WriteLine("\nPlease choose 5 numbers you want for addition.\n");

        int[] numberArray = new int[5];

        int numberIndex = 0;
        int additionResult = 0;

        while (numberIndex < 5)
        {
            Console.WriteLine("\nEnter number " + (numberIndex + 1) + ": \n");
            numberArray[numberIndex] = Math.Abs(int.Parse(Console.ReadLine()));
            numberIndex += 1;
        }

        numberIndex = 0;
        while (numberIndex < 5)
        {
            additionResult += numberArray[numberIndex];
            numberIndex += 1;
        }

        Console.WriteLine("\nOkay! The function will now calculate the absolute values of these numbers and return the sum of the values.");
        Console.WriteLine("\nThe sum of the numbers is " + additionResult);
    }

    public static void Exponents()
    {
        Console.WriteLine("\nThis function will allow you to choose two numbers and the function will take the 1st number as the base and the second as the exponent number, " +
            "and will then return the exponential value of the numbers combined. When prompted, please choose the numbers you want.");
        Console.WriteLine("\nPlease choose the first number for the base of the exponent number.\n");

        var number26 = Console.ReadLine();
        double number26Double = double.Parse(number26);

        Console.WriteLine("\nOk! Now please choose the number you want to put as the exponent to the base number.\n");

        var number27 = Console.ReadLine();
        double number27Double = double.Parse(number27);

        Console.WriteLine("\nGot it! Now the function will calculate the two numbers and return the exponential value of everything total.");
        Console.WriteLine("\nThe total exponential value of the two numbers is " + CalculateExponents(number26Double, number27Double) + ".");
    }

    public static void MultiplyByLength()
    {
        Console.WriteLine("\nToday, this function will take your input of as many integers as you want, and then take a second input of a multiplier factor for each of the integers you chose. " +
            "Then the function will determine each of the integer's values after being multiplied in the order you inputted them. When prompted, please have the integers you want ready.");
        Console.WriteLine("\nPlease choose as many intergers you want for multiplication. (To input multiple, seperate each number by a SPACE for the function to calculate them individually!)\n");

        string[] inputArrayStrings = Console.ReadLine().Split(' ');

        int[] numbers = new int[inputArrayStrings.Length];

        for (int i = 0; i < inputArrayStrings.Length; i++)
        {
            if (int.TryParse(inputArrayStrings[i], out int numValue))
            {
                numbers[i] = numValue;
            }
            else
            {
                Console.WriteLine($"Invalid input: {inputArrayStrings[i]} is not a valid integer. Exiting.");
                return;
            }
        }

        Console.WriteLine("\nGot it! Now please choose the multiplier for the numbers chosen.\n");

        string multiplierInput = Console.ReadLine();

        if (!int.TryParse(multiplierInput, out int multiplier))
        {
            Console.WriteLine("Sorry this isn't a good multiplier input. Exiting.");
            return;
        }

        int[] multipliedNumbers = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            multipliedNumbers[i] = numbers[i] * multiplier;
        }

        Console.WriteLine("\nOk! So the function will now multiply the numbers you have chosen with the multiplier value as well!");
        Console.WriteLine("The function has determined the results to be: \n");
        foreach (int number in multipliedNumbers)
        {
            Console.WriteLine(number + " ");
        }
        Console.WriteLine();

    }

    public static void BackwardName()
    {
        Console.WriteLine("\nThis function will shuffle your first and last name when you input them into the function. When prompted, please type your first name, then your last name.");
        Console.WriteLine("\nPlease type your first name.\n");

        var name = Console.ReadLine();
        string nameShuffle = string.Format(name);

        Console.WriteLine("\nGot it! Now please type your last name.\n");

        var lastName = Console.ReadLine();
        string lastNameShuffle = string.Format(lastName);

        Console.WriteLine("\nOk! Now the function will shuffle your first and last name.");
        Console.WriteLine("\nYour shuffled name is " + Name(nameShuffle, lastNameShuffle) + ".");
    }

    public static void HammingDistance()
    {
        Console.WriteLine("\nToday, this function will determine the amount of misplaced letters there are from your input of alphabetical letters in any order, " +
            "and return how many are out of place from where they're supposed to be in the alphabet (this is called 'hamming distance.'). When prompted, first input the correct alphabetical order " +
            "of the letters you want, then enter the mixed version you want after.");
        Console.WriteLine("\nPlease enter the alphabetical order of the letters you want (the length of the letters you choose first is how long the second input of letters should be too).\n");

        var hammDis1 = Console.ReadLine();
        string distance1 = string.Format(hammDis1);

        Console.WriteLine("\nOk! Now please enter the letters you want mixed from the alphabetical order above. (Remember to keep it the same length as the input above)\n");

        var hammDis2 = Console.ReadLine();
        string distance2 = string.Format(hammDis2);

        Console.WriteLine("\nOk! Now the function will determine the 'distance' of the letters in the alphabet with what you have inputted.");
        Console.WriteLine("\nThe function has determined that the 'hamming distance' of the letters you have inputted is " + Distance(hammDis1, hammDis2) + ".");
    }

    public static void SmallNumber()
    {
        Console.WriteLine("\nThis function will take two numbers from your input and determine which one is the smallest from the two, and return the smallest value. " +
            "When prompted, please have the numbers you want ready.");
        Console.WriteLine("\nPlease enter the first number.\n");

        var number28 = Console.ReadLine();
        int number28Int = int.Parse(number28);

        Console.WriteLine("\nOk! Now please enter the second number.\n");

        var number29 = Console.ReadLine();
        int number29Int = int.Parse(number29);

        Console.WriteLine("\nGot it! Now the function will determine which of the two numbers is the smallest.");
        Console.WriteLine("\nThe function has determined that the smallest number is " + Small(number28Int, number29Int) + ".");
    }

    public static void FactorialNumbers()
    {
        Console.WriteLine("\nToday, this fucntion will take any interger number (no negatives) of your choice, and make it a factorial number (ex: 3!). " +
            "When prompted, please have the number you want to factorially calculate.");
        Console.WriteLine("\nPlease choose the number you want the function to factorially calculate.\n");

        if (int.TryParse(Console.ReadLine(), out int number) && number >= 0) 
        {
            long result = Factorial(number);
            Console.WriteLine($"\nGot it! The factorial of {number} is: {result}");
        }
        else
        {
            Console.WriteLine("\nUh oh. The integer you put doesn't seem to work for factorial calculatings. Please enter an integer that isn't negative.");
        }
    }

    public static void Vowels()
    {
        Console.WriteLine("\nThis function will take any word from user input and count the vowels in the word. The function will then output the amount of vowels to the user. " +
            "When prompted, please choose the word you want the vowels of it to be counted.");
        Console.WriteLine("\nPlease type the word you want to count the vowels for.\n");

        int total = 0;
        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
        
        string sentence = Console.ReadLine().ToLower();

        for (int i = 0; i < sentence.Length; i++)
        {
            if (vowels.Contains(sentence[i]))
            {
                total++;
            }
        }

        Console.WriteLine("\nGot it! The function will now count how many vowels there are in the word.");
        Console.WriteLine("\nThe total number of vowels in the word is {0}.", total);
    }

    //Below is code for return values
    public static int Sum(int a, int b)
    {
        return a + b;
    }

    public static int Convert(int a)
    {
        return a * 60;
    }

    public static int PlusOne(int a)
    {
        return a + 1;
    }

    public static int CircuitPower(int a, int b)
    {
        return a * b;
    }

    public static int CalcAge(int a)
    {
        return a * 365;
    }

    public static float triArea(float a, float b)
    {
        return (a * b) / 2;
    }

    public static bool lessThanOrEqualToZero(float a)
    {
        return a < 0;
    }

    public static bool lessThan100(int a, int b)
    {
        return a + b < 100;
    }

    public static bool IsEqual(int a, int b)
    {
        return a == b;
    }

    public static string Something(string response)
    {
        return "Something " + response;
    }

    public static string Reverse(string other)
    {
        if (other == "true" || other == "True")
        {
            return "False";
        }
        else
        {
            return "True";
        }
    }

    public static float HoursMinutes(float a)
    {
        return a * 60;
    }

    public static float HoursSeconds(float a)
    {
        return a * (60) * 60;
    }

    public static int Polygon(int a)
    {
        return (a - 2) * 180;
    }

    public static string Name(string response)
    {
        return response + "Edabit";
    }

    public static bool And(bool a, bool b)
    {
        if (a == false)
        {
            return false;
        }
        else if (a == true & b == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static int BasketBall(int a, int b)
    {
        return (a * 2) + (b * 3);
    }

    public static int Rectangle(int a, int b)
    {
        return ((a * 2) + (b * 2));
    }

    public static string Message(string message)
    {
        return "Hello " + message + "!";
    }

    public static int Animals(int a, int b, int c)
    {
        return (a * 2) + (b * 4) + (c * 4);
    }

    public static int Football(int a, int b, int c)
    {
        return (a * 3) + (b * 1) + (c * 0);
    }

    public static string MonthName(int a)
    {
        switch (a)
        {
            case 1: return "January";

            case 2: return "February";

            case 3: return "March";

            case 4: return "April";

            case 5: return "May";

            case 6: return "June";

            case 7: return "July";

            case 8: return "August";

            case 9: return "September";

            case 10: return "October";

            case 11: return "November";

            case 12: return "December";

            default: return "invalid";
        }
    }

    public static double CalculateExponents(double a, double b)
    {
        return Math.Pow(a, b);
    }

    public static string Name(string a, string b)
    {
        return b + " " + a;
    }

    public static int Distance(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            return -1;
        }
        return str1.Zip(str2, (ch1, ch2) => new { ch1, ch2 }).Where(pair => pair.ch1 != pair.ch2).Count();
    }

    public static int Small(int a, int b)
    {
        return Math.Min(a, b);
    }

    public static long Factorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }

        long factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}

