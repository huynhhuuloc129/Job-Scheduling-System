using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NienLuan1.Models
{
    public class Shift
    {
        [JsonPropertyName("time_start")]
        public TimeOnly timeStart;
        [JsonPropertyName("time_end")]
        public TimeOnly timeEnd;
    }
}
