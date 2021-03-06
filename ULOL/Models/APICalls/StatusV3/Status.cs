﻿using System;

namespace ULOL.Models.APICalls.StatusV3
{

    public class Status
    {
        public string name { get; set; }
        public string region_tag { get; set; }
        public string hostname { get; set; }
        public Service[] services { get; set; }
        public string slug { get; set; }
        public string[] locales { get; set; }
    }

    public class Service
    {
        public string status { get; set; }
        public Incident[] incidents { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
    }

    public class Incident
    {
        public bool active { get; set; }
        public DateTime created_at { get; set; }
        public int id { get; set; }
        public Update[] updates { get; set; }
    }

    public class Update
    {
        public string severity { get; set; }
        public string author { get; set; }
        public DateTime created_at { get; set; }
        public object[] translations { get; set; }
        public DateTime updated_at { get; set; }
        public string content { get; set; }
        public string id { get; set; }
    }

}