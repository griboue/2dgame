using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyScript : MonoBehaviour
{
    public float ttl = 15;
    public float speed = 3f;

    private float newPos;


    private void Start()
    {
        Destroy(this.gameObject, ttl);
    }

    // Update is called once per frame
    void Update()
    {
        newPos = Time.deltaTime * -speed;
        transform.position = transform.position + Vector3.right * newPos;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(this.gameObject);
    }

}
