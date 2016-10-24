using UnityEngine;
using System.Collections;

public class CarScriptTemp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if ((col.gameObject.tag == "Player") && (col.gameObject.transform.localScale.magnitude > 5))
        {
            Destroy(gameObject);

            print("HEY LISTEN");

        }
    }
}
