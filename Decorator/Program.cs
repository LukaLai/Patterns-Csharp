using Decorator;

var uncafesimple = new SimpleCafe();
Console.WriteLine($"{uncafesimple.GetPrix():c}"); 
Console.WriteLine(uncafesimple.GetDescription()); 

var uncafeaulait = new CafeAuLait(uncafesimple);
Console.WriteLine($"{uncafeaulait.GetPrix():c}");
Console.WriteLine(uncafeaulait.GetDescription()); 

var uncafefroid = new CafeFroid(uncafeaulait);
Console.WriteLine($"{uncafefroid.GetPrix():c}");
Console.WriteLine(uncafefroid.GetDescription()); 

var vanillaCoffee = new CafeVanille(uncafefroid);
Console.WriteLine($"{vanillaCoffee.GetPrix():c}"); 
Console.WriteLine(vanillaCoffee.GetDescription()); 