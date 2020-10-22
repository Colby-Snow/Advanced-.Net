/* this class is used to format the returned Json data formatted
 * into a list of objects
 * JsonProperty attribute can be used to change the name of fields
 * if serializing class objects to Json objects
 */

using Newtonsoft.Json;

namespace Consume_Public_API_REST_Countries
{
    public class CountryData
    {
        //[JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        //[JsonProperty(PropertyName = "capital")]
        public string Capital { get; set; }
        //[JsonProperty(PropertyName = "population")]
        public string Population { get; set; }
    }
}
