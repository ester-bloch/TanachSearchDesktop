using DTO_Global;

namespace bll_services_3
{
    public class SearchMetheds
    {
        public static List<Result> SearchCombined(string word)
        {
            List<Result> l = DAL__data_access.DataClass.psukim.ConvertAll((NachLocation p) => { Result t = p.CombinedSearchConvertor(word); return t; }).ToList();
            return l.Where(x => x.FoundWord||x.FoundInMiddle).ToList();
        }

        public static List<Result> SearchInitial(string word)
        {

            List<Result> l = DAL__data_access.DataClass.psukim.ConvertAll((NachLocation p) => { Result t = p.InitialSearchConvertor(word); return t; }).ToList();
            return l.Where(p=>p.FoundInitial).ToList();
        }

        public static List<Result> SearchMiddle(string word)
        {

            List<Result> l = DAL__data_access.DataClass.psukim.ConvertAll((NachLocation p) => { Result t = p.MiddleSearchConvertor(word); return t; }).ToList();
            return l.Where(P=>P.FoundInMiddle).ToList();
        }

        public static List<Result> SearchWord(string word)
        {
            List<Result> l= DAL__data_access.DataClass.psukim.ConvertAll((NachLocation p) => { Result t = p.RegularSearchConvertor(word); return t; }).ToList();
            return l.Where(P => P.FoundWord).ToList(); ;
        }
    }
}