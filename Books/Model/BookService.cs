using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Books.Model
{
    public class BookService
    {
        public const string JSON_PATH =
            "https://mysafeinfo.com/api/data?list=bestnovels&format=json&case=default";

        public List<Book> Books { get; private set; }

        public async Task LoadBookAsync()
        {
            try
            {
                HttpClient client = new();
                var response = await client.GetAsync(JSON_PATH);
            }

            catch
            {

            }
        }
    }
}
