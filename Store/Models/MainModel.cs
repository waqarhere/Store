namespace Store.Models
{
    public class MainModel
    {
        public MainModel()
        {
            this.id = Guid.NewGuid();
        }

        public Guid id { get; set; }
    }
}
