using System.Collections.ObjectModel;
using System.Linq;

namespace ChatApp.MVVM.Models
{
    public class Contact
    {
        public string UserName { get; set; }
        public string ImageSource { get; set; }

        public ObservableCollection<Message> Messages { get; set; }

        public string LastMessage => Messages.Last().MessageValue;
    }
}