using System;

namespace MatinGallery.Domain.Entities.Commons
{
    public abstract class BaseEntityNoId
    {
        public DateTime InsertTime { get; set; } = DateTime.Now;
        public DateTime? UpdateTime { get; set; }
        public bool IsRemoved { get; set; } = false;
        public DateTime? RemoveTime { get; set; }
    }
}
