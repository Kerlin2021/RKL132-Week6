string[] snacks = { "1,2,3", "4,5,6", "7,8,9" };

Random rnd = new Random();

int randomindex = rnd.Next(0, snacks.Length);

Console.WriteLine($"Tonight we are going to eat {snacks[randomindex]}");