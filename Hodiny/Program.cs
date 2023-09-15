// See https://aka.ms/new-console-template for more information
// string prichod;
// string odchod;



// prichod =  Console.ReadLine();
// odchod =  Console.ReadLine();


// DateTime start = DateTime.Parse(prichod);
// DateTime end = DateTime.Parse(odchod);

// // Console.WriteLine((end - start).TotalHours);

// Console.WriteLine("Odpracovano hodin: "+(end - start).TotalHours);


Console.WriteLine("Zapiš příchod:");
string startTime = Console.ReadLine();
Console.WriteLine("Zapiš odchod:");
string endTime = Console.ReadLine();

TimeSpan duration = DateTime.Parse(endTime).Subtract(DateTime.Parse(startTime));
    int pom = duration.Minutes;
    int pom2;

Console.WriteLine("-------------------------------------------------------------");
if (duration.Hours >= 12)
{
if  (duration.Minutes < 10 )
{
Console.WriteLine("Počet hodin: {0}:0{1}", duration.Hours-1, duration.Minutes);
Console.WriteLine("Byla odečtěna 1 hodinová pauza na oběd.");
}
else
{
Console.WriteLine("Počet hodin: {0}:{1}", duration.Hours-1, duration.Minutes);
Console.WriteLine("Byla odečtěna 1 hodinová pauza na oběd.");
}
}
else
pom -=30; 
if (pom <0 )
{
Console.WriteLine("Počet hodin: {0}:{1}", duration.Hours-1, 60+pom);
Console.WriteLine("Byla odečtěna 30 minutová pauza na oběd.");

}


// if  (duration.Minutes < 30)
// {
// Console.WriteLine("Počet hodin: {0}:0{1}", duration.Hours-1, duration.Minutes);
// Console.WriteLine("Byla odečtěna 30 minutová pauza na oběd.");
// }
// else
else 
{
Console.WriteLine("Počet hodin: {0}:{1}", duration.Hours, duration.Minutes-30);
Console.WriteLine("Byla odečtěna 30 minutová pauza na oběd.");
}


Console.WriteLine("-------------------------------------------------------------");
Console.WriteLine("Čas bez odečtení pauzy:");
Console.WriteLine(duration);
Console.ReadKey();
Console.ReadKey();