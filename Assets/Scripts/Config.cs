using System.Collections.Generic;

namespace Assets.Scripts
{
    public class Config
    {
        public int MapId;
        public bool Mute;
        public GameState State;

    }

    public class GameState
    {
        public double Seconds;
        public int MapId;
        public List<TileState> Tiles;
    }

    public class TileState
    {
        public int TileId;
        public int PositionId;
        public bool Released;
    }
}
