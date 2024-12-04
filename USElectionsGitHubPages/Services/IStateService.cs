using System.Reactive.Subjects;

namespace USElectionsGitHubPages.State
{
    public interface IStateService
    {
        public BehaviorSubject<double> CurrentlyChosenYear { get; set; }
    }
}
