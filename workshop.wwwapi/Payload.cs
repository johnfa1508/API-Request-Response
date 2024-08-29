﻿using workshop.wwwapi.Models;

namespace workshop.wwwapi
{
    public class Payload<T> where T : class
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public T Data { get; set; }
    }
}
