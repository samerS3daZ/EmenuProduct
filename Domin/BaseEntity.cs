using System;
namespace BCM.Domain
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool Active { get; set; } = true;
    }
}

