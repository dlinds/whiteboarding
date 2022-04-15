using System;

namespace whiteboarding
{
  class Program
  {
    static void Main(string[] args)
    {
      // Console.WriteLine("Enter in a string to get the URL out");
      // string input = Console.ReadLine();
      // Console.WriteLine("Standard: " + GenerateURL(input));
      // Console.WriteLine("Recursively: " + GenerateURLRecursion(input));
      Console.WriteLine("\n\n\n\nNow to compress a string");
      Console.WriteLine("aaabccdddda Compressed: " + StringCompressor("aaabccdddda"));

    }
    public static string GenerateURL(string input)
    {
      string output = "";
      foreach (char letter in input)
      {

        if (letter == ' ')
        {
          output += "%20";
        }
        else
        {
          output += letter;
        }
      }
      return output;
    }

    public static string GenerateURLRecursion(string input, string output = "", int count = 0)
    {
      if (count == input.Length)
      {
        return output;
      }
      if (input[count] == ' ')
      {
        output += "%20";
      }
      else
      {
        output += input[count];
      }
      count++;
      return GenerateURLRecursion(input, output, count);

    }

    public static string StringCompressor(string input)
    {
      string output = "";
      for (int x = 0; x < input.Length; x++)
      {
        int count = 1;
        int y = x;
        while (input[x] == input[y + 1] && y < input.Length - 3)
        {
          count++;
          y++;
          Console.WriteLine(count);
        }
        if (count > 1)
        {
          output += count + "" + input[x];
        }
        else
        {
          output += input[x];
        }
      }
      return output;
    }
  }
}
