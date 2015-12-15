using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using TennisBusiness;

namespace Tennis
{
    public class HelloModule : Nancy.NancyModule
    {
        public HelloModule()
        {
            Get["/"] = parameters => "Hello World";
            //Get["/score/"] = GetScore;
        }


        //private Response GetScore(dynamic parameters)
        //{
        //    Game g = new Game(0, 0);
        //    return Response.AsJson(g.Scores());
        //}

    }


}