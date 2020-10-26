﻿using PrintMersion.Core.Interfaces;
using System.Collections.Generic;
namespace PrintMersion.Core.Entities
{
    public class Tool : IEntity
    {
        public Tool()
        {
            LogsTools = new HashSet<LogsTools>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }

        public virtual ICollection<LogsTools> LogsTools { get; set; }
    }
}
