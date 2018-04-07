namespace Lands.Backend.Models
{
    using Lands.Domain;
    using System.Web;

    public class TeamView : Team
    {
        public HttpPostedFileBase ImageFile { get; set; }
    }
}