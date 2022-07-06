//https://docs.microsoft.com/en-us/dotnet/api/system.datetime.now?view=net-6.0#definition
// Get the current date.
DateTime thisDay = DateTime.Now; //DateTime.Today for 00:00:00, DateTime.UtcNow for Utc time
// Display the date in the default (general) format.
Console.WriteLine(thisDay.ToString());