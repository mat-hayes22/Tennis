using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using TennisBusiness;
using Nancy.ModelBinding;
using SLWebAPI;

namespace Tennis
{
    public class HelloModule : Nancy.NancyModule
    {
        public HelloModule()
        {
            Get["/"] = parameters => "Hello World";
            Get["/score/{p1}"] = GetScoreWithStruc;
            //// http://social.technet.microsoft.com/wiki/contents/articles/19365.nancy-a-lightweight-net-framework.aspx
            Get["/sample/{yourname}"] = req =>
            {
                return "Hello " + req.yourname;
            };
        } 

        private Response GetScoreWithStruc(dynamic pararmeters)
        {
            try
            {
                //APIParms SP = getScoreParms(pararmeters);
                //Game g = new Game(SP.Player1Score, SP.Player2Score, SP.Player1Name, SP.Player2Name);
                //g.Score(SP.whichPlayer);
                //return Response.AsJson(g.Scores());
                return Response.AsJson("");
            }
            catch (Exception)
            {
                return HttpStatusCode.ImATeapot;
                throw;
            }

        }

        private APIParms getScoreParms(dynamic parameters)
        {
            //format for score [WhichPlayer]-[P1Score]-[P2Score]-[P1Name]-[P2Name] 
            // eg. http://localhost:52103/score/1-15-30-Mat-Claire

            //var model = this.Bind<ScoreParms>();


            string parmy = parameters.p1;
            List<string> parms = parmy.Split('-').ToList();
            APIParms SP = new APIParms();
            int whichPlayer;
            int p1Score;
            int p2Score;

            int.TryParse(parms[0], out whichPlayer);
            int.TryParse(parms[1], out p1Score);
            int.TryParse(parms[2], out p2Score);

            SP.whichPlayer = whichPlayer;
            SP.Player1Score = p1Score;
            SP.Player2Score = p2Score;
            SP.Player1Name = parms[3];
            SP.Player2Name = parms[4];

            return SP;
        }

    }


}