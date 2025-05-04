using Microsoft.AspNetCore.Mvc;
using DTO_Global;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using bll_services_3;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Class : ControllerBase
    {

    }
}

namespace presentationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToraSearch : ControllerBase
    {
        [HttpGet("{word}")]
        public List<Result> SearchWord(string word)
        {
            List<Result> r = bll_services_3.SearchMetheds.SearchWord(word);
            return r;
        }

        //[HttpGet("{word}")]
        //[Route("SearchInitial")]
        //public List<Result> SearchInitial([FromQuery] string word)
        //{
        //    List<Result> r = bll_services_3.SearchMetheds.SearchInitial(word);
        //    return r;
        //}
        //[HttpGet]
        //[Route("addPasuk")]
        //public bool ByYear([FromQuery] string pasuk)
        //{
        //    DAL__data_access.DataClass.psukim.Add(new NachLocation() { Pasuk = pasuk });
        //    return true;
        //}
        //    [HttpGet("{string1}")]
        //    public List<Result> SearchMiddle(string string1)
        //    {
        //        List<Result> r = bll_services_3.SearchMetheds.SearchMiddle(string1);
        //        return r;
        //    }
        //    [HttpGet("{wordToFind}")]
        //    public List<Result> SearchCombined(string wordToFind)
        //    {
        //        List<Result> r = bll_services_3.SearchMetheds.SearchCombined(wordToFind);
        //        return r;

        //}
    }
}