using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ConnectFour.Main;

namespace ConnectFour.WpfClient
{
    public class PlayerViewModel : IPlayerViewModel, INotifyPropertyChanged
    {
        private readonly Player _player;
        private bool _myTurn;
        public PlayerViewModel(Player player)
        {
            _player = player ?? throw new ArgumentNullException("player")
;
        }

        public Player Player
        {
            get {return _player; }
        }

        public bool MyTurn
        {
            get { return _myTurn; }
            set
            {
                if (_myTurn == value) return;
                _myTurn = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
