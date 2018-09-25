using ConnectFour.Main;
using System.Collections.Generic;

namespace ConnectFour.WpfClient
{
    public interface IMainWindowViewModel
    {
        IBoardViewModel BoardViewModel { get; }
        IReadOnlyList<IPlayerViewModel> PlayerViewModels { get; }
        string WinnerName { get; }
    }
}
