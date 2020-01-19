using System;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using RealTimeChatApp.APIServices.IServices;
using RealTimeChatApp.APIServices.Utilities;
using RealTimeChatApp.Models;

namespace RealTimeChatApp.APIServices.Services
{
    public class ConversationsListService : IConversationsListService
    {

        public ObservableCollection<ConversationOverview> getAllConversations()
        {
            try
            {
                //Call to Dummies
                var result = Dummies.AllConversations;

                return JsonConvert.DeserializeObject<ObservableCollection<ConversationOverview>>(result);
            }
            catch (Exception ex)
            {
                return new ObservableCollection<ConversationOverview>();
            }
        }
    }
}
