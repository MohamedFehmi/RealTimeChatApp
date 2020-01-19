using System;
using System.Collections.ObjectModel;
using RealTimeChatApp.Models;

namespace RealTimeChatApp.APIServices.IServices
{
    public interface IConversationsListService
    {
        ObservableCollection<ConversationOverview> getAllConversations();
    }
}
