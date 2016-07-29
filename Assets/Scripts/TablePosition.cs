using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts
{
    public class TablePosition
    {
        public int Id;
        public Vector3 Position;
        public int Floor;
        public Tile GameTile;
        public List<TablePosition> Left;
        public List<TablePosition> Right;
        public List<TablePosition> Top;
        public List<TablePosition> Bottom;
        public bool IsEdge=false;

        public void CheckEdge()
        {
            if (GameTile == null)
            {
                if ((Top.Count == 0 || Top.Any(t => t.GameTile != null)) &&
                    ((Left.Count == 0 || Left.Any(t => t.GameTile != null)) ||
                     (Right.Count == 0 || Right.Any(t => t.GameTile != null))))
                {
                    IsEdge = true;
                }
            }
        }

        public void SetTile(Tile tile)
        {
            GameTile = tile;
            IsEdge = false;
            foreach (var tp in Bottom.Where(x=>x.GameTile==null))
            {
                tp.CheckEdge();
            }

            foreach (var tp in Right.Where(x => x.GameTile == null))
            {
                tp.CheckEdge();
            }

            foreach (var tp in Left.Where(x => x.GameTile == null))
            {
                tp.CheckEdge();
            }
        }

        public static List<TablePosition> GetTablePositions(Vector2[][] map)
        {
            var tplst = new List<TablePosition>();
            var f = 0;
            int k = 0;

            foreach (var stage in map)
            {
                foreach (var place in stage)
                {
                    var tp = new TablePosition
                    {
                        Position = new Vector3(place.x, f, place.y),
                        Left = new List<TablePosition>(),
                        Right = new List<TablePosition>(),
                        Bottom = new List<TablePosition>(),
                        Top = new List<TablePosition>(),
                        Floor = f,
                        Id = k
                    };
                    k++;

                    var l =
                        tplst.Where(
                            x =>
                                (x.Position.x == tp.Position.x - 1) && (x.Position.y == tp.Position.y) &&
                                (Math.Abs(x.Position.z - tp.Position.z) < 0.6f));
                    if (l.Count() != 0)
                    {
                        tp.Left.AddRange(l);
                        foreach (var ltile in l)
                        {
                            ltile.Right.Add(tp);
                        }
                    }

                    var r =
                        tplst.Where(
                            x =>
                                (x.Position.x == tp.Position.x + 1) && (x.Position.y == tp.Position.y) &&
                                (Math.Abs(x.Position.z - tp.Position.z) < 0.6f));
                    if (r.Count() != 0)
                    {
                        tp.Right.AddRange(r);

                        foreach (var rtile in r)
                        {
                            rtile.Left.Add(tp);
                        }
                    }

                    var b =
                        tplst.Where(
                            x =>
                                (Math.Abs(x.Position.x - tp.Position.x) < 0.6f) && (x.Position.y == tp.Position.y - 1) &&
                                (Math.Abs(x.Position.z - tp.Position.z) < 0.6f));
                    if (b.Count() != 0)
                    {
                        tp.Bottom.AddRange(b);
                        foreach (var btile in b)
                        {
                            btile.Top.Add(tp);
                        }
                    }

                    tplst.Add(tp);
                }
                f++;
            }

            foreach (var tp in tplst)
            {
                tp.CheckEdge();
            }

            return tplst;
        }
    }
}