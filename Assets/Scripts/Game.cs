using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Assets.Scripts.Maper;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.ImageEffects;

namespace Assets.Scripts
{
    public class Game : MonoBehaviour
    {
        public static Game Instance;

        public MenuWindow Menu;
        public UiResultWindow ResultWindow;
        public Camera TableCamera;
        
        public Text LabelStatusTime;

        public GameObject HUD;
        public SystemPlayer OstPlayer;

        private List<Tile> _tileSet=new List<Tile>();
        public Tile TilePrefab;
        public Tile SelectedTile;

        public List<TablePosition> Tplist;
        
        public List<Tile[]> PairList=new List<Tile[]>();
        public List<Tile[]> RemovedStack = new List<Tile[]>();

        public float TilePlaceSpeed=0.01f;
        
        public TimeSpan GameTimer;

        public AudioClip[] ClickSounds;

        private bool _isGame=false;
        private bool _mute = false;
        private int _pairCount;
        private int _tileCount;

        //////////////////////////
        // public methods
        /////////////////////////

        public void NewGame(Maper.Maper maper, Vector2[][] map)
        {
            Reset(maper, map);

            ShowMenu(false);
        }

        public void ResumeGame()
        {
            ShowMenu(false);
            if (PairList.Count > 0)
                _isGame = true;
        }

        public void OpenMenu()
        {
            _isGame = false;
            ShowMenu(true);
        }

        public void PlayGameCheat()
        {
            StartCoroutine(PlayGameCheatCoroutine());
        }

        public void SelectTile(Tile t)
        {
            if (SelectedTile == null)
            {
                SelectedTile = t;
            }
            else
            {
                if (Tile.Compare(SelectedTile, t))
                {
                    RemovedStack.Add(new []{SelectedTile,t});
                    SelectedTile.Release();
                    t.Release();
                    CalculatePairs();
                }

                SelectedTile.Select(false);
                t.Select(false);
                SelectedTile = null;
            }
        }

        [ContextMenu("Fall")]
        public void TilesFall()
        {
            foreach (var t in _tileSet.Where(t => t.Released))
            {
                t.gameObject.SetActive(true);
                t.Released = false;
                t.GetComponent<Rigidbody>().isKinematic = false;
            }
        }

        [ContextMenu("Blink All Free")]
        public void BlinkAllFree()
        {
            foreach (var t in _tileSet.Where(t => t.IsFree))
            {
                t.Blink(BlinkTypes.Hover);
            }
        }

        [ContextMenu("Blink Random Pair")]
        public void BlinkRandomPair()
        {
            var p = GetRandomPair();
            if (p == null) return;
            foreach (var t in p)
            {
                t.Blink(BlinkTypes.Hover);
            }
        }

        [ContextMenu("Release Random Pair")]
        public void ReleaseRandomPair()
        {
            var p = GetRandomPair();
            if (p == null) return;

            RemovedStack.Add(p);

            foreach (var t in p)
            {
                t.Release();
            }
            CalculatePairs();
        }

        public void ReleaseSound()
        {
            //var rnd = new System.Random();

            //GetComponent<AudioSource>().clip = ClickSounds[rnd.Next(ClickSounds.Length)];
            //GetComponent<AudioSource>().Play();
        }

        public void Undo()
        {
            if (_isGame && (RemovedStack.Count > 0))
            {
                var p = RemovedStack[RemovedStack.Count - 1];

                foreach (var tile in p)
                {
                    tile.Return();
                }

                RemovedStack.Remove(p);
                CalculatePairs();

                Debug.Log("Undo");
            }
        }

        public void Mute(bool on)
        {
            _mute = on;

            OstPlayer.SetMute(_mute);
            GetComponent<AudioSource>().mute = _mute;

            ResultWindow.As.mute = _mute;
        }   

        //////////////////////////
        // private methods
        /////////////////////////
        
        void Start ()
        {
            Instance = this;

            foreach (var tileType in TileCollection.TileSet)
            {
                _tileSet.Add(Tile.Create(tileType, _tileSet.Count));
            }

            OpenMenu();

            OstPlayer.Play();
        }

        void Awake()
        {
            //Debug.Log("Awake");
        }

        void OnApplicationFocus(bool focusStatus)
        {
            //Debug.Log("OnApplicationFocus:" +focusStatus);
        }

        void OnApplicationPause(bool pauseStatus)
        {
            //Debug.Log("OnApplicationPause:" + pauseStatus);
        }

        void OnApplicationQuit()
        {
            //Debug.Log("OnApplicationQuit");
        }

        float _undoTimeout = 10000;
        void Update()
        {
            _undoTimeout += Time.deltaTime;
            if (Input.GetKey(KeyCode.Escape) &&(_undoTimeout > 0.2f))
            { 
                Undo();
                _undoTimeout = 0;
            }

            var delta = Time.deltaTime;
            if (_isGame)
            {
                GameTimer += TimeSpan.FromSeconds(delta);
                LabelStatusTime.text = string.Format("{0}:{1} | Всего пар: {2} | Осталось костей: {3}", GameTimer.Minutes, GameTimer.Seconds, _pairCount, _tileCount);
            }
        }

        private void Reset(Maper.Maper maper, Vector2[][] map)
        {
            if (SelectedTile != null)
            {
                SelectedTile.Select(false);
                SelectedTile = null;
            }

            GameTimer = TimeSpan.Zero;

            StartCoroutine(maper.Place(map, _tileSet, () =>
            {
                foreach (var tile in _tileSet)
                {
                    tile.CheckFreedom();
                }

                CalculatePairs();

                _isGame = true;
            },TilePlaceSpeed));
        }

        private void ShowMenu(bool on)
        {
            if (on)
                Menu.Show(false);
            else
                Menu.Hide();
            
            TableCamera.GetComponent<BlurOptimized>().enabled = on;
            HUD.SetActive(!on);
        }

        private IEnumerator PlayGameCheatCoroutine()
        {
            while (PairList.Count != 0)
            {
                ReleaseRandomPair();
                yield return new WaitForSeconds(0.1f);
            }
        }

        private void CalculatePairs()
        {
            var freeTiles = _tileSet.Where(t => t.IsFree && !t.Released).ToArray();

            PairList=new List<Tile[]>();

            for (int i = 0; i < freeTiles.Count(); i++)
            {
                for (int j = i+1; j < freeTiles.Count(); j++  )
                {
                    if (freeTiles[i].TyleType.CompareTag== freeTiles[j].TyleType.CompareTag)
                        PairList.Add(new [] { freeTiles[i], freeTiles[j] });
                }
            }

            _tileCount = _tileSet.Count(t => !t.Released);
            _pairCount = PairList.Count;
            //LabelStatusPairs.text = string.Format("Всего пар:{0}", PairList.Count);
            //LabelStatusTiles.text = string.Format("Всего костей: {0}", _tileSet.Count(t => !t.Released));

            if (PairList.Count==0)
                Result();

        }

        private void Result()
        {
            bool win = _tileSet.All(t => t.Released);

            ResultWindow.Show(win);

            _isGame = false;

            TableCamera.GetComponent<BlurOptimized>().enabled =true;
            HUD.SetActive(false);
        }

        private Tile[] GetRandomPair()
        {
            System.Random rnd = new System.Random();
            if (PairList.Count > 0)
            {
                return PairList[rnd.Next(PairList.Count)];
            }
            return null;
        }

      //  private void Save()
        //{
            //_cfg.State = new GameState {Tiles = new List<TileState>(), Seconds = GameTimer.TotalSeconds, MapId = _cfg.MapId};

            //foreach (var tile in _tileSet)
            //{
            //    _cfg.State.Tiles.Add(
            //        new TileState()
            //        {
            //            PositionId = tile.TablePositionValue.Id,
            //            TileId = tile.Id,
            //            Released = tile.Released
            //        });
            //}


            //var jsonCfg = JsonWriter.Serialize(_cfg);
            //File.WriteAllText(_cfgPath,jsonCfg);
        //}

        //private void Restore()
        //{
        //    Vector2[][] map=null;

        //    switch (_cfg.State.MapId)
        //    {
        //        case 1:
        //            map = TileCollection.LayoutTortuga;
        //            break;
        //        case 2:
        //            map = TileCollection.LayoutDragon;
        //            break;
        //        case 3:
        //            map = TileCollection.LayoutFortress;
        //            break;
        //        case 4:
        //            map = TileCollection.LayoutCat;
        //            break;
        //        case 5:
        //            map = TileCollection.LayoutCrab;
        //            break;
        //        case 6:
        //            map = TileCollection.LayoutSpider;
        //            break;
        //    }

        //    Tplist = TablePosition.GetTablePositions(map);

        //    foreach (var tileState in _cfg.State.Tiles)
        //    {
        //        var t = _tileSet.FirstOrDefault(x => x.Id == tileState.TileId);
        //        var tp = Tplist.FirstOrDefault(y => y.Id == tileState.PositionId);

        //        tp.SetTile(t);
        //        t.TablePositionValue = tp;
        //        t.GetComponent<Rigidbody>().isKinematic = true;
        //        t.gameObject.SetActive(true);
        //        t.Released = tileState.Released;
        //        t.transform.rotation=new Quaternion(0,0,0,0);

        //    }

        //    foreach (var tablePosition in Game.Instance.Tplist)
        //    {
        //        if (tablePosition.GameTile != null) tablePosition.GameTile.GetAround();
        //        else
        //        {
        //            Debug.Log(tablePosition.Position);
        //        }
        //    }

        //    foreach (var tile in _tileSet)
        //    {
        //        tile.CheckFreedom();
        //    }

        //    CalculatePairs();

        //    GameTimer=  TimeSpan.FromSeconds(_cfg.State.Seconds);

        //    _isGame = true;

        //}
    }
}