using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace RealTimeChatApp.ViewModels
{
    public class ConversationsListViewModel : INotifyPropertyChanged
    {
        //Properties
        public ObservableCollection<ConversationOverview> Conversations { get; set; }

        public ConversationsListService conversationsListService;

        public ConversationsListViewModel()
        {
            conversationsListService = new ConversationsListService();
            Conversations = conversationsListService.getAllConversations();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}