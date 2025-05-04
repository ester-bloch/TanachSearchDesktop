using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Global
{
    public class NachLocation:Location
    {
        public string? Sefer { get; set; }
        public string?  Perek { get; set; }
        public string? Pasuk { get; set; }
        public string? Value { get; set; }
        public Result RegularSearchConvertor(string word)
        {
            Result result = new Result() { Pasuk = Pasuk, Value = Value, Perek = Perek, Sefer = Sefer };
            result.FoundWord = result.Value.Contains(word);
            if (result.FoundWord) { result.IndexOfWord = result.Value.IndexOf(word); result.LengthOfWord = word.Length; }
            return result;
        }
        public Result InitialSearchConvertor(string word)
        {
            Result result = new Result() { Pasuk = Pasuk, Value = Value, Perek = Perek, Sefer = Sefer };
            string[] arr = result.Value.Split(" ");
            string initials = "";
            for (int i = 0;i<arr.Length;i++)if(arr[i]!="")initials += arr[i][0];
            result.FoundInitial = initials.Contains(word);
            if (result.FoundInitial) {
                result.IndexOfFirstInitial = initials.IndexOf(word);
                result.LengthOfWord = word.Length; 
            }
            return result;
        }

        public Result MiddleSearchConvertor(string word)
        {
            Result result = new Result() { Pasuk = Pasuk, Value = Value, Perek = Perek, Sefer = Sefer };
            string[] arr = result.Value.Split(" ");
            int maxLen=arr.ToList().Max(i=>i.Length);
            string str = "";
            for (int i = 0; i < maxLen; i++)
            {
                str = "";
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j].Length > i)
                        str += arr[j][i];
                    else str += " ";
                }
                if (str.Contains(word))
                {
                    result.FoundInMiddle = true;
                    result.LengthOfWord = word.Length;
                    result.IndexOfFirstMiddle = str.IndexOf(word);
                    result.LetterLocation =i;
                    return result;
                }
            }
            return result;     

        }

        public Result CombinedSearchConvertor(string word)
        {
            Result result = new Result() { Pasuk = Pasuk, Value = Value, Perek = Perek, Sefer = Sefer };
            result.FoundWord = result.Value.Contains(word);
            if (result.FoundWord) { result.IndexOfWord = result.Value.IndexOf(word); result.LengthOfWord = word.Length; }
            string[] arr = result.Value.Split(" ");
            int maxLen = arr.ToList().Max(i => i.Length);
            string str = "";
            for (int i = 0; i < maxLen; i++)
            {
                str = "";
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j].Length > i)
                        str += arr[j][i];
                    else str += " ";
                }
                if (str.Contains(word))
                {
                    result.FoundInMiddle = true;
                    result.LengthOfWord = word.Length;
                    result.IndexOfFirstMiddle = str.IndexOf(word);
                    result.LetterLocation = i;
                    return result;
                }
            }
            return result;


        }
    }
}
