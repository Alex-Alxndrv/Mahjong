using UnityEngine;

namespace Assets.Scripts
{
    public class CubeTouch : MonoBehaviour {

        // Use this for initialization
        void Start () {
	
        }
	
        // Update is called once per frame
        void Update () {
	
        }

        void OnMouseDown()
        {
            var x=Instantiate(this);
            x.transform.position = transform.position;

        }
    }
}
