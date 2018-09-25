namespace ConnectFour.Main
{
    public interface IColumn
    {
        void DropCoin(Coin coin);
        bool IsColumnFull { get; }
    }
}
