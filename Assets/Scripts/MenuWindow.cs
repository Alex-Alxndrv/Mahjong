using Assets.Scripts.Maper;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class MenuWindow : MonoBehaviour
    {
        public Text LabelHeader;

        public Button ButtonNewGame;
        public GameObject Sound;
        public Button ButtonResume;

        public Button ButtonNewGameStart;
        public ToggleGroup Complexity;
        public ToggleGroup Map;
        public Button ButtonNewGameBack;

        public Toggle[] ToggleMaps;

        public Toggle ToggleSound;

        public Toggle ToggleHard;
        public bool NewGame;
        public bool IsHard;
        public int MapId;
        
        //////////////////////////
        // public methods
        /////////////////////////

        public void Show(bool newGame)
        {
            if (newGame)
                NewGameMenu();
            else
                MainMenu();

            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }

        public void SetComplexity(bool hard)
        {
            IsHard = hard;
        }

        public void SetMapIndex(int id)
        {
            MapId = id;
        }

        //////////////////////////
        // private methods
        /////////////////////////

        // Use this for initialization
        void Start ()
        {
            ToggleSound.onValueChanged.AddListener(arg0 =>
            {
                Game.Instance.Mute(!arg0);
            });

            ButtonNewGame.onClick.AddListener((() =>
            {
                NewGameMenu();
            }));

            ButtonNewGameStart.onClick.AddListener((() =>
            {
                var mapId = 0;
                foreach (var map in ToggleMaps)
                {
                    if (map.isOn)
                        break;
                    mapId++;
                }

                Game.Instance.NewGame(Maper.Maper.GetMaper(ToggleHard.isOn), TileCollection.Layouts[mapId]);
            }));

            ButtonResume.onClick.AddListener((() =>
            {
                Game.Instance.ResumeGame();
            }));

            ButtonNewGameBack.onClick.AddListener((() =>
            {
                MainMenu();
            }));
        }

        float _returnTimeout = 1000;
        // Update is called once per frame
        void Update () {

            _returnTimeout += Time.deltaTime;
            if (Input.GetKey(KeyCode.Escape) && (_returnTimeout > 0.2f))
            {
                if (NewGame)
                {
                    MainMenu();
                }
                else
                    Game.Instance.ResumeGame();

                _returnTimeout = 0;
            }
        }

        void NewGameMenu()
        {
            LabelHeader.text = "Новая игра";

            ButtonNewGame.gameObject.SetActive(false);
            Sound.gameObject.SetActive(false);
            ButtonResume.gameObject.SetActive(false);

            ButtonNewGameStart.gameObject.SetActive(true);
            ButtonNewGameBack.gameObject.SetActive(true);
            Complexity.gameObject.SetActive(true);
            Map.gameObject.SetActive(true);

            NewGame = true;
        }

        void MainMenu()
        {
            LabelHeader.text = "Меню";

            ButtonNewGame.gameObject.SetActive(true);
            Sound.gameObject.SetActive(true);
            ButtonResume.gameObject.SetActive(true);

            ButtonNewGameStart.gameObject.SetActive(false);
            ButtonNewGameBack.gameObject.SetActive(false);
            Complexity.gameObject.SetActive(false);
            Map.gameObject.SetActive(false);

            NewGame = false;
        }
    }
}