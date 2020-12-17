using System;

namespace Services.ServiceModels
{
    public class RoleSM
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string NormalizedName { get; set; }
    }
}
