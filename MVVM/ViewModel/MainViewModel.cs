using ChatApp.Core;
using ChatApp.MVVM.Models;
using System;
using System.Collections.ObjectModel;

namespace ChatApp.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        public ObservableCollection<Message> Messages { get; set; }

        public ObservableCollection<Contact> Contacts { get; set; }

        public RelayCommand SendCommand { get; set; }

        private Contact _selectedContact;

        public Contact SelectedContact
        {
            get { return _selectedContact; }
            set
            {
                _selectedContact = value;
                OnPropertyChanged();
            }
        }

        private string _message;

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            Messages = new ObservableCollection<Message>();
            Contacts = new ObservableCollection<Contact>();

            SendCommand = new RelayCommand(x =>
            {
                Messages.Add(new Message
                {
                    MessageValue = Message,
                    FirstMessage = false,
                    Time = DateTime.Now
                });

                Message = "";
            });

            Messages.Add(new Message
            {
                UserName = "Person1",
                UserNameColor = "#409aff",
                ImageSource = "https://images.unsplash.com/photo-1660827718505-1070e803962b?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2070&q=80",
                MessageValue = "Test",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                FirstMessage = true
            });

            //for (int i = 0; i < 3; i++)
            //{
            //    Messages.Add(new Message
            //    {
            //        UserName = "Person",
            //        UserNameColor = "#409aff",
            //        ImageSource = "https://images.unsplash.com/photo-1660827718505-1070e803962b?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2070&q=80",
            //        MessageValue = "Test",
            //        Time = DateTime.Now,
            //        IsNativeOrigin = false,
            //        FirstMessage = false
            //    });
            //}

            //for (int i = 0; i < 4; i++)
            //{
            //    Messages.Add(new Message
            //    {
            //        UserName = "Person2",
            //        UserNameColor = "#409aff",
            //        ImageSource = "https://images.unsplash.com/photo-1660827718505-1070e803962b?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2070&q=80",
            //        MessageValue = "Test",
            //        Time = DateTime.Now,
            //        IsNativeOrigin = true
            //    });
            //}

            //Messages.Add(new Message
            //{
            //    UserName = "Person2",
            //    UserNameColor = "#409aff",
            //    ImageSource = "https://images.unsplash.com/photo-1660827718505-1070e803962b?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2070&q=80",
            //    MessageValue = "Last",
            //    Time = DateTime.Now,
            //    IsNativeOrigin = true
            //});

            Contacts.Add(new Contact
            {
                UserName = "Person 1",
                ImageSource = "https://images.unsplash.com/photo-1660827718505-1070e803962b?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2070&q=80",
                Messages = Messages
            });

            Contacts.Add(new Contact
            {
                UserName = "Person 2",
                ImageSource = "https://images.unsplash.com/photo-1660827718505-1070e803962b?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2070&q=80",
                Messages = Messages
            });
        }
    }
}