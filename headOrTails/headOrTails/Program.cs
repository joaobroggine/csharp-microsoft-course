int coin = Random.Shared.Next(1, 10);
var result = coin <= 5 ? "Head" : "Tail";
Console.WriteLine(result);