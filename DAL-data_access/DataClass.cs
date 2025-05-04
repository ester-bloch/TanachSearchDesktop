using DTO_Global;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Net.Mime.MediaTypeNames;
namespace DAL__data_access
   
{
    public class DataClass
    {
        public static string TanachText;
        public static List<NachLocation> psukim = new List<NachLocation>();
        static DataClass()
        {
            //TanachText = File.ReadAllText(@"c:tora.txt");
            //transTanachTextToLocation(TanachText,psukim);
            string s = File.ReadAllText("C:\\Users\\This User\\Documents\\גיבוי פרויקטים c#\\TanachProject\\DAL-data_access\\ToraJason.txt");
            psukim = JsonConvert.DeserializeObject<List<NachLocation>>(s);
        }
        private static string Substring1(int startIndex, int endIndex, string str)
        {
            string s = "";
            int i = startIndex;
            for (; i < endIndex && i < str.Length; i++)
            {
                if (i < str.Length - 10)
                    s += str[i];
            }
            if (i == str.Length) return null;
            return s;
        }
        private static void transTanachTextToLocation(string str, List<NachLocation> list)
        {


            string sefer, perek, pasuk, value;
            int index = str.IndexOf("["), nextIndex, option1, option2;
            Console.WriteLine("lenth= " + str.Length);

            while (index < str.Length && index > -1)
            {
                nextIndex = str.IndexOf(" ", index + 1);
                sefer = Substring1(index + 1, nextIndex, str);
                index = nextIndex;
                nextIndex = str.IndexOf(",", index + 1);
                perek = Substring1(index + 1, nextIndex, str);
                index = nextIndex;
                nextIndex = str.IndexOf("]", index + 1);
                pasuk = Substring1(index + 1, nextIndex, str);
                index = nextIndex;
                option1 = str.IndexOf("[", index + 1);
                option2 = str.IndexOf(".", index + 1);
                nextIndex = option2;
                if (option1 != -1)
                {
                    value = Substring1(index + 1, nextIndex, str);
                    list.Add(new NachLocation() { Perek = perek, Sefer = sefer, Pasuk = pasuk, Value = value });

                    //Console.WriteLine("  index= " + index + " next index= " + nextIndex + " count= " + count++ + "_______" + "Value.length= " + Value.Length);
                    //Console.WriteLine(Value);
                    //Console.WriteLine("!!!Sefer!!!= " + Sefer + " !!!Perek: " + Perek + "  !!!!Pasuk= " + Pasuk);
                    ////Console.WriteLine(Value);
                }
                index = option1;


            }
            string updatedJson = JsonConvert.SerializeObject(psukim);
            File.WriteAllText("C:\\Users\\This User\\Documents\\מסלול\\שיעורי ביתc#\\TanachProject\\DAL-data_access", updatedJson);

        }
    }
}
