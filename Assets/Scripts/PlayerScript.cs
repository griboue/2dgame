using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{


    
    public float speed = 10f;

    private float newPos;
    private float screenCenterX;
    private float screenCenterY;
    public GameObject bombPrefab;


    // Use this for initialization
    void Start()
    {
        screenCenterX = Screen.width * 0.5f;
        screenCenterY = Screen.height * 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        checkMove();
    }


    private void checkMove()
    {

        // if there are any touches currently
        if (Input.touchCount > 0)
        {
            Debug.Log("normal");
            // get the first one

            Vector3 screenPos = Camera.main.WorldToScreenPoint(this.transform.position);

            foreach (Touch touch in Input.touches)
            {
                if (touch.position.y < screenCenterY)
                {
                    if (touch.phase == TouchPhase.Began)
                    {
                        Instantiate(bombPrefab);
                    }
                }
                else if (touch.position.x > screenCenterX && !(screenPos.x > Screen.width))
                {
                    Debug.Log("right touch");
                    newPos = Time.deltaTime * speed;
                    transform.position = transform.position + Vector3.right * newPos;
                }
                else if (touch.position.x < screenCenterX && !(screenPos.x < 0))
                {
                    Debug.Log("left touch");
                    newPos = Time.deltaTime * -speed;
                    transform.position = transform.position + Vector3.right * newPos;
                }
            }

            

        }
    }
}
