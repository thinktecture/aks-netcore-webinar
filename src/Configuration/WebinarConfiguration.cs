using System;
namespace Thinktecture.AKS.Webinar.Configuration
{
    public class WebinarConfiguration
    {
        public const string SECTION_NAME = "webinar";

        public WebinarConfiguration()
        {
        }

        public int ListLimit { get; set; }
    }
}
