List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!
 
// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}


Eruption chileeruption = eruptions.FirstOrDefault(v => v.Location =="Chile");

Console.WriteLine($"la primera erupcion en Chile fue el año {chileeruption.Year} en la localidad de {chileeruption.Location} el nombre del volcan es {chileeruption.Volcano} y su tipo es {chileeruption.Type} y la elevacion de la explosión fue de{chileeruption.ElevationInMeters}");


Eruption hw = eruptions.FirstOrDefault(v => v.Location =="Hawaiian Is");

if(hw !=null){
   Console.WriteLine($"la primera erupcion en Hawaii fue el año {hw.Year} en la localidad de {hw.Location} el nombre del volcan es {hw.Volcano} y su tipo es {hw.Type} y la elevacion de la explosión fue de{hw.ElevationInMeters}");
}else{
    Console.WriteLine("No hawaiian IS eruption found");
}


Eruption nz = eruptions.First(v => v.Location == "New Zealand" && v.Year > 1900);
Console.WriteLine($"la primera erupcion en Nueva Zelanda fue el año {nz.Year} en la localidad de {nz.Location} el nombre del volcan es {nz.Volcano} y su tipo es {nz.Type} y la elevacion de la explosión fue de{nz.ElevationInMeters}");


IEnumerable<Eruption> elevationv = eruptions.Where(c => c.ElevationInMeters > 2000);

PrintEach(elevationv, "Stratovolcano eruptions.");

int erupciones = eruptions.Count(v => v.Volcano.StartsWith("L"));

Console.WriteLine($"el numero de volcanes que comienzan con la letra L es de {erupciones}");


int he = eruptions.Max(v => v.ElevationInMeters);

Console.WriteLine($"la mayor elevación fue de {he}");


IEnumerable<Eruption> vol = eruptions.Where(v => v.ElevationInMeters == he);


PrintEach(vol);


IEnumerable<Eruption> volA = eruptions.OrderBy(v => v.Volcano);

PrintEach(volA);


IEnumerable<Eruption> eruptionsy = eruptions.Where(c => c.Year < 1000).OrderBy( c => c.Volcano);


PrintEach(eruptionsy);