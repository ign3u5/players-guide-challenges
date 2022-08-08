﻿var score = ("R2-D2", 12420, 15);

(string Name, int Points, int Level) namedScore = score;
Console.WriteLine($"Name: {namedScore.Name}, Level: {namedScore.Level}, Points: {namedScore.Points}");

var varNamedScore = (Name: "R2-D2", Points: 12420, Level: 15);
Console.WriteLine($"Name: {varNamedScore.Name}, Level: {varNamedScore.Level}, Points: {varNamedScore.Points}");

void DisplayScore((string Name, int Points, int Level) score)
{
    Console.WriteLine($"Name: {score.Name}, Points: {score.Points}, Level: {score.Level}");
}

(string Name, int Points, int Level) GetScore() => ("R2-D2", 15420, 15);

var methodScore = GetScore();
Console.WriteLine(methodScore);

var tile = (Row: 2, Column: 4, TileType.Rock);



void makeSoup()
{
    (string foodBase, string ingredient, string seasoning) completedSoup;

    var tuples = new (foodType, ingredient, seasoning)[3];

    Console.WriteLine("Welcome to Simulas Soups!");
    Console.WriteLine($"What's the main item your dish will be based on please? {foodType.soup}, {foodType.stew}, {foodType.gumbo}");
    string selectedBase = Console.ReadLine().ToLower();
    
    switch (selectedBase)
    {
        case "soup":
            break;
        case "stew":
            break;
        case "gumbo":
            break;
        default:
            break;
    }

    Console.WriteLine($"Now we have your base, please enter the main ingredient you want in your {selectedBase}, the options are as follows: {ingredient.mushrooms}, {ingredient.chicken}, {ingredient.carrots}, {ingredient.potatoes}");
    string selectedIngredient = Console.ReadLine().ToLower();

    switch (selectedIngredient)
    {
        case "mushrooms":
            break;
        case "chicken":
            break;
        case "carrots":
            break;
        case "potatoes":
            break;
        default:
            break;
    }

    Console.WriteLine($"Now finally, please select the seasoning to go with your {selectedBase} & {selectedIngredient}, the options are as follows: {seasoning.spicy}, {seasoning.salty}, {seasoning.sweet}");
    string selectedSeasoning = Console.ReadLine().ToLower();

    switch (selectedSeasoning)
    {
        case "spicy":
            break;
        case "salty":
            break;
        case "sweet":
            break;
        default:
            break;
    }

};

enum TileType { Grass, Water, Rock};
enum foodType { soup, stew, gumbo};
enum ingredient { mushrooms, chicken, carrots, potatoes};
enum seasoning { spicy, salty, sweet};