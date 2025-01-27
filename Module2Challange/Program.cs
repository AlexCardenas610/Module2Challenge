// Module2Challenge
// Alessandro Cardenas-Engle
// Date: 1/27/25

// Asks the user to enter number of miles driven
Console.Write("Enter number of miles driven: ");
double milesDriven = Convert.ToDouble(Console.ReadLine());

// Asks the user to enter the gallons of gas used 
Console.Write("How many gallons of gas did you use: ");
double gasUsed = Convert.ToDouble(Console.ReadLine());

// Calculates the miled per gallon
double mpg = milesDriven / gasUsed;

// Displays the mpg 
Console.Write("Your miles per gallon for your trip is: " + mpg);