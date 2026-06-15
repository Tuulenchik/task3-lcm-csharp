using System.Numerics;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/mariamakhalaiya_gmail_com", (string? x, string? y) =>
{
    if (!BigInteger.TryParse(x, out var a) || !BigInteger.TryParse(y, out var b))
    {
        return "NaN";
    }

    if (a <= 0 || b <= 0)
    {
        return "NaN";
    }

    BigInteger Gcd(BigInteger m, BigInteger n)
    {
        while (n != 0)
        {
            var temp = n;
            n = m % n;
            m = temp;
        }

        return BigInteger.Abs(m);
    }

    var lcm = a / Gcd(a, b) * b;

    return lcm.ToString();
});

app.Run();