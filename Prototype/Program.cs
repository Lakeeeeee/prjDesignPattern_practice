// See https://aka.ms/new-console-template for more information
using Prototype;

Ticket DucktailConcert = new();
DucktailConcert.SetEventName("Ducktail");
DucktailConcert.SetEventDate(new DateTime(2023, 12, 15, 19, 00, 00, DateTimeKind.Utc));
DucktailConcert.SetLocation(Location.The_Wall);
DucktailConcert.SetPrice(1200);

Ticket secondDucktailConcert = (Ticket)DucktailConcert.Clone();
secondDucktailConcert.SetEventDate(new DateTime(2024, 2, 14, 19, 00, 00, DateTimeKind.Utc));

DucktailConcert.Infor();
secondDucktailConcert.Infor();