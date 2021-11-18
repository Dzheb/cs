// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//x* x + y*y = r*r =>y = (r*r - x*x)/ y
// double x46;
// double y46;
double r = 15;
//int r = 15;
// Console.Clear();
// Console.SetWindowPosition(0, 0);

for (double y = r; y >= -r; --y)
{

  for (double x = -r; x < r; ++x)
  {
    // Console.ForegroundColor = (ConsoleColor)rd.Next(16);
    double value = x * x + y * y;
    if (value == r * r)
    {

      Console.Write(".");
    }

    else
    {
      Console.Write(" ");
    }
  }
}
// for (x46 = 0; x46 < 10; x46++)
// {
//   y46 = Convert.ToInt32(Math.Sqrt(R46 * R46 - x46 * x46));
//   Console.SetCursorPosition(x46, y46);

//   Console.Write("+");

// }


// треугольник
// int xa = 40, ya = 1,
//     xb = 1, yb = 30,
//     xc = 80, yc = 30;

// for (ya = 1; ya < yb; ya++)
// {
//   xa = xa - 1;
//   Console.SetCursorPosition(xa, ya);
//   Console.WriteLine("+");

// }
// for (ya = 1; ya < yb; ya++)
// {
//   xa = xa + 1;
//   Console.SetCursorPosition(xa, ya);
//   Console.WriteLine("+");

// }

// Console.SetCursorPosition(xa, ya);
// Console.WriteLine("+");

// Console.SetCursorPosition(xb, yb);
// Console.WriteLine("+");

// Console.SetCursorPosition(xc, yc);
// Console.WriteLine("+");

// namespace ConsoleApp00
// {
//   class Program
//   {
//     static void Main()
//     {

//       Console.Clear();
//       Random rd = new Random();

//       double r;

//       do
//       {
//         Console.Write("Enter radius of circle : ");
//         if (!double.TryParse(Console.ReadLine(), out r) || r <= 0)
//         {
//           Console.WriteLine("Invalid radius, try again");
//         }
//       }
//       while (r <= 0);

//       Console.WriteLine();
//       bool fill = false;
//       string input;

//       do
//       {
//         Console.Write("Do you want to fill the circle  y/n : ");
//         input = Console.ReadLine().ToLower();
//         if (input != "y" && input != "n")
//         {
//           Console.WriteLine("Invalid reply, try again");
//         }
//         else if (input == "y")
//         {
//           fill = true;
//         }
//       }
//       while (input != "y" && input != "n");

//       Console.WriteLine();

//       double r_in = r - 0.4;
//       double r_out = r + 0.4;

//       for (double y = r; y >= -r; --y)
//       {




//         for (double x = -r; x < r_out; x += 0.5)
//         {
//           Console.ForegroundColor = (ConsoleColor)rd.Next(16);
//           double value = x * x + y * y;
//           if (value >= r_in * r_in && value <= r_out * r_out)
//           {

//             Console.Write(".");
//           }
//           else if (fill && value < r_in * r_in && value < r_out * r_out)
//           {
//             Console.Write(".");
//           }
//           else
//           {
//             Console.Write(" ");
//           }
//         }

//         Console.WriteLine();
//       }

//       Console.ReadKey();
//     }
//   }
// }


