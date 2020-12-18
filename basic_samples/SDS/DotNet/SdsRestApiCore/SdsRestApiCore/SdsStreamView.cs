﻿using System.Collections.Generic;

namespace SdsRestApiCore
{
    public class SdsStreamView
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string SourceTypeId { get; set; }

        public string TargetTypeId { get; set; }

        public IList<SdsStreamViewProperty> Properties { get; set; }
    }
}
