﻿using System.Net.Mail;

namespace SafeSpeak.API.Models
{
    public class Message
    {
        public int Id { get; set; }
        public int ConversationId { get; set; }
        public int SenderId { get; set; }
        public string Content { get; set; }
        public DateTime SentAt { get; set; }
        public User Sender { get; set; }
        public Conversation Conversation { get; set; }
    }

}
