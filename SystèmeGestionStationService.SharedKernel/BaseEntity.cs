﻿using System.Collections.Generic;

namespace CleanArchitectureSGCP.SharedKernel
{
    // This can be modified to BaseEntity<TId> to support multiple key types (e.g. Guid)
    public abstract class BaseEntity 
    {
        public int Id { get; set; }

    }
}