using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

    public GameObject player;

    public Camera mainCamera;

	// Use this for initialization
	void Start () {

        
	
	}
	
	// Update is called once per frame
	void Update () {

        //camera zooms out once the player is a certain size

        if ((player.transform.localScale.magnitude >= 5)&&(player.transform.localScale.magnitude <= 10))
        {
            mainCamera.orthographicSize = 10;
        }
        else if (player.transform.localScale.magnitude >= 10)
        {
            mainCamera.orthographicSize = 20;
        }
        else
        {
            mainCamera.orthographicSize = 5;
        }
	
	}
}
