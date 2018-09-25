using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour.WpfClient
{
    public class MainWindowViewModel : IMainWindowViewModel
    {
        private readonly IReadOnlyList<IPlayerViewModel> _playerViewModels;
        private readonly string _winnerName;

        public MainWindowViewModel(IReadOnlyList<IPlayerViewModel> playerViewModels)
        {
            _playerViewModels = playerViewModels;
        }
        public IReadOnlyList<IPlayerViewModel> PlayerViewModels
        {
            get { return _playerViewModels; }
        }

        public IBoardViewModel BoardViewModel
        {
            get { return null; }
        }

        public string WinnerName
        {
            get { return _winnerName; }
        }
            }
}
