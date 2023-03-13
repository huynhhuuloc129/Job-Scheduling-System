using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NienLuan1.Models
{
    public class Account
    {
        public string username;
        public string password;
        public string name;
        public DateTime dob;
        [JsonPropertyName("created_at")]
        public DateTime createdAt;
        [JsonPropertyName("shift_monday")]
        public int[] shiftMonday;
        [JsonPropertyName("shift_tuesday")]
        public int[] shiftTuesday;
        [JsonPropertyName("shift_wednesday")]
        public int[] shiftWednesday;
        [JsonPropertyName("shift_thursday")]
        public int[] shiftThursday;
        [JsonPropertyName("shift_friday")]
        public int[] shiftFriday;
        [JsonPropertyName("shift_saturday")]
        public int[] shiftSaturday;
        [JsonPropertyName("shift_sunday")]
        public int[] shiftSunday;
               public Account()
        {
            username = "";
            password = "";
            name = "";
            dob = DateTime.Now;
            createdAt = DateTime.Now;
            shiftMonday = new int[10];
            shiftTuesday = new int[10];
            shiftWednesday = new int[10];
            shiftThursday = new int[10];
            shiftFriday = new int[10];
            shiftSaturday = new int[10];
            shiftSunday = new int[10];
        }
        public Account(Account account)
        {
            shiftMonday = new int[10];
            shiftTuesday = new int[10];
            shiftWednesday = new int[10];
            shiftThursday = new int[10];
            shiftFriday = new int[10];
            shiftSaturday = new int[10];
            shiftSunday = new int[10];
            username = account.username;
            password = account.password;
            name = account.name;
            dob = account.dob;
            createdAt = account.createdAt;
            account.shiftMonday?.CopyTo(shiftMonday, 0);
            account.shiftTuesday?.CopyTo(shiftTuesday, 0);
            account.shiftWednesday?.CopyTo(shiftWednesday, 0);
            account.shiftThursday?.CopyTo(shiftThursday, 0);
            account.shiftFriday?.CopyTo(shiftFriday, 0);
            account.shiftSaturday?.CopyTo(shiftSaturday, 0);
            account.shiftSunday?.CopyTo(shiftSunday, 0);
        }
    }
    
}