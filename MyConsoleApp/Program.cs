var name = "Mark";
var date = DateTime.Now;

// Composite formatting:
Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", name, date.DayOfWeek, date);
// String interpolation:
Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");

// Both calls produce the same output that is similar to:
// Hello, Mark! Today is Wednesday, it's 14:30 now.

// Using DateTime to calculate the number of days until Christmas
var nextChristmas = new DateTime(date.Year, 12, 25);

// If today is after Christmas, we need to set the next Christmas to next year
if (date > nextChristmas)
{
    nextChristmas = nextChristmas.AddYears(1);
}

// Calculate the number of days until the next Christmas
var daysUntilChristmas = (nextChristmas - date.Date).Days;

// Using string interpolation to create a formatted message
Console.WriteLine("Hello, World!");
Console.WriteLine($"The current time is {date}.");
Console.WriteLine($"There are {daysUntilChristmas} days until the next Christmas.");