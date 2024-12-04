using System.Reactive.Subjects;

namespace USElectionsGitHubPages.State
{
    public class MockStateService : IStateService
    {
        public BehaviorSubject<double> CurrentlyChosenYear { get; set; } = new(2024);
    }
}
