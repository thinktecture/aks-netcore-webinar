using System;

namespace Thinktecture.AKS.Webinar.Models
{
    public class ProductListItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Meta Meta => new Meta();
    }
}
