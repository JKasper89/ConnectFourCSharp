
using ConnectFour.Main;
using ConnectFour.WpfClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour.WpfClient.SampleData
{
    
    public class PlayerViewModelSampleData : IPlayerViewModel
    {
        private readonly Player _player;
        public PlayerViewModelSampleData()
            : this("Player B", new Colour(0,0,128))
        {
            
        }
        public PlayerViewModelSampleData(string playerName, Colour playerColour)
        {
            var coins = new List<Coin>();
            for (var i = 0; i < 21; i++)
            {
                coins.Add(new Coin(playerColour, playerName));
            }
            _player = new Player(playerName,
                                coins,
                                playerColour);
            MyTurn = true;
        }
        public Player Player
        {
            get { return _player; }
        }
        public bool MyTurn { get; set; }
    }
}
