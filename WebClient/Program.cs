/*
 * Get data about a postal code from Zippoptam.us, https://zippopotam.us/
 * A typical call looks like: https://api.zippopotam.us/se/42676
 * 
 * Which returns:
 
    {
        "post code": "42676",
        "country": "Sweden",
        "country abbreviation": "SE",
        "places": [
            {
                "place name": "Västra Frölunda",
                "longitude": "11.9294",
                "state": "Västra Götaland",
                "state abbreviation": "O",
                "latitude": "57.6467"
            }
        ]
    }
 */


using System.Net.Http.Json;

using WebClient.Models;

using HttpClient client = new()
{
    BaseAddress = new Uri("https://api.zippopotam.us/")
};

var postCode = await client.GetFromJsonAsync<PostalCode>("se/42676");

Console.WriteLine();
Console.WriteLine($"Postal code: {postCode.PostCode}");
Console.WriteLine($"Country: {postCode.Country}");
Console.WriteLine($"Country abbreviation: {postCode.CountryAbbreviation}");
foreach (var place in postCode.Places)
{
    Console.WriteLine($"Place name: {place.PlaceName}");
    Console.WriteLine($"Latitude: {place.Latitude}");
    Console.WriteLine($"Longitude: {place.Longitude}");
    Console.WriteLine($"State: {place.State}");
    Console.WriteLine($"State Abbreviation: {place.StateAbbreviation}");
    Console.WriteLine();
}

Console.Write("Press any key to continue . . . ");
Console.ReadKey();
