using System;

namespace ChatApp.MVVM.Models
{
    public class Message
    {
        public string UserName { get; set; }

        public string UserNameColor { get; set; }

        public string ImageSource { get; set; }

        public string MessageValue { get; set; }

        public DateTime Time { get; set; }

        public bool IsNativeOrigin { get; set; }

        public bool? FirstMessage { get; set; }
    }
}