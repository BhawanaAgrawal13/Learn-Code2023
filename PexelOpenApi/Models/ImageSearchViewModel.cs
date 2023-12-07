using PexelOpenApi.Service;

namespace PexelOpenApi.Models
{
    public class ImageSearchViewModel
    {
        public string Search { get; set; }
        public List<PexelsPhoto> SearchResults { get; set; }
    }

}
