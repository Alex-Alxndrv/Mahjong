using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class UiResultWindow : MonoBehaviour
    {
        public Text Header;
        public Text ResultText;
        public AudioClip[] FailJingles;
        public AudioClip[] WinJingles;
        public Button ButtonNewGame;

        public AudioSource As;

        public GameObject Fireworks;

        //////////////////////////
        // public methods
        /////////////////////////

        public void Show(bool win)
        {
            gameObject.SetActive(true);

            System.Random rnd=new System.Random();

            if (win)
            {
                Header.text = "Победа!";
                ResultText.text = string.Format("Ура! Пасьянс успешно разложен за {0} минут {1} секунд", Game.Instance.GameTimer.Minutes, Game.Instance.GameTimer.Seconds);
                As.clip = WinJingles[rnd.Next(WinJingles.Length)];

                Fireworks.SetActive(true);
            }
            else
            {
                Header.text = "Поражение";

                ResultText.text = string.Format("К сожалению, вы проиграли, попробуйте ещё раз");
                As.clip = FailJingles[rnd.Next(FailJingles.Length)];
            }

            As.Play();
        }
        

        //////////////////////////
        // private methods
        /////////////////////////

        void Start ()
        {
            ButtonNewGame.onClick.AddListener((() =>
            {
                gameObject.SetActive(false);
                Game.Instance.Menu.Show(true);
                Fireworks.SetActive(false);
            }));
        }
	
        void Update () {
	
        }
    }
}
