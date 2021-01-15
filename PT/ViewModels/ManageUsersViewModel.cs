using PT.Models;

namespace PT.Models
{
    public class ManageUsersViewModel
    {
        public ApplicationUser[] Administrators { get; set; }

        public ApplicationUser[] Users { get; set; }
    }
}