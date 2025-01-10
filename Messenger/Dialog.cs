using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger
{
    public class Dialog : IEnumerable<Message>
    {
        public Guid FirstUserId { get; }
        public Guid SecondUserId { get; }
        public List<Message> Messages { get; }
        public Dialog(Guid FirstUserId, Guid SecondUserId)
        {
            this.FirstUserId = FirstUserId;
            this.SecondUserId = SecondUserId;
            Messages = new List<Message>();
        }
        public Dialog(Guid FirstUserId, Guid SecondUserId, List<Message> Messages)
        {
            this.FirstUserId = FirstUserId;
            this.SecondUserId = SecondUserId;
            this.Messages = Messages;
        }

        public IEnumerator<Message> GetEnumerator()
        {
            //IEnumerator enumerator = new DialogNumerator(Messages);
            return ((IEnumerable<Message>)Messages).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)Messages).GetEnumerator();
        }
    }

    public class DialogNumerator : IEnumerator<Message>
    {
        public List<Message> Messages { get; set; }
        public int Index { get; set; }
        public DialogNumerator(List<Message> Messages)
        {
            this.Messages = Messages;
            Index = -1;
        }
        public Message Current => Messages[Index];

        object IEnumerator.Current => Messages[Index];

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            Index++;
            return Index < Messages.Count;
        }

        public void Reset()
        {
            Index = -1;
        }
    }

    public class Message
    {
        public Guid UserId { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }

        public Message(Guid UserId, string Text)
        {
            this.UserId = UserId;
            this.Text = Text;
            Time = DateTime.Now;
        }
    }
}
