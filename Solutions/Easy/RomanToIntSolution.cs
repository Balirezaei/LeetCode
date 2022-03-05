namespace Solutions.Easy
{
    public class RomanToIntSolution
    {
        Numerals[] RomanConstant = new Numerals[13]
        {
            new Numerals{ Value="M",Key=1000},
            new Numerals{ Value="CM",Key=900},
            new Numerals{Key=500,Value= "D" },
            new Numerals{Key=400, Value="CD" },
            new Numerals{Key=100, Value="C" },
            new Numerals{Key=90,Value= "XC" },
            new Numerals{Key=50,Value= "L" },
            new Numerals{Key=40, Value="XL" },
            new Numerals{Key=10,Value= "X" },
            new Numerals{Key=9, Value="IX" },
            new Numerals{Key=5,Value= "V" },
            new Numerals{Key=4, Value="IV" },
            new Numerals{Key=1,Value= "I" }
        };
        public int RomanToInt(string s)
        {
            int output = 0;
            var tempInput = s;
            while (tempInput.Length >= 1)
            {
                foreach (var item in RomanConstant)
                {
                    if (tempInput.StartsWith(item.Value))
                    {
                        var startPosition = tempInput.IndexOf(item.Value) + (item.Value.Length);
                        var endPosition = tempInput.Length - (item.Value.Length);
                        output += item.Key;
                        if (endPosition == 0)
                        {
                            tempInput = "";
                        }
                        else
                        {
                            tempInput = tempInput.Substring(startPosition, endPosition);
                        }
                        break;
                    }
                }
            }
            return output;
        }
    }
}