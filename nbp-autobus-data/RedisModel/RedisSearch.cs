﻿using nbp_autobus_data.DTOs;
using nbp_autobus_data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nbp_autobus_data.RedisModel
{
    public class RedisSearch
    {
        public String TakeOfStationId { get; set; }
        public String ArrivalStationId { get; set; }
        public DateTime TakeOfDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public int NumberOfCards { get; set; }
        public float MaxCardPrice { get; set; }
        public List<RideType> RideTypes { get; set; }


        public RedisSearch()
        {
        }

        public RedisSearch(SearchDTO dto)
        {
            TakeOfStationId = dto.TakeOfStationId;
            ArrivalStationId = dto.ArrivalStationId;
            TakeOfDate = dto.TakeOfDate;
            ArrivalDate = dto.ArrivalDate;
            NumberOfCards = dto.NumberOfCards;
            MaxCardPrice = dto.MaxCardPrice;
            RideTypes = dto.RideTypes;
        }
    }
}
