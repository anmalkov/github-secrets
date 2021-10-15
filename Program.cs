var secret = Environment.GetEnvironmentVariable("MYAPP_SECRET");
Console.WriteLine($"The secret is: '{secret}'");
for(var i = 0; i < secret.Length; i++) {
    Console.Write($"{secret[i]} - ");
}
