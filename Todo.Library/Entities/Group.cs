using System;
using System.Collections.Generic;

namespace Todo.Library.Entities
{
    public class Item
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public string Icon { get; set; }
    }
    public class Group : Item
    {
        public IEnumerable<List> Lists { get; set; }
    }

    public class List : Item
    {
        public IEnumerable<Task> Tasks { get; set; }
    }

    public class Task : Item
    {
        public IEnumerable<Step> Steps { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsOnMyDay { get; set; }
        public Reminder Reminder { get; set; }
        public Repeater Repeat { get; set; }
        public IEnumerable<File> Files { get; set; }
        public string Note { get; set; }
    }

    public class Step : Item
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }
}