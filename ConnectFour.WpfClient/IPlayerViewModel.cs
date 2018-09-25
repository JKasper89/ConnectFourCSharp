using ConnectFour.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ConnectFour.WpfClient
{
    public interface IPlayerViewModel
    {
        Player Player { get; }
        bool MyTurn { get; }
    }
}
