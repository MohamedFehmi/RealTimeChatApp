using System;
namespace RealTimeChatApp.APIServices.Utilities
{
    /// <summary>
    /// This class is a static Dummy provider, it locally defines the server-like response for service classes under Services/ folder
    /// This is the way to go for feeding the app with data before involving real backend responses.
    /// </summary>
    public static class Dummies
    {
        public static string AllConversations = @"
            [
                {
                    Id:'21908309283091283908',
                    Name:'MyFamily',
                    Image:'avatar.png',
                    MembersCount : 9,
                    LastMessage : 'See you later <3.'    
                },
                {
                    Id:'21908309283091432130',
                    Name:'Ali',
                    Image:'avatar.png',
                    LastMessage : 'Chiao'
                },
                {
                    Id:'21908309283091432130',
                    Name:'MyTeam',
                    Image:'avatar.png',
                    MembersCount : 3,
                    LastMessage : 'Server updated'
                }
            ]
        ";
    }
}