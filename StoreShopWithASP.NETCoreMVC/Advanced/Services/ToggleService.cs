using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Advanced.Blazor;

namespace Advanced.Services
{
    public class ToggleService
    {
        private List<MutiNavLink> components = new List<MutiNavLink>();
        private bool enabled = true;
        public void EnrolComponents(IEnumerable<MutiNavLink> comps)
        {
            components.AddRange(comps);
        }
        public bool ToggleComponents()
        {
            enabled = !enabled;
            components.ForEach(c => c.SetEnabled(enabled));
            return enabled;
        }
    }
}
