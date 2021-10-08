using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TryDynamicComponent.Models
{
    class ComponentMetadata
    {
        public Type ComponentType { get; set; }
        public Dictionary<string, object> ComponentParameters { get; set; }

        public EditContext EditContext { get; set; }
    }
}
