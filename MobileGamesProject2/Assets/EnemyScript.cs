using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour
{
    public GameObject Player;

    // Use this for initialization

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //var Player = transform;
        var MoveSpeed = 4;
        var MaxDist = 10;
        var MinDist = 5;
        transform.LookAt(Player.transform.position);
        if (Vector3.Distance(transform.position, Player.transform.position) <= MinDist)
        {
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;

            if (Vector3.Distance(transform.position, Player.transform.position) <= MaxDist)
            {
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if ((col.gameObject.tag == "Player") && (col.gameObject.transform.localScale.magnitude > 7.5f))
        {
            Destroy(gameObject);
        }
    }
}