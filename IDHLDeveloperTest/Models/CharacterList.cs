using Microsoft.AspNetCore.Mvc;

namespace IDHLDeveloperTest.Models
{
    public class CharacterList
    {
        [BindProperty(SupportsGet = true)]
        public int currentPage { get; set; } = 1;
        public int count { get; set; }
        public int pageSize { get; set; } = 50;

        public int totalPages => (int)Math.Ceiling(decimal.Divide(count, pageSize));
        public List<Character> data { get; set; } = new List<Character>();

        

    }
}
