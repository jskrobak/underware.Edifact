using System;
using System.Collections.Generic;
using System.Text;

namespace underware.Edifact
{
    public class MessageList : List<Message>
    {
        private Interchange _interchange;
        public MessageList(Interchange interchange)
        {
            _interchange = interchange;
        }

        public new void Add(Message msg)
        {
            base.Add(msg);
            msg.Interchange = _interchange;
        }
    }
}
