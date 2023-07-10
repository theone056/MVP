using System.ComponentModel;

namespace MVP.Models
{
    public class ProductViewModel
    {
        [DisplayName("ID")]
        public int Id { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Description")]
        public string Description { get; set; }
        [DisplayName("Link")]
        public string Link { get; set; }
    }
}
