﻿using System;
using System.Collections.Generic;

namespace MyTelegramBot
{
    public partial class Address
    {
        public Address()
        {
            OrderAddress = new HashSet<OrderAddress>();
            OrderTemp = new HashSet<OrderTemp>();
        }

        public int Id { get; set; }
        public int HouseId { get; set; }
        public int? FollowerId { get; set; }

        public Follower Follower { get; set; }
        public House House { get; set; }
        public ICollection<OrderAddress> OrderAddress { get; set; }
        public ICollection<OrderTemp> OrderTemp { get; set; }

        public override string ToString()
        {
            if (House != null && House.Street != null && House.Street.City != null)
            {
                return House.Street.City.Name + ", " + House.Street.Name + ", " + House.Number + ", " + House.Apartment;

            }

            else
                return String.Empty;
        }
    }
}
