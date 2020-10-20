using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Newtonsoft.Json;

namespace AquariumService
{
    /// <summary>
    /// Summary description for AquariumService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AquariumService : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetFish()
        {
            using (Entities context = new Entities())
            {

                //Get the list of Fish from the database
                var fishList = (from f in context.Fish
                                select f).ToList<Fish>();
                               

                if (fishList.Count > 0)
                {
                    return JsonConvert.SerializeObject(fishList, Formatting.Indented,
                                   new JsonSerializerSettings()
                                   {
                                       ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                                   });
                }
                else
                {
                    return "Table empty";
                }


            }
        }

        [WebMethod]
        public string GetFishTypeAndFish()
        {
            using (Entities2 context = new Entities2())
            {

                //Get the list of FishTypes, and their associated Fish from the database
                var fishTypeList = (from f in context.FishTypes
                                select f).ToList<FishType>();


                if (fishTypeList.Count > 0)
                {
                    return JsonConvert.SerializeObject(fishTypeList, Formatting.Indented,
                                   new JsonSerializerSettings()
                                   {
                                       ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                                   });
                }
                else
                {
                    return "Table empty";
                }


            }
        }

        [WebMethod]
        public string GetSpecFishTypeAndFish(string fType)
        {
            using (Entities2 context = new Entities2())
            {

                //Get the specific FishType, and its associated Fish from the database
                var fishTypeList = (from f in context.FishTypes
                                    where f.Type == fType
                                    select f).ToList<FishType>();


                if (fishTypeList.Count > 0)
                {
                    return JsonConvert.SerializeObject(fishTypeList, Formatting.Indented,
                                   new JsonSerializerSettings()
                                   {
                                       ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                                   });
                }
                else
                {
                    return "Table empty";
                }


            }
        }

        [WebMethod]
        public string GetFishTypeAndFishByDescription(string fDesc)
        {
            using (Entities2 context = new Entities2())
            {

                //Get the list of FishTypes based on description, and their associated Fish from the database
                var fishTypeList = (from f in context.FishTypes
                                    where f.Description.Contains(fDesc)
                                    select f).ToList<FishType>();


                if (fishTypeList.Count > 0)
                {
                    return JsonConvert.SerializeObject(fishTypeList, Formatting.Indented,
                                   new JsonSerializerSettings()
                                   {
                                       ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                                   });
                }
                else
                {
                    return "Table empty";
                }


            }
        }

        /// <summary>
        /// Uses the Sum method on the Cost column of the Fish table to calculate total cost of all fish.
        /// </summary>
        /// <returns>total cost of all fish</returns>
        [WebMethod]
        public decimal GetFishTotalCost()
        {
            using (Entities context = new Entities())
            {

                //Get the total cost of all Fish from the database
                var fishTotCost = (from f in context.Fish
                                   select f.Cost).Sum();


                return (decimal)fishTotCost;


            }
        }
    }
}
