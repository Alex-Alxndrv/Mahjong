using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Maper
{
    public class SmartPairMaper : Maper
    {
        public override IEnumerator Place(Vector2[][] map, List<Tile> lst, Action callback, float placeWait)
        {
            var notPlacedLst = new List<Tile>();
            notPlacedLst.AddRange(lst);
            var placedLst = new List<Tile>();

            var rnd = new System.Random();

            Game.Instance.Tplist = TablePosition.GetTablePositions(map);

            while (notPlacedLst.Count != 0)
            {
                var t1 = notPlacedLst[rnd.Next(notPlacedLst.Count)];
                var t2 = notPlacedLst.FirstOrDefault(x => x.TyleType.CompareTag == t1.TyleType.CompareTag && x != t1);

                if (t2 == null)
                    continue;

                var freeTps = Game.Instance.Tplist.Where(x => x.IsEdge).ToArray();
                var p1 = freeTps[rnd.Next(freeTps.Length)];
                p1.SetTile(t1);

                t1.TablePositionValue = p1;
                //t1.GetComponent<Rigidbody>().isKinematic = true;
                t1.gameObject.SetActive(true);
                t1.Released = false;
                t1.transform.rotation = new Quaternion(0, 0, 0, 0);

                freeTps = Game.Instance.Tplist.Where(x => x.IsEdge).ToArray();
                var p2 = freeTps[rnd.Next(freeTps.Length)];
                p2.SetTile(t2);

                t2.TablePositionValue = p2;
                //t2.GetComponent<Rigidbody>().isKinematic = true;
                t2.gameObject.SetActive(true);
                t2.Released = false;
                t2.transform.rotation = new Quaternion(0, 0, 0, 0);

                placedLst.Add(t1);
                notPlacedLst.Remove(t1);
                placedLst.Add(t2);
                notPlacedLst.Remove(t2);

                if (placeWait == 0)
                    yield return null;
                else
                    yield return new WaitForSeconds(placeWait);
            }

            foreach (var tablePosition in Game.Instance.Tplist)
            {
                if (tablePosition.GameTile != null) tablePosition.GameTile.GetAround();
                else
                {
                    Debug.Log(tablePosition.Position);
                }
            }

            if (callback != null) callback();
        }
    }
}
