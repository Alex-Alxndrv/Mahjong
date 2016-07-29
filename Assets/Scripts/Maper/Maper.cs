using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Maper
{
    public abstract class Maper
    {
        public abstract IEnumerator Place(Vector2[][] map, List<Tile> lst, Action callback, float placeWait);

        public static Maper GetMaper(bool isHard)
        {
            if (isHard)
                return new RandomMaper();
            else
                return new SmartPairMaper();
        }
    }
}
