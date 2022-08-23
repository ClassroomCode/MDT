

var nums = new List<int>() { 1, 2, 3, 4, 5, 6 };

var evens = nums.Where(n => n % 2 == 0);

foreach (var num in evens) {
    Console.WriteLine(num);
}

Console.WriteLine("=================");

nums.Add(8);

foreach (var num in evens) {
    Console.WriteLine(num);
}

