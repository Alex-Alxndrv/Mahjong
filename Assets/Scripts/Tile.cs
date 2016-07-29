using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts
{
    public enum BlinkTypes
    {
        Hover,
        Selected,
        Wrong
    }

    public class Tile : MonoBehaviour
    {
        public int Id;
        public SpriteRenderer Sprite;
        public TileType TyleType;
        private TablePosition _tp;

        public Vector3 RealPosition;

        public List<Tile> Right = new List<Tile>();
        public List<Tile> Left = new List<Tile>();
        public List<Tile> Top = new List<Tile>();
        public List<Tile> Bottom = new List<Tile>();

        public bool Selected = false;
        public bool IsFree;
        public bool Released;

        public int ReleaseHeight = 100;

        private Animation _animation;

        //////////////////////////
        // public methods
        /////////////////////////

        public static Tile Create(TileType tileType, int id)
        {
            var t = Instantiate(Game.Instance.TilePrefab);
            t.Id = id;
            t.Set(tileType);
            t.transform.parent = Game.Instance.TilePrefab.transform.parent;

            return t;
        }

        public static bool Compare(Tile t1, Tile t2)
        {
            return (t1 != t2 &&
                    t1.TyleType.CompareTag == t2.TyleType.CompareTag &&
                    t1.IsFree && t2.IsFree);
        }

        public TablePosition TablePositionValue
        {
            get { return _tp; }
            set
            {
                _tp = value;
                Place();
            }
        }

        public void Set(TileType type)
        {
            TyleType = type;
            SetTile();
            gameObject.name = string.Format("{0}_{1}_{2}", Id, TyleType.Group,TyleType.Name);
        }

        [ExecuteInEditMode]
        [ContextMenu("Set Tile")]
        public void SetTile()
        {
            Debug.Log("Tiles/" + TyleType.Group + "_" + TyleType.Name);
            var tex = Resources.Load<Texture2D>("Tiles/" + TyleType.Group+"_"+ TyleType.Name);
            Sprite.sprite = UnityEngine.Sprite.Create(tex, new Rect(new Vector2(0, 0), new Vector2(tex.width, tex.height)), new Vector2(.5f, .5f));
        }

        public void CheckFreedom()
        {
            IsFree = Top.Count == 0 && (Left.Count == 0 || Right.Count == 0);
        }

        public void Select(bool on)
        {
            Selected = on;
            if (on)
            {
                _animation.Stop("Hover");
                _animation.Play("Selected");
                _animation["Selected"].wrapMode = WrapMode.Loop;
            }
            else
            {
                _animation["Selected"].wrapMode = WrapMode.Once;
            }
        }

        public void GetAround()
        {
            Left = TablePositionValue.Left.Where(y=>!y.GameTile.Released).Select(x => x.GameTile).ToList();
            Right = TablePositionValue.Right.Where(y => !y.GameTile.Released).Select(x => x.GameTile).ToList();
            Top = TablePositionValue.Top.Where(y => !y.GameTile.Released).Select(x => x.GameTile).ToList();
            Bottom = TablePositionValue.Bottom.Where(y => !y.GameTile.Released).Select(x => x.GameTile).ToList();
        }

        public void Release()
        {
            foreach (var tile in Bottom)
            {
                tile.Top.Remove(this);
                tile.CheckFreedom();
            }

            foreach (var tile in Right)
            {
                tile.Left.Remove(this);
                tile.CheckFreedom();
            }

            foreach (var tile in Left)
            {
                tile.Right.Remove(this);
                tile.CheckFreedom();
            }

            //GetComponent<Rigidbody>().isKinematic = true;
            Released = true;

            Game.Instance.ReleaseSound();
        }

        public void Return()
        {
            gameObject.SetActive(true);

            //GetComponent<Rigidbody>().isKinematic = false;
            Released = false;

            Place();

            foreach (var tile in Bottom)
            {
                tile.Top.Add(this);
                tile.CheckFreedom();
            }

            foreach (var tile in Right)
            {
                tile.Left.Add(this);
                tile.CheckFreedom();
            }

            foreach (var tile in Left)
            {
                tile.Right.Add(this);
                tile.CheckFreedom();
            }
        }


        public void Blink(BlinkTypes bt)
        {
            switch (bt)
            {
                case BlinkTypes.Hover:
                    break;
                case BlinkTypes.Selected:
                    break;
                case BlinkTypes.Wrong:
                    break;
                default:
                    throw new ArgumentOutOfRangeException("bt", bt, null);
            }
            
            _animation.Play(bt.ToString());
        }

        //////////////////////////
        // private methods
        /////////////////////////

        private void Place()
        {
            RealPosition = new Vector3(_tp.Position.x*transform.localScale.x, _tp.Position.y*transform.localScale.y, _tp.Position.z*transform.localScale.z);

            transform.position = RealPosition;
        }

        void Start()
        {
            _animation = GetComponent<Animation>();
        }

        void Update()
        {
            if (Released)
            {
                if (Math.Abs(transform.localPosition.y - (RealPosition.y + ReleaseHeight)) > 0.1f)
                {
                    transform.localPosition = Vector3.Lerp(transform.localPosition, RealPosition + Vector3.up*ReleaseHeight, Time.deltaTime*2);
                }
                else
                {
                    //Debug.Log("Release");
                    gameObject.SetActive(false);
                }
            }
        }

        void OnMouseDown()
        {
            //Debug.Log("Click");
            if (IsFree)
            {
                Select(true);
                Game.Instance.SelectTile(this);
            }
            else
            {
                Blink(BlinkTypes.Wrong);
            }
        }

        void OnMouseOver()
        {
            //if (!Selected)
            //    Blink();
        }
    }
}
