namespace Todo.Domain.Entities
{
    public class Item
    {
        public Item(string title, string description)
        {
            Title = title;
            Description = description;

        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }


    }
}