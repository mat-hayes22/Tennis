namespace SLWebAPI
{
    public class APIParms : ITennisParms
    {
        public string Player1Name { get; set;  }
        public int Player1Score { get; set; }
        public string Player2Name { get; set; }
        public int Player2Score { get; set; }
        public int whichPlayer { get; set; }
    }
}