using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using static KeqingNiuza.Wish.Const;
using System.IO;
using System.Text.Json.Serialization;

namespace KeqingNiuza.Wish
{
    public class WishEvent
    {
        public WishType WishType { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public List<string> UpStar5 { get; set; }
        public List<string> UpStar4 { get; set; }

        [JsonIgnore]
        public string DisplayName
        {
            get
            {
                if (WishType == WishType.WeaponEvent)
                {
                    return $"{UpStar5[0]} {UpStar5[1]}";
                }
                else
                {
                    return Name;
                }
            }
        }

        [JsonIgnore]
        public string UpItems
        {
            get
            {
                string result = "";
                foreach (var item in UpStar5)
                {
                    result += $" {item}";
                }
                foreach (var item in UpStar4)
                {
                    result += $" {item}";
                }
                return result.Trim();
            }
        }
    }
}