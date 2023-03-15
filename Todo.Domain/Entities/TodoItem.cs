namespace Todo.Domain.Entities
{
    public class TodoItem : Entity
    {
        public TodoItem(string title, string user, DateTime date)
        {
            Title = title;
            Done = false;
            Date = date;
            User = user;
        }

        public string Title { get; private set; } = string.Empty;
        public bool Done { get; private set; }
        public DateTime Date { get; private set; }
        public string User { get; private set; } = string.Empty;

        public void MarkAsDone()
        {
            Done = true;
        }
        public void MarkAsUnDone()
        {
            Done = false;
        }
        public void UpdateTitle(string title)
        {
            Title = title;
        }
    }
}