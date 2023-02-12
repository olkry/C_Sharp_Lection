Console.Clear();
int xa = 1, ya = 1,
    xb = 1, yb = 40,
    xc = 90, yc = 40,
    xd = 90, yd = 1;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

Console.SetCursorPosition(xd, yd);
Console.WriteLine("+");

int x = xa, y = xb;

int count = 0;

while (count < 100000)
{
    int what = new Random().Next(0, 4);
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    if (what == 3)
    {
        x = (x + xd) / 2;
        y = (y + yd) / 2;
    }

      Console.SetCursorPosition(x, y);
      Console.WriteLine("+");
      count = count + 1;

}