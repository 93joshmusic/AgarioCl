using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

    /* josh note
     * 
     * need to think of a way to stop the player moving after he's 
     * been thrown a certain distance and also not move while being thrown.
     * */


    public float speed; //this is speed, duh

    public float magnitudeHuman; //this controls how far the player gets thrown if they are too small

    public float magnitudeCar;
    
    public Vector3 force; //direction the player is thrown


	// Use this for initialization
	void Start () {

        magnitudeHuman = 50f; // change this if you want the player to get hit harder
        magnitudeCar = 100f;
	
	}
	
	// Update is called once per frame
	void Update () {



        print(transform.localScale.magnitude);

        //up down left right
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }


        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }


        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }



        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }





    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Human")
        {
           if(transform.localScale.magnitude > 1)
            {
                transform.localScale += new Vector3(0.5f, 0.5f, 0.5f); //if the player is at least his starting size hitting a human makes him grow
            }
            else
            {
                transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f); //if hes not he gets smaller, change the floats to change how much smaller

                force = transform.position - col.transform.position; //calculates direction of force

                force.Normalize();

                gameObject.GetComponent<Rigidbody2D>().AddForce(force * magnitudeHuman); //applies the force
            }
            
        }

        else if (col.gameObject.tag == "Car")
        {
            if (transform.localScale.magnitude > 5)
            {
                transform.localScale += new Vector3(1f, 1f, 1f); //if the player is at least his starting size hitting a human makes him grow
            }
            else
            {
                transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f); //if hes not he gets smaller, change the floats to change how much smaller

                force = transform.position - col.transform.position; //calculates direction of force

                force.Normalize();

                gameObject.GetComponent<Rigidbody2D>().AddForce(force * magnitudeCar); //applies the force
            }

        }

        else if (col.gameObject.tag == "Enemy")
        {
            if (transform.localScale.magnitude > 7.5)
            {
                transform.localScale += new Vector3(3f, 3f, 3f); //if the player is at least his starting size hitting a human makes him grow
            }
            else
            {
                transform.localScale -= new Vector3(0.3f, 0.3f, 0.3f); //if hes not he gets smaller, change the floats to change how much smaller

            }

        }

    }
}
