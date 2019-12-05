using System.Collections.Generic;

namespace TailSpin.SpaceGame.Web.Models
{
    public class LeaderboardViewModel
    {
        // The game mode selected in the view.
        public string SelectedMode { get; set; }
        // The game region (map) selected in the view.
        public string SelectedRegion { get; set; }
        // The current page to be shown in the view.
        public int Page { get; set; }
        // The number of items to show per page in the view.
        public int PageSize { get; set; }

        // The scores to display in the view.
        public IEnumerable<ScoreProfile> Scores { get; set; }
        // The game modes to display in the view.
        public IEnumerable<string> GameModes { get; set; }
        // The game regions (maps) to display in the view.
        public IEnumerable<string> GameRegions { get; set; }

        // Hyperlink to the previous page of results.
        // This is empty if this is the first page.
        public string PrevLink { get; set; }
        // Hyperlink to the next page of results.
        // This is empty if this is the last page.
        public string NextLink { get; set; }
        // The total number of results for the selected game mode and region in the view.
        public int TotalResults { get; set; }
    }

    /// <summary>
    /// Combines a score and a user profile.
    /// </summary>
    public struct ScoreProfile
    {
        // The player's score.
        private Score _score;

        // The player's profile.
        private Profile _profile;

        public Score Score
        {
            get
            {
                return _score;
            }

            set
            {
                _score = value;
            }
        }

        public Profile Profile
        {
            get
            {
                return _profile;
            }

            set
            {
                _profile = value;
            }
        }
    }
}