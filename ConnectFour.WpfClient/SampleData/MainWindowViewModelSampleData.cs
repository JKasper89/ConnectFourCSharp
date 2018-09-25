using ConnectFour.WpfClient.SampleData;
using ConnectFour.WpfClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectFour.Main;

namespace ConnectFour.WpfClient.SampleData
{
    public class MainWindowViewModelSampleData : IMainWindowViewModel
    {
        private readonly IReadOnlyList<IPlayerViewModel> _playerViewModels;

        public MainWindowViewModelSampleData()
        {
            var playerViewModels = new List<IPlayerViewModel>();
            playerViewModels.Add(new PlayerViewModelSampleData("Player A",new Main.Colour(128,0,0)));
            playerViewModels.Add(new PlayerViewModelSampleData("Player B",new Main.Colour(0,0,128))
            {
                MyTurn= false
            });
            _playerViewModels = playerViewModels;
        }

        public IBoardViewModel BoardViewModel
        {
            get { return null; }
        }

        public IReadOnlyList<IPlayerViewModel> PlayerViewModels
        {
            get { return _playerViewModels; }
        }

        
        public string WinnerName
        {
            get { return _playerViewModels[0].Player.Name; }
        }
    }
}
