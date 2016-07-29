using JetBrains.Annotations;
using UnityEngine;

namespace Assets.Scripts
{
    public class TileType
    {
        public string CompareTag;
        public string Name;
        public Groups Group;

        public TileType(string value, Groups group)
        {
            Name = value;
            Group = group;
            CompareTag = group + "_" + value;
        }
    }

    public class GroupedTileType : TileType
    {
        public GroupedTileType(string value, Groups @group) : base(value, @group)
        {
            CompareTag = @group.ToString();
        }
    }

    public enum Groups
	{
		Numbers_Stones,
        Numbers_Bamboo,
        Numbers_Symbols,
        Winds,
        Dragons,
        Flowers,
		Seasons
	}

    public static class TileCollection
    {
        public static TileType[] TileSet = 
       {
            new TileType("1",Groups.Numbers_Stones), new TileType("2", Groups.Numbers_Stones),new TileType("3", Groups.Numbers_Stones),
            new TileType("4", Groups.Numbers_Stones), new TileType("5", Groups.Numbers_Stones),new TileType("6", Groups.Numbers_Stones),
            new TileType("7", Groups.Numbers_Stones), new TileType("8", Groups.Numbers_Stones),new TileType("9", Groups.Numbers_Stones),
            new TileType("1", Groups.Numbers_Stones), new TileType("2", Groups.Numbers_Stones),new TileType("3", Groups.Numbers_Stones),
            new TileType("4", Groups.Numbers_Stones), new TileType("5", Groups.Numbers_Stones),new TileType("6", Groups.Numbers_Stones),
            new TileType("7", Groups.Numbers_Stones), new TileType("8", Groups.Numbers_Stones),new TileType("9", Groups.Numbers_Stones),
            new TileType("1", Groups.Numbers_Stones), new TileType("2", Groups.Numbers_Stones),new TileType("3", Groups.Numbers_Stones),
            new TileType("4", Groups.Numbers_Stones), new TileType("5", Groups.Numbers_Stones),new TileType("6", Groups.Numbers_Stones),
            new TileType("7", Groups.Numbers_Stones), new TileType("8", Groups.Numbers_Stones),new TileType("9", Groups.Numbers_Stones),
			new TileType("1", Groups.Numbers_Stones), new TileType("2", Groups.Numbers_Stones),new TileType("3", Groups.Numbers_Stones),
            new TileType("4", Groups.Numbers_Stones), new TileType("5", Groups.Numbers_Stones),new TileType("6", Groups.Numbers_Stones),
            new TileType("7", Groups.Numbers_Stones), new TileType("8", Groups.Numbers_Stones),new TileType("9", Groups.Numbers_Stones),

			new TileType("1", Groups.Numbers_Bamboo),new TileType("2", Groups.Numbers_Bamboo),new TileType("3", Groups.Numbers_Bamboo),
			new TileType("4", Groups.Numbers_Bamboo),new TileType("5", Groups.Numbers_Bamboo),new TileType("6", Groups.Numbers_Bamboo),
			new TileType("7", Groups.Numbers_Bamboo),new TileType("8", Groups.Numbers_Bamboo),new TileType("9", Groups.Numbers_Bamboo),
			new TileType("1", Groups.Numbers_Bamboo),new TileType("2", Groups.Numbers_Bamboo),new TileType("3", Groups.Numbers_Bamboo),
			new TileType("4", Groups.Numbers_Bamboo),new TileType("5", Groups.Numbers_Bamboo),new TileType("6", Groups.Numbers_Bamboo),
			new TileType("7", Groups.Numbers_Bamboo),new TileType("8", Groups.Numbers_Bamboo),new TileType("9", Groups.Numbers_Bamboo),
			new TileType("1", Groups.Numbers_Bamboo),new TileType("2", Groups.Numbers_Bamboo),new TileType("3", Groups.Numbers_Bamboo),
			new TileType("4", Groups.Numbers_Bamboo),new TileType("5", Groups.Numbers_Bamboo),new TileType("6", Groups.Numbers_Bamboo),
			new TileType("7", Groups.Numbers_Bamboo),new TileType("8", Groups.Numbers_Bamboo),new TileType("9", Groups.Numbers_Bamboo),
			new TileType("1", Groups.Numbers_Bamboo),new TileType("2", Groups.Numbers_Bamboo),new TileType("3", Groups.Numbers_Bamboo),
			new TileType("4", Groups.Numbers_Bamboo),new TileType("5", Groups.Numbers_Bamboo),new TileType("6", Groups.Numbers_Bamboo),
			new TileType("7", Groups.Numbers_Bamboo),new TileType("8", Groups.Numbers_Bamboo),new TileType("9", Groups.Numbers_Bamboo),
			
			new TileType("1", Groups.Numbers_Symbols),new TileType("2", Groups.Numbers_Symbols),new TileType("3", Groups.Numbers_Symbols),
			new TileType("4", Groups.Numbers_Symbols),new TileType("5", Groups.Numbers_Symbols),new TileType("6", Groups.Numbers_Symbols),
			new TileType("7", Groups.Numbers_Symbols),new TileType("8", Groups.Numbers_Symbols),new TileType("9", Groups.Numbers_Symbols),
			new TileType("1", Groups.Numbers_Symbols),new TileType("2", Groups.Numbers_Symbols),new TileType("3", Groups.Numbers_Symbols),
			new TileType("4", Groups.Numbers_Symbols),new TileType("5", Groups.Numbers_Symbols),new TileType("6", Groups.Numbers_Symbols),
			new TileType("7", Groups.Numbers_Symbols),new TileType("8", Groups.Numbers_Symbols),new TileType("9", Groups.Numbers_Symbols),
			new TileType("1", Groups.Numbers_Symbols),new TileType("2", Groups.Numbers_Symbols),new TileType("3", Groups.Numbers_Symbols),
			new TileType("4", Groups.Numbers_Symbols),new TileType("5", Groups.Numbers_Symbols),new TileType("6", Groups.Numbers_Symbols),
			new TileType("7", Groups.Numbers_Symbols),new TileType("8", Groups.Numbers_Symbols),new TileType("9", Groups.Numbers_Symbols),
			new TileType("1", Groups.Numbers_Symbols),new TileType("2", Groups.Numbers_Symbols),new TileType("3", Groups.Numbers_Symbols),
			new TileType("4", Groups.Numbers_Symbols),new TileType("5", Groups.Numbers_Symbols),new TileType("6", Groups.Numbers_Symbols),
			new TileType("7", Groups.Numbers_Symbols),new TileType("8", Groups.Numbers_Symbols),new TileType("9", Groups.Numbers_Symbols),
          
			new TileType("1_East", Groups.Winds),new TileType("2_West", Groups.Winds),new TileType("3_South", Groups.Winds),new TileType("4_North", Groups.Winds),
            new TileType("1_East", Groups.Winds),new TileType("2_West", Groups.Winds),new TileType("3_South", Groups.Winds),new TileType("4_North", Groups.Winds),
            new TileType("1_East", Groups.Winds),new TileType("2_West", Groups.Winds),new TileType("3_South", Groups.Winds),new TileType("4_North", Groups.Winds),
            new TileType("1_East", Groups.Winds),new TileType("2_West", Groups.Winds),new TileType("3_South", Groups.Winds),new TileType("4_North", Groups.Winds),

            new TileType("1_Red", Groups.Dragons), new TileType("2_Green", Groups.Dragons),new TileType("3_White", Groups.Dragons),
            new TileType("1_Red", Groups.Dragons), new TileType("2_Green", Groups.Dragons),new TileType("3_White", Groups.Dragons),
            new TileType("1_Red", Groups.Dragons), new TileType("2_Green", Groups.Dragons),new TileType("3_White", Groups.Dragons),
            new TileType("1_Red", Groups.Dragons), new TileType("2_Green", Groups.Dragons),new TileType("3_White", Groups.Dragons),

            new GroupedTileType("1_Plum", Groups.Flowers), new GroupedTileType("2_Orchid", Groups.Flowers), new GroupedTileType("3_Chrys", Groups.Flowers), new GroupedTileType("4_Bamboo", Groups.Flowers),

            new GroupedTileType("1_Spring", Groups.Seasons), new GroupedTileType("2_Summer", Groups.Seasons), new GroupedTileType("3_Fall", Groups.Seasons), new GroupedTileType("4_Winter", Groups.Seasons), 
        };

        public static Vector2[][][] Layouts = new[]
        {
            
            #region Tortuga

            new[]
            {
                new[]
                {
                    new Vector2(-5.5f, 3.5f),
                    new Vector2(-4.5f, 3.5f),
                    new Vector2(-3.5f, 3.5f),
                    new Vector2(-2.5f, 3.5f),
                    new Vector2(-1.5f, 3.5f),
                    new Vector2(-.5f, 3.5f),
                    new Vector2(.5f, 3.5f),
                    new Vector2(1.5f, 3.5f),
                    new Vector2(2.5f, 3.5f),
                    new Vector2(3.5f, 3.5f),
                    new Vector2(4.5f, 3.5f),
                    new Vector2(5.5f, 3.5f),

                    new Vector2(-3.5f, 2.5f),
                    new Vector2(-2.5f, 2.5f),
                    new Vector2(-1.5f, 2.5f),
                    new Vector2(-.5f, 2.5f),
                    new Vector2(.5f, 2.5f),
                    new Vector2(1.5f, 2.5f),
                    new Vector2(2.5f, 2.5f),
                    new Vector2(3.5f, 2.5f),

                    new Vector2(-4.5f, 1.5f),
                    new Vector2(-3.5f, 1.5f),
                    new Vector2(-2.5f, 1.5f),
                    new Vector2(-1.5f, 1.5f),
                    new Vector2(-.5f, 1.5f),
                    new Vector2(.5f, 1.5f),
                    new Vector2(1.5f, 1.5f),
                    new Vector2(2.5f, 1.5f),
                    new Vector2(3.5f, 1.5f),
                    new Vector2(4.5f, 1.5f),

                    new Vector2(-5.5f, .5f),
                    new Vector2(-4.5f, .5f),
                    new Vector2(-3.5f, .5f),
                    new Vector2(-2.5f, .5f),
                    new Vector2(-1.5f, .5f),
                    new Vector2(-.5f, .5f),
                    new Vector2(.5f, .5f),
                    new Vector2(1.5f, .5f),
                    new Vector2(2.5f, .5f),
                    new Vector2(3.5f, .5f),
                    new Vector2(4.5f, .5f),
                    new Vector2(5.5f, .5f),

                    new Vector2(-6.5f, 0),
                    new Vector2(6.5f, 0),
                    new Vector2(7.5f, 0),

                    new Vector2(-5.5f, -.5f),
                    new Vector2(-4.5f, -.5f),
                    new Vector2(-3.5f, -.5f),
                    new Vector2(-2.5f, -.5f),
                    new Vector2(-1.5f, -.5f),
                    new Vector2(-.5f, -.5f),
                    new Vector2(.5f, -.5f),
                    new Vector2(1.5f, -.5f),
                    new Vector2(2.5f, -.5f),
                    new Vector2(3.5f, -.5f),
                    new Vector2(4.5f, -.5f),
                    new Vector2(5.5f, -.5f),

                    new Vector2(-4.5f, -1.5f),
                    new Vector2(-3.5f, -1.5f),
                    new Vector2(-2.5f, -1.5f),
                    new Vector2(-1.5f, -1.5f),
                    new Vector2(-.5f, -1.5f),
                    new Vector2(.5f, -1.5f),
                    new Vector2(1.5f, -1.5f),
                    new Vector2(2.5f, -1.5f),
                    new Vector2(3.5f, -1.5f),
                    new Vector2(4.5f, -1.5f),

                    new Vector2(-3.5f, -2.5f),
                    new Vector2(-2.5f, -2.5f),
                    new Vector2(-1.5f, -2.5f),
                    new Vector2(-.5f, -2.5f),
                    new Vector2(.5f, -2.5f),
                    new Vector2(1.5f, -2.5f),
                    new Vector2(2.5f, -2.5f),
                    new Vector2(3.5f, -2.5f),

                    new Vector2(-5.5f, -3.5f),
                    new Vector2(-4.5f, -3.5f),
                    new Vector2(-3.5f, -3.5f),
                    new Vector2(-2.5f, -3.5f),
                    new Vector2(-1.5f, -3.5f),
                    new Vector2(-.5f, -3.5f),
                    new Vector2(.5f, -3.5f),
                    new Vector2(1.5f, -3.5f),
                    new Vector2(2.5f, -3.5f),
                    new Vector2(3.5f, -3.5f),
                    new Vector2(4.5f, -3.5f),
                    new Vector2(5.5f, -3.5f),
                },

                new[]
                {
                    new Vector2(-2.5f, 2.5f),
                    new Vector2(-1.5f, 2.5f),
                    new Vector2(-.5f, 2.5f),
                    new Vector2(.5f, 2.5f),
                    new Vector2(1.5f, 2.5f),
                    new Vector2(2.5f, 2.5f),

                    new Vector2(-2.5f, 1.5f),
                    new Vector2(-1.5f, 1.5f),
                    new Vector2(-.5f, 1.5f),
                    new Vector2(.5f, 1.5f),
                    new Vector2(1.5f, 1.5f),
                    new Vector2(2.5f, 1.5f),

                    new Vector2(-2.5f, .5f),
                    new Vector2(-1.5f, .5f),
                    new Vector2(-.5f, .5f),
                    new Vector2(.5f, .5f),
                    new Vector2(1.5f, .5f),
                    new Vector2(2.5f, .5f),

                    new Vector2(-2.5f, -.5f),
                    new Vector2(-1.5f, -.5f),
                    new Vector2(-.5f, -.5f),
                    new Vector2(.5f, -.5f),
                    new Vector2(1.5f, -.5f),
                    new Vector2(2.5f, -.5f),

                    new Vector2(-2.5f, -1.5f),
                    new Vector2(-1.5f, -1.5f),
                    new Vector2(-.5f, -1.5f),
                    new Vector2(.5f, -1.5f),
                    new Vector2(1.5f, -1.5f),
                    new Vector2(2.5f, -1.5f),

                    new Vector2(-2.5f, -2.5f),
                    new Vector2(-1.5f, -2.5f),
                    new Vector2(-.5f, -2.5f),
                    new Vector2(.5f, -2.5f),
                    new Vector2(1.5f, -2.5f),
                    new Vector2(2.5f, -2.5f),

                },

                new[]
                {
                    new Vector2(-1.5f, 1.5f),
                    new Vector2(-.5f, 1.5f),
                    new Vector2(.5f, 1.5f),
                    new Vector2(1.5f, 1.5f),

                    new Vector2(-1.5f, .5f),
                    new Vector2(-.5f, .5f),
                    new Vector2(.5f, .5f),
                    new Vector2(1.5f, .5f),

                    new Vector2(-1.5f, -.5f),
                    new Vector2(-.5f, -.5f),
                    new Vector2(.5f, -.5f),
                    new Vector2(1.5f, -.5f),

                    new Vector2(-1.5f, -1.5f),
                    new Vector2(-.5f, -1.5f),
                    new Vector2(.5f, -1.5f),
                    new Vector2(1.5f, -1.5f),
                },
                new[]
                {
                    new Vector2(-.5f, .5f),
                    new Vector2(.5f, .5f),
                    new Vector2(-.5f, -.5f),
                    new Vector2(.5f, -.5f),
                },

                new[]
                {
                    new Vector2(0, 0)
                }
            },

            #endregion

            #region Dragon

            new[]
            {

                new[]
                {
                    new Vector2(-6, 3.5f),
                    new Vector2(-5, 3.5f),
                    new Vector2(-4, 3.5f),
                    new Vector2(4, 3.5f),
                    new Vector2(5, 3.5f),
                    new Vector2(6, 3.5f),

                    new Vector2(-7, 3f),
                    new Vector2(-3, 3f),
                    new Vector2(3, 3f),
                    new Vector2(7, 3f),

                    new Vector2(-2, 2.5f),
                    new Vector2(-1, 2.5f),
                    new Vector2(0, 2.5f),
                    new Vector2(1, 2.5f),
                    new Vector2(2, 2.5f),

                    new Vector2(-7f, 2f),
                    new Vector2(-4.5f, 2f),
                    new Vector2(4.5f, 2f),
                    new Vector2(7f, 2f),

                    new Vector2(-2, 1.5f),
                    new Vector2(2, 1.5f),

                    new Vector2(-7, 1f),
                    new Vector2(7, 1f),

                    new Vector2(-6, 0.5f),
                    new Vector2(-5, 0.5f),
                    new Vector2(-4, 0.5f),
                    new Vector2(-3, 0.5f),
                    new Vector2(-2, 0.5f),
                    new Vector2(0, 0.5f),
                    new Vector2(2, 0.5f),
                    new Vector2(3, 0.5f),
                    new Vector2(4, 0.5f),
                    new Vector2(5, 0.5f),
                    new Vector2(6, 0.5f),

                    new Vector2(-4, -0.5f),
                    new Vector2(-2, -0.5f),
                    new Vector2(2, -0.5f),
                    new Vector2(4, -0.5f),

                    new Vector2(-5, -1.5f),
                    new Vector2(-4, -1.5f),
                    new Vector2(-3, -1.5f),
                    new Vector2(-2, -1.5f),
                    new Vector2(-1, -1.5f),
                    new Vector2(0, -1.5f),
                    new Vector2(1, -1.5f),
                    new Vector2(2, -1.5f),
                    new Vector2(3, -1.5f),
                    new Vector2(4, -1.5f),
                    new Vector2(5, -1.5f),

                    new Vector2(-5, -2.5f),
                    new Vector2(5, -2.5f),

                    new Vector2(-3, -3f),
                    new Vector2(-1, -3f),
                    new Vector2(1, -3f),
                    new Vector2(3, -3f),


                    new Vector2(-5, -3.5f),
                    new Vector2(-4, -3.5f),
                    new Vector2(-2, -3.5f),
                    new Vector2(0, -3.5f),
                    new Vector2(2, -3.5f),
                    new Vector2(4, -3.5f),
                    new Vector2(5, -3.5f),
                },

                new[]
                {
                    new Vector2(-6, 3.5f),
                    new Vector2(-5, 3.5f),
                    new Vector2(-4, 3.5f),
                    new Vector2(4, 3.5f),
                    new Vector2(5, 3.5f),
                    new Vector2(6, 3.5f),

                    new Vector2(-7, 3f),
                    new Vector2(-3, 3f),
                    new Vector2(3, 3f),
                    new Vector2(7, 3f),

                    new Vector2(-1, 2.5f),
                    new Vector2(0, 2.5f),
                    new Vector2(1, 2.5f),

                    new Vector2(-7f, 2f),
                    new Vector2(-4.5f, 2f),
                    new Vector2(4.5f, 2f),
                    new Vector2(7f, 2f),

                    new Vector2(-2, 1.5f),
                    new Vector2(2, 1.5f),

                    new Vector2(-7, 1f),
                    new Vector2(7, 1f),

                    new Vector2(-6, 0.5f),
                    new Vector2(-5, 0.5f),
                    new Vector2(-4, 0.5f),
                    new Vector2(-2, 0.5f),
                    new Vector2(0, 0.5f),
                    new Vector2(2, 0.5f),
                    new Vector2(4, 0.5f),
                    new Vector2(5, 0.5f),
                    new Vector2(6, 0.5f),

                    new Vector2(-4, -0.5f),
                    new Vector2(-2, -0.5f),
                    new Vector2(2, -0.5f),
                    new Vector2(4, -0.5f),

                    new Vector2(-5, -1.5f),
                    new Vector2(-2, -1.5f),
                    new Vector2(-1, -1.5f),
                    new Vector2(0, -1.5f),
                    new Vector2(1, -1.5f),
                    new Vector2(2, -1.5f),
                    new Vector2(5, -1.5f),

                    new Vector2(-5, -2.5f),
                    new Vector2(5, -2.5f),

                    new Vector2(-3, -3f),
                    new Vector2(-1, -3f),
                    new Vector2(1, -3f),
                    new Vector2(3, -3f),

                    new Vector2(-5, -3.5f),
                    new Vector2(5, -3.5f),
                },

                new[]
                {
                    new Vector2(-5, 3.5f),
                    new Vector2(5, 3.5f),

                    new Vector2(-3, 3f),
                    new Vector2(3, 3f),

                    new Vector2(0, 2.5f),

                    new Vector2(-7f, 2f),
                    new Vector2(7f, 2f),

                    new Vector2(-5, 0.5f),
                    new Vector2(5, 0.5f),

                    new Vector2(-5, -1.5f),
                    new Vector2(5, -1.5f),

                    new Vector2(-5, -2.5f),
                    new Vector2(5, -2.5f),

                    new Vector2(-3, -3f),
                    new Vector2(-1, -3f),
                    new Vector2(1, -3f),
                    new Vector2(3, -3f),

                    new Vector2(-5, -3.5f),
                    new Vector2(5, -3.5f),
                },
                new[]
                {
                    new Vector2(-5, 3.5f),
                    new Vector2(5, 3.5f),
                    new Vector2(-7f, 2f),
                    new Vector2(7f, 2f),
                    new Vector2(-5, 0.5f),
                    new Vector2(5, 0.5f),
                    new Vector2(-5, -1.5f),
                    new Vector2(5, -1.5f),
                    new Vector2(-5, -2.5f),
                    new Vector2(5, -2.5f),
                    new Vector2(-3, -3f),
                    new Vector2(-1, -3f),
                    new Vector2(1, -3f),
                    new Vector2(3, -3f),
                },
            },


            #endregion

            #region Fortress

            new[]
            {
                new[] // 1 floor
                {
                    new Vector2(-5f, 3.5f),
                    new Vector2(-4f, 3.5f),
                    new Vector2(-3f, 3.5f),
                    new Vector2(3f, 3.5f),
                    new Vector2(4f, 3.5f),
                    new Vector2(5f, 3.5f),

                    new Vector2(-5f, 2.5f),
                    new Vector2(-3f, 2.5f),
                    new Vector2(3f, 2.5f),
                    new Vector2(5f, 2.5f),

                    new Vector2(-2f, 2f),
                    new Vector2(-1f, 2f),
                    new Vector2(0f, 2f),
                    new Vector2(1f, 2f),
                    new Vector2(2f, 2f),

                    new Vector2(-5f, 1.5f),
                    new Vector2(-4f, 1.5f),
                    new Vector2(-3f, 1.5f),
                    new Vector2(3f, 1.5f),
                    new Vector2(4f, 1.5f),
                    new Vector2(5f, 1.5f),

                    new Vector2(-2f, 1f),
                    new Vector2(2f, 1f),

                    new Vector2(-2f, 0f),
                    new Vector2(2f, 0f),

                    new Vector2(-2f, -1f),
                    new Vector2(2f, -1f),

                    new Vector2(-5f, -1.5f),
                    new Vector2(-4f, -1.5f),
                    new Vector2(-3f, -1.5f),
                    new Vector2(3f, -1.5f),
                    new Vector2(4f, -1.5f),
                    new Vector2(5f, -1.5f),

                    new Vector2(-2f, -2f),
                    new Vector2(-1f, -2f),
                    new Vector2(0f, -2f),
                    new Vector2(1f, -2f),
                    new Vector2(2f, -2f),

                    new Vector2(-5f, -2.5f),
                    new Vector2(-3f, -2.5f),
                    new Vector2(3f, -2.5f),
                    new Vector2(5f, -2.5f),

                    new Vector2(-5f, -3.5f),
                    new Vector2(-4f, -3.5f),
                    new Vector2(-3f, -3.5f),
                    new Vector2(3f, -3.5f),
                    new Vector2(4f, -3.5f),
                    new Vector2(5f, -3.5f),
                },
                new[] //2floor
                {
                    new Vector2(-5f, 3.5f),
                    new Vector2(-4f, 3.5f),
                    new Vector2(-3f, 3.5f),
                    new Vector2(3f, 3.5f),
                    new Vector2(4f, 3.5f),
                    new Vector2(5f, 3.5f),

                    new Vector2(-5f, 2.5f),
                    new Vector2(-3f, 2.5f),
                    new Vector2(3f, 2.5f),
                    new Vector2(5f, 2.5f),

                    new Vector2(-2f, 2f),
                    new Vector2(-1f, 2f),
                    new Vector2(0f, 2f),
                    new Vector2(1f, 2f),
                    new Vector2(2f, 2f),

                    new Vector2(-5f, 1.5f),
                    new Vector2(-4f, 1.5f),
                    new Vector2(-3f, 1.5f),
                    new Vector2(3f, 1.5f),
                    new Vector2(4f, 1.5f),
                    new Vector2(5f, 1.5f),

                    new Vector2(-2f, 1f),
                    new Vector2(2f, 1f),

                    new Vector2(-2f, 0f),
                    new Vector2(2f, 0f),

                    new Vector2(-2f, -1f),
                    new Vector2(2f, -1f),

                    new Vector2(-5f, -1.5f),
                    new Vector2(-4f, -1.5f),
                    new Vector2(-3f, -1.5f),
                    new Vector2(3f, -1.5f),
                    new Vector2(4f, -1.5f),
                    new Vector2(5f, -1.5f),

                    new Vector2(-2f, -2f),
                    new Vector2(-1f, -2f),
                    new Vector2(0f, -2f),
                    new Vector2(1f, -2f),
                    new Vector2(2f, -2f),

                    new Vector2(-5f, -2.5f),
                    new Vector2(-3f, -2.5f),
                    new Vector2(3f, -2.5f),
                    new Vector2(5f, -2.5f),

                    new Vector2(-5f, -3.5f),
                    new Vector2(-4f, -3.5f),
                    new Vector2(-3f, -3.5f),
                    new Vector2(3f, -3.5f),
                    new Vector2(4f, -3.5f),
                    new Vector2(5f, -3.5f),
                },
                new[] //3floor
                {
                    new Vector2(-5f, 3.5f),
                    new Vector2(-4f, 3.5f),
                    new Vector2(-3f, 3.5f),
                    new Vector2(3f, 3.5f),
                    new Vector2(4f, 3.5f),
                    new Vector2(5f, 3.5f),

                    new Vector2(-5f, 2.5f),
                    new Vector2(-3f, 2.5f),
                    new Vector2(3f, 2.5f),
                    new Vector2(5f, 2.5f),

                    new Vector2(-2f, 2f),
                    new Vector2(0f, 2f),
                    new Vector2(2f, 2f),

                    new Vector2(-5f, 1.5f),
                    new Vector2(-4f, 1.5f),
                    new Vector2(-3f, 1.5f),
                    new Vector2(3f, 1.5f),
                    new Vector2(4f, 1.5f),
                    new Vector2(5f, 1.5f),

                    new Vector2(-2f, 0f),
                    new Vector2(2f, 0f),

                    new Vector2(-5f, -1.5f),
                    new Vector2(-4f, -1.5f),
                    new Vector2(-3f, -1.5f),
                    new Vector2(3f, -1.5f),
                    new Vector2(4f, -1.5f),
                    new Vector2(5f, -1.5f),

                    new Vector2(-2f, -2f),
                    new Vector2(0f, -2f),
                    new Vector2(2f, -2f),

                    new Vector2(-5f, -2.5f),
                    new Vector2(-3f, -2.5f),
                    new Vector2(3f, -2.5f),
                    new Vector2(5f, -2.5f),

                    new Vector2(-5f, -3.5f),
                    new Vector2(-4f, -3.5f),
                    new Vector2(-3f, -3.5f),
                    new Vector2(3f, -3.5f),
                    new Vector2(4f, -3.5f),
                    new Vector2(5f, -3.5f),
                },

                new[] //4floor
                {
                    new Vector2(-5f, 3.5f),
                    new Vector2(5f, 3.5f),

                    new Vector2(-3f, 1.5f),
                    new Vector2(3f, 1.5f),

                    new Vector2(-5f, -1.5f),
                    new Vector2(5f, -1.5f),

                    new Vector2(-3f, -3.5f),
                    new Vector2(3f, -3.5f),
                }
            },

            #endregion

            #region Cat
            new[]
            {
                new[]
                {
                    new Vector2(6, 3.5f),

                    new Vector2(7, 3),

                    new Vector2(8, 2.5f),

                    new Vector2(0, 1.5f),
                    new Vector2(1, 1.5f),
                    new Vector2(2, 1.5f),
                    new Vector2(3, 1.5f),
                    new Vector2(4, 1.5f),
                    new Vector2(5, 1.5f),
                    new Vector2(6, 1.5f),
                    new Vector2(9, 1.5f),

                    new Vector2(-1, 1),

                    new Vector2(-7, .5f),
                    new Vector2(-6, .5f),
                    new Vector2(-5, .5f),
                    new Vector2(-4, .5f),
                    new Vector2(0, .5f),
                    new Vector2(1, .5f),
                    new Vector2(2, .5f),
                    new Vector2(3, .5f),
                    new Vector2(4, .5f),
                    new Vector2(5, .5f),
                    new Vector2(6, .5f),
                    new Vector2(7, .5f),
                    new Vector2(9, .5f),

                    new Vector2(-2, 0),
                    new Vector2(-1, 0),

                    new Vector2(-8, -.5f),
                    new Vector2(-7, -.5f),
                    new Vector2(-6, -.5f),
                    new Vector2(-5, -.5f),
                    new Vector2(-4, -.5f),
                    new Vector2(0, -.5f),
                    new Vector2(1, -.5f),
                    new Vector2(2, -.5f),
                    new Vector2(3, -.5f),
                    new Vector2(4, -.5f),
                    new Vector2(5, -.5f),
                    new Vector2(6, -.5f),
                    new Vector2(7, -.5f),
                    new Vector2(8, -.5f),

                    new Vector2(-2, -1),
                    new Vector2(-1, -1),

                    new Vector2(-8, -1.5f),
                    new Vector2(-7, -1.5f),
                    new Vector2(-6, -1.5f),
                    new Vector2(-5, -1.5f),
                    new Vector2(-4, -1.5f),
                    new Vector2(0, -1.5f),
                    new Vector2(1, -1.5f),
                    new Vector2(2, -1.5f),
                    new Vector2(3, -1.5f),
                    new Vector2(4, -1.5f),
                    new Vector2(5, -1.5f),
                    new Vector2(6, -1.5f),
                    new Vector2(7, -1.5f),
                    new Vector2(8, -1.5f),

                    new Vector2(-2, -2),
                    new Vector2(-1, -2),

                    new Vector2(-8, -2.5f),
                    new Vector2(-7, -2.5f),
                    new Vector2(-6, -2.5f),
                    new Vector2(-5, -2.5f),
                    new Vector2(-4, -2.5f),
                    new Vector2(0, -2.5f),
                    new Vector2(1, -2.5f),
                    new Vector2(2, -2.5f),
                    new Vector2(3, -2.5f),
                    new Vector2(4, -2.5f),
                    new Vector2(5, -2.5f),
                    new Vector2(6, -2.5f),
                    new Vector2(7, -2.5f),
                    new Vector2(8, -2.5f),

                    new Vector2(-3, -3),
                    new Vector2(-1, -3),

                    new Vector2(-7, -3.5f),
                    new Vector2(-6, -3.5f),
                    new Vector2(-5, -3.5f),
                    new Vector2(-4, -3.5f),
                    new Vector2(0, -3.5f),
                    new Vector2(1, -3.5f),
                    new Vector2(2, -3.5f),
                    new Vector2(3, -3.5f),
                    new Vector2(4, -3.5f),
                    new Vector2(5, -3.5f),
                    new Vector2(6, -3.5f),
                    new Vector2(7, -3.5f),
                },

                new[]
                {
                    new Vector2(6, 3.5f),

                    new Vector2(7, 3),

                    new Vector2(8, 2.5f),

                    new Vector2(1, .5f),
                    new Vector2(2, .5f),
                    new Vector2(3, .5f),
                    new Vector2(4, .5f),
                    new Vector2(5, .5f),
                    new Vector2(6, .5f),

                    new Vector2(-6, -.5f),
                    new Vector2(-5, -.5f),
                    new Vector2(0, -.5f),
                    new Vector2(1, -.5f),
                    new Vector2(2, -.5f),
                    new Vector2(3, -.5f),
                    new Vector2(4, -.5f),
                    new Vector2(5, -.5f),
                    new Vector2(6, -.5f),
                    new Vector2(7, -.5f),

                    new Vector2(-1, -1),

                    new Vector2(-7, -1.5f),
                    new Vector2(-6, -1.5f),
                    new Vector2(-5, -1.5f),
                    new Vector2(-4, -1.5f),
                    new Vector2(0, -1.5f),
                    new Vector2(1, -1.5f),
                    new Vector2(2, -1.5f),
                    new Vector2(3, -1.5f),
                    new Vector2(4, -1.5f),
                    new Vector2(5, -1.5f),
                    new Vector2(6, -1.5f),
                    new Vector2(7, -1.5f),

                    new Vector2(-6, -2.5f),
                    new Vector2(-5, -2.5f),
                    new Vector2(1, -2.5f),
                    new Vector2(2, -2.5f),
                    new Vector2(3, -2.5f),
                    new Vector2(4, -2.5f),
                    new Vector2(5, -2.5f),
                    new Vector2(6, -2.5f),
                },
                new[]
                {
                    new Vector2(1, -.5f),
                    new Vector2(2, -.5f),
                    new Vector2(3, -.5f),
                    new Vector2(4, -.5f),
                    new Vector2(5, -.5f),

                    new Vector2(-6, -1),
                    new Vector2(-5, -1),

                    new Vector2(1, -1.5f),
                    new Vector2(2, -1.5f),
                    new Vector2(3, -1.5f),
                    new Vector2(4, -1.5f),
                    new Vector2(5, -1.5f),

                    new Vector2(-6, -2),
                    new Vector2(-5, -2),
                },
                new[]
                {
                    new Vector2(2, -1),
                    new Vector2(3, -1),
                    new Vector2(4, -1),
                }
            },

            #endregion

            #region Crab
            new[]
            {
                new[]
                {
                    new Vector2(-6, 3.5f),
                    new Vector2(-5, 3.5f),
                    new Vector2(-4, 3.5f),
                    new Vector2(-3, 3.5f),
                    new Vector2(3, 3.5f),
                    new Vector2(4, 3.5f),
                    new Vector2(5, 3.5f),
                    new Vector2(6, 3.5f),

                    new Vector2(-6, 2.5f),
                    new Vector2(-5, 2.5f),
                    new Vector2(-4, 2.5f),
                    new Vector2(-3, 2.5f),
                    new Vector2(-0.5f, 2.5f),
                    new Vector2(0.5f, 2.5f),
                    new Vector2(3, 2.5f),
                    new Vector2(4, 2.5f),
                    new Vector2(5, 2.5f),
                    new Vector2(6, 2.5f),

                    new Vector2(-4, 1.5f),
                    new Vector2(-3, 1.5f),
                    new Vector2(-2, 1.5f),
                    new Vector2(-1, 1.5f),
                    new Vector2(0, 1.5f),
                    new Vector2(1, 1.5f),
                    new Vector2(2, 1.5f),
                    new Vector2(3, 1.5f),
                    new Vector2(4, 1.5f),

                    new Vector2(-6.5f, 0.5f),
                    new Vector2(-5.5f, 0.5f),
                    new Vector2(-2, 0.5f),
                    new Vector2(-1, 0.5f),
                    new Vector2(0, 0.5f),
                    new Vector2(1, 0.5f),
                    new Vector2(2, 0.5f),
                    new Vector2(5.5f, 0.5f),
                    new Vector2(6.5f, 0.5f),

                    new Vector2(-6.5f, -0.5f),
                    new Vector2(-2.5f, -0.5f),
                    new Vector2(-1.5f, -0.5f),
                    new Vector2(-0.5f, -0.5f),
                    new Vector2(0.5f, -0.5f),
                    new Vector2(1.5f, -0.5f),
                    new Vector2(2.5f, -0.5f),
                    new Vector2(6.5f, -0.5f),

                    new Vector2(-4.5f, -1.5f),
                    new Vector2(-3.5f, -1.5f),
                    new Vector2(-2.5f, -1.5f),
                    new Vector2(-1.5f, -1.5f),
                    new Vector2(-0.5f, -1.5f),
                    new Vector2(0.5f, -1.5f),
                    new Vector2(1.5f, -1.5f),
                    new Vector2(2.5f, -1.5f),
                    new Vector2(3.5f, -1.5f),
                    new Vector2(4.5f, -1.5f),

                    new Vector2(-6.5f, -2.5f),
                    new Vector2(-5.5f, -2.5f),
                    new Vector2(-4.5f, -2.5f),
                    new Vector2(-3.5f, -2.5f),
                    new Vector2(-1.5f, -2.5f),
                    new Vector2(-0.5f, -2.5f),
                    new Vector2(0.5f, -2.5f),
                    new Vector2(1.5f, -2.5f),
                    new Vector2(3.5f, -2.5f),
                    new Vector2(4.5f, -2.5f),
                    new Vector2(5.5f, -2.5f),
                    new Vector2(6.5f, -2.5f),

                    new Vector2(-6.5f, -3.5f),
                    new Vector2(-5.5f, -3.5f),
                    new Vector2(-4.5f, -3.5f),
                    new Vector2(-3.5f, -3.5f),
                    new Vector2(-1, -3.5f),
                    new Vector2(0, -3.5f),
                    new Vector2(1, -3.5f),
                    new Vector2(3.5f, -3.5f),
                    new Vector2(4.5f, -3.5f),
                    new Vector2(5.5f, -3.5f),
                    new Vector2(6.5f, -3.5f),
                },
                new[]
                {
                    new Vector2(-5, 3.5f),
                    new Vector2(-4, 3.5f),
                    new Vector2(-3, 3.5f),
                    new Vector2(3, 3.5f),
                    new Vector2(4, 3.5f),
                    new Vector2(5, 3.5f),

                    new Vector2(-5, 2.5f),
                    new Vector2(-4, 2.5f),
                    new Vector2(-3, 2.5f),
                    new Vector2(-0.5f, 2.5f),
                    new Vector2(0.5f, 2.5f),
                    new Vector2(3, 2.5f),
                    new Vector2(4, 2.5f),
                    new Vector2(5, 2.5f),

                    new Vector2(-3, 1.5f),
                    new Vector2(3, 1.5f),

                    new Vector2(-6.5f, 0.5f),
                    new Vector2(-5.5f, 0.5f),
                    new Vector2(-1, 0.5f),
                    new Vector2(0, 0.5f),
                    new Vector2(1, 0.5f),
                    new Vector2(5.5f, 0.5f),
                    new Vector2(6.5f, 0.5f),

                    new Vector2(-6.5f, -0.5f),
                    new Vector2(-1.5f, -0.5f),
                    new Vector2(-0.5f, -0.5f),
                    new Vector2(0.5f, -0.5f),
                    new Vector2(1.5f, -0.5f),
                    new Vector2(6.5f, -0.5f),

                    new Vector2(-2.5f, -1.5f),
                    new Vector2(-1.5f, -1.5f),
                    new Vector2(-0.5f, -1.5f),
                    new Vector2(0.5f, -1.5f),
                    new Vector2(1.5f, -1.5f),
                    new Vector2(2.5f, -1.5f),

                    new Vector2(-5.5f, -2.5f),
                    new Vector2(-4.5f, -2.5f),
                    new Vector2(-3.5f, -2.5f),
                    new Vector2(3.5f, -2.5f),
                    new Vector2(4.5f, -2.5f),
                    new Vector2(5.5f, -2.5f),

                    new Vector2(-5.5f, -3.5f),
                    new Vector2(-4.5f, -3.5f),
                    new Vector2(-3.5f, -3.5f),
                    new Vector2(-1, -3.5f),
                    new Vector2(0, -3.5f),
                    new Vector2(1, -3.5f),
                    new Vector2(3.5f, -3.5f),
                    new Vector2(4.5f, -3.5f),
                    new Vector2(5.5f, -3.5f),
                },
                new[]
                {
                    new Vector2(-4.5f, 3),
                    new Vector2(-3.5f, 3),
                    new Vector2(3.5f, 3),
                    new Vector2(4.5f, 3),

                    new Vector2(0, 2.5f),

                    new Vector2(0, 0.5f),

                    new Vector2(-0.5f, -0.5f),
                    new Vector2(0.5f, -0.5f),

                    new Vector2(-0.5f, -1.5f),
                    new Vector2(0.5f, -1.5f),

                    new Vector2(-5, -3),
                    new Vector2(-4, -3),
                    new Vector2(4, -3),
                    new Vector2(5, -3),

                    new Vector2(0, -3.5f),
                },
                new[]
                {
                    new Vector2(0, -0.5f),

                    new Vector2(0, -1.5f),
                }
            },

            #endregion

            #region Spider
            new[]
            {
                new[]
                {
                    new Vector2(-4.5f, 3.5f),
                    new Vector2(-3.5f, 3.5f),
                    new Vector2(-1, 3.5f),
                    new Vector2(1, 3.5f),
                    new Vector2(3.5f, 3.5f),
                    new Vector2(4.5f, 3.5f),

                    new Vector2(-3.5f, 2.5f),
                    new Vector2(-.5f, 2.5f),
                    new Vector2(.5f, 2.5f),
                    new Vector2(3.5f, 2.5f),

                    new Vector2(-6.5f, 2),
                    new Vector2(-2.5f, 2),
                    new Vector2(2.5f, 2),
                    new Vector2(6.5f, 2),

                    new Vector2(-5.5f, 1.5f),
                    new Vector2(-1.5f, 1.5f),
                    new Vector2(-.5f, 1.5f),
                    new Vector2(.5f, 1.5f),
                    new Vector2(1.5f, 1.5f),
                    new Vector2(5.5f, 1.5f),

                    new Vector2(-4.5f, 1),
                    new Vector2(-3.5f, 1),
                    new Vector2(3.5f, 1),
                    new Vector2(4.5f, 1),

                    new Vector2(-2.5f, .5f),
                    new Vector2(-1.5f, .5f),
                    new Vector2(-.5f, .5f),
                    new Vector2(.5f, .5f),
                    new Vector2(1.5f, .5f),
                    new Vector2(2.5f, .5f),

                    new Vector2(-3, -.5f),
                    new Vector2(-2, -.5f),
                    new Vector2(-1, -.5f),
                    new Vector2(0, -.5f),
                    new Vector2(1, -.5f),
                    new Vector2(2, -.5f),
                    new Vector2(3, -.5f),

                    new Vector2(-7, -1),
                    new Vector2(-6, -1),
                    new Vector2(-5, -1),
                    new Vector2(-4, -1),
                    new Vector2(4, -1),
                    new Vector2(5, -1),
                    new Vector2(6, -1),
                    new Vector2(7, -1),

                    new Vector2(-2.5f, -1.5f),
                    new Vector2(-1.5f, -1.5f),
                    new Vector2(-.5f, -1.5f),
                    new Vector2(.5f, -1.5f),
                    new Vector2(1.5f, -1.5f),
                    new Vector2(2.5f, -1.5f),

                    new Vector2(-3.5f, -2.5f),
                    new Vector2(-1.5f, -2.5f),
                    new Vector2(-.5f, -2.5f),
                    new Vector2(.5f, -2.5f),
                    new Vector2(1.5f, -2.5f),
                    new Vector2(3.5f, -2.5f),

                    new Vector2(-4.5f, -3),
                    new Vector2(4.5f, -3),

                    new Vector2(-6.5f, -3.5f),
                    new Vector2(-5.5f, -3.5f),
                    new Vector2(-.5f, -3.5f),
                    new Vector2(.5f, -3.5f),
                    new Vector2(5.5f, -3.5f),
                    new Vector2(6.5f, -3.5f),
                },

                new[]
                {
                    new Vector2(-4.5f, 3.5f),
                    new Vector2(-3.5f, 3.5f),
                    new Vector2(-1, 3.5f),
                    new Vector2(1, 3.5f),
                    new Vector2(3.5f, 3.5f),
                    new Vector2(4.5f, 3.5f),

                    new Vector2(-3.5f, 2.5f),
                    new Vector2(3.5f, 2.5f),

                    new Vector2(-6.5f, 2),
                    new Vector2(-2.5f, 2),
                    new Vector2(2.5f, 2),
                    new Vector2(6.5f, 2),

                    new Vector2(-5.5f, 1.5f),
                    new Vector2(-.5f, 1.5f),
                    new Vector2(.5f, 1.5f),
                    new Vector2(5.5f, 1.5f),

                    new Vector2(-4.5f, 1),
                    new Vector2(-3.5f, 1),
                    new Vector2(3.5f, 1),
                    new Vector2(4.5f, 1),

                    new Vector2(-1.5f, .5f),
                    new Vector2(-.5f, .5f),
                    new Vector2(.5f, .5f),
                    new Vector2(1.5f, .5f),

                    new Vector2(-2, -.5f),
                    new Vector2(-1, -.5f),
                    new Vector2(0, -.5f),
                    new Vector2(1, -.5f),
                    new Vector2(2, -.5f),

                    new Vector2(-7, -1),
                    new Vector2(-6, -1),
                    new Vector2(-5, -1),
                    new Vector2(-4, -1),
                    new Vector2(4, -1),
                    new Vector2(5, -1),
                    new Vector2(6, -1),
                    new Vector2(7, -1),

                    new Vector2(-1.5f, -1.5f),
                    new Vector2(-.5f, -1.5f),
                    new Vector2(.5f, -1.5f),
                    new Vector2(1.5f, -1.5f),

                    new Vector2(-3.5f, -2.5f),
                    new Vector2(-.5f, -2.5f),
                    new Vector2(.5f, -2.5f),
                    new Vector2(3.5f, -2.5f),

                    new Vector2(-4.5f, -3),
                    new Vector2(4.5f, -3),

                    new Vector2(-6.5f, -3.5f),
                    new Vector2(-5.5f, -3.5f),
                    new Vector2(-.5f, -3.5f),
                    new Vector2(.5f, -3.5f),
                    new Vector2(5.5f, -3.5f),
                    new Vector2(6.5f, -3.5f),
                },

                new[]
                {
                    new Vector2(-3.5f, 3.5f),
                    new Vector2(3.5f, 3.5f),

                    new Vector2(-6.5f, 2),
                    new Vector2(-2.5f, 2),
                    new Vector2(2.5f, 2),
                    new Vector2(6.5f, 2),

                    new Vector2(-4.5f, 1),
                    new Vector2(4.5f, 1),

                    new Vector2(-.5f, .5f),
                    new Vector2(.5f, .5f),

                    new Vector2(-1, -.5f),
                    new Vector2(0, -.5f),
                    new Vector2(1, -.5f),

                    new Vector2(-7, -1),
                    new Vector2(-5, -1),
                    new Vector2(5, -1),
                    new Vector2(7, -1),

                    new Vector2(-.5f, -1.5f),
                    new Vector2(.5f, -1.5f),

                    new Vector2(-.5f, -2.5f),
                    new Vector2(.5f, -2.5f),

                    new Vector2(-4.5f, -3),
                    new Vector2(4.5f, -3),

                    new Vector2(-6.5f, -3.5f),
                    new Vector2(6.5f, -3.5f),
                },

                new[]
                {
                    new Vector2(0, -1),
                }

            }
            #endregion
        };
    }
}
