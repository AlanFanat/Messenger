using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger
{
    public class User
    {
        public Guid Id { get; }
        public string Name { get; }
        public Dictionary<Guid, Dialog> Dialogs { get; private set;  }
        public User(string Name)
        {
            Id = Guid.NewGuid();
            this.Name = Name;
            Dialogs = new Dictionary<Guid, Dialog>();
        }
        public User(string Name, Guid Id)
        {
            this.Id = Id;
            this.Name = Name;
            Dialogs = new Dictionary<Guid, Dialog>();
        }
        public void AddMessage(Guid companionId, Message message)
        {
            Dialogs[companionId].Messages.Add(message);
        }
        public void UploadDialogs(Dictionary<Guid, Dialog> Dialogs)
        {
            this.Dialogs = Dialogs;
        }
    }
}
