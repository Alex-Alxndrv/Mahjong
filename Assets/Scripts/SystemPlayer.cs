using UnityEngine;

namespace Assets.Scripts
{
    public class SystemPlayer : MonoBehaviour
    {
        public AudioClip[] TrackList;
        public AudioSource As;

        public void Play()
        {
            var rnd=new System.Random();

            As.clip = TrackList[rnd.Next(TrackList.Length)];
            As.Play();
        }

        public void SetMute(bool mute)
        {
            As.mute = mute;
        }

        // Use this for initialization
        void Start () {
	
        }
	
        // Update is called once per frame
        void Update () {
	
        }
    }
}
