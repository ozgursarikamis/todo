using System;
using System.Collections.Generic;

namespace Todo.Library.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string MailAddress { get; set; }
        public string Password { get; set; }
        public IEnumerable<Group> Groups { get; set; }
    }
}