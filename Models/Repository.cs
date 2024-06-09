namespace PartyInvites.Models
{
    /*
     * Class Implementation Explanation
     * 
     * - the class is static so that you have a "global" in-memory way of storing all guest responses (for demonstration purposes)
     */
    public static class Repository
    {
        private static List<GuestResponse> _responses = new();
        public static IEnumerable<GuestResponse> Responses => _responses;
        
        public static void AddResponse(GuestResponse response)
        {
            Console.WriteLine(response);
            _responses.Add(response);
        }
    }
}
