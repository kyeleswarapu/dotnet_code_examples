using System.Collections;
using System.Text.RegularExpressions;

namespace code_challenge_regex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>()
            {
                {"0","None"},{"1","None"},{"2","ABC"},{"3","DEF"},{"4","GHI"},{"5","JKL"},{"6","MNO"}
                ,{"7","PQR"},{"8","STUV"},{"9","WXYZ"}
            };

            Console.WriteLine("Enter a valid string in XXXX-XXXX-XXXXX format (example = 101-TRY-THIS):");
            string? inputString = Console.ReadLine();

            foreach(string key in dic.Keys)
            {
                if(!(key == "0" || key == "1"))
                {
                    inputString = Regex.Replace(inputString??"", $"[{dic[key]}]", key);
                }
            }

            Console.WriteLine(inputString);
        }
    }
}
