using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mat_Chat_Working.Models
{

    namespace MatChatDBClassLib
    {

        public class Profile
        {
            public int StudentID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int SchoolID { get; set; }
            public BeltLevel Rank { get; set; }
            public int WeightInLbs { get; set; }
            public int HeightInInch { get; set; }
            public char CurrentlyInjured { get; set; }
            public string PhoneNumber { get; set; }
        }

        public enum BeltLevel
        {
            white,
            blue,
            purple,
            brown,
            black
        }
    }
}