namespace TailSpin.SpaceGame.Web.Models
{
    public class ProfileViewModel
    {
        private readonly Profile _profile;
        private readonly string _rank;

        public ProfileViewModel(Profile profile, string rank)
        {
            _profile = profile;
            _rank = rank;
        }

        // The player profile.
        public Profile Profile
        {
            get => _profile;
        }

        // The player's rank according to the active filter.
        public string Rank
        {
            get => _rank;
        }
    }
}