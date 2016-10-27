using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

    public GameObject player;

    public Camera mainCamera;

	public float targetOrtho;

	public float zoomSpeed;

	public float smoothSpeed;

	// Use this for initialization
	void Start () {

		targetOrtho = Camera.main.orthographicSize;

		zoomSpeed = 1;

		smoothSpeed = 2;
        
	
	}
	
	// Update is called once per frame
	void Update () {





        //camera zooms out once the player is a certain size

       if ((player.transform.localScale.magnitude >= 5)&&(player.transform.localScale.magnitude <= 10))
       {
            targetOrtho = 10;
        }
        else if (player.transform.localScale.magnitude >= 10)
        {
			targetOrtho = 20;
        }
        else
        {
			targetOrtho = 5;
        }

		ZoomCamera ();
        
	
	}

	void ZoomCamera()
	{
		Camera.main.orthographicSize = Mathf.MoveTowards (Camera.main.orthographicSize, targetOrtho, smoothSpeed * Time.deltaTime);
	}
}
