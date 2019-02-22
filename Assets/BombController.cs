using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour {

    public GameObject bombPrefab;
    private Rigidbody2D myRigidbody2D;
    private float thrust = 50.0f;
    private float deadLine = -10;

    // Use this for initialization
    void Start ()
    {
        this.myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        this.myRigidbody2D.AddForce(this.transform.right * thrust);
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "CubeTag")
        {
            Destroy(gameObject);
        }
    }

}
