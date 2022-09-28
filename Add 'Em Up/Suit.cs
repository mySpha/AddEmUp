namespace Add__Em_Up
{
    public class Suit
    {
        public List<KeyValuePair<string, int>> GetSuit()
        {
            List<KeyValuePair<string, int>> suits = new List<KeyValuePair<string, int>>()
            {
                new KeyValuePair<string, int>("D", 2),
                new KeyValuePair<string, int>("H", 3),
                new KeyValuePair<string, int>("S", 4),
                new KeyValuePair<string, int>("C", 1)
            };
            return suits;
        }
    }
}
