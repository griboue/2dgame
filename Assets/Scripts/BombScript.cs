using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour {

    public int speed = 1;
    public int ttl = 3;

    private float newPos;


    // Use this for initialization
    void Start () {
        transform.position = GameObject.Find("plane").transform.position;
        Destroy(this.gameObject, ttl);
    }
	
	// Update is called once per frame
	void Update () {
        newPos = Time.deltaTime * -speed;
        transform.position = transform.position + Vector3.up * newPos;
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("OnCollisionEnter2D");
        Destroy(this.gameObject);
    }
}
