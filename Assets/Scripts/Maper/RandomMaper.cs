using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Maper
{
    public class RandomMaper : Maper
    {
        public override IEnumerator Place(Vector2[][] map, List<Tile> lst, Action callback, float placeWait)
        {
            var notPlacedLst = new List<Tile>();
            notPlacedLst.AddRange(lst);
            var placedLst = new List<Tile>();

            var rnd = new System.Random();

            Game.Instance.Tplist = TablePosition.GetTablePositions(map);

            foreach (var tp in Game.Instance.Tplist)
            {
                var t = notPlacedLst[rnd.Next(notPlacedLst.Count)];

                t.TablePositionValue = tp;
                tp.GameTile = t;
                //t.GetComponent<Rigidbody>().isKinematic = true;
                t.gameObject.SetActive(true);
                t.Released = false;
                t.transform.rotation = new Quaternion(0, 0, 0, 0);

                placedLst.Add(t);
                notPlacedLst.Remove(t);


                if (placeWait == 0)
                    yield return null;
                else
                    yield return new WaitForSeconds(placeWait);
            }

            foreach (var tablePosition in Game.Instance.Tplist)
            {
                tablePosition.GameTile.GetAround();
            }

            if (callback != null) callback();
        }
    }

}
