using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyPracticeSite.Models
{
    //Contains information from json file
    public class Product
    {

        public string Id { get; set; }
        public string Maker { get; set; }
        [JsonPropertyName("img")]
        public string Image { get; set; }
        
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int[] Ratings { get; set; }

        public float AvrRatings
        {
            get {
                double total = 0;
                try
                {
                    foreach (int i in this.Ratings)
                    {
                        total += i;
                    }
               
                    total = total / Ratings.Length;
                }
                catch(NullReferenceException e)
                {
                    return -1;
                }
                return (float)Math.Round(total, 3);
            }
            
            

        }

        public override string ToString()
        {
            return JsonSerializer.Serialize<Product>(this);
           
        }
    }
}
