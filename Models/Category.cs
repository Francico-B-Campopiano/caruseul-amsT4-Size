namespace AMST4.Carousel.Models
{
    public class Category
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public bool IsActive { get; set; }

        public DateTime Created { get; set; }

        public virtual List<Product> Product { get; set; }

    }
}
