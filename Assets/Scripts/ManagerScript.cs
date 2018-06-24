using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ManagerScript : MonoBehaviour
{
    public GameObject towerPrefab;
    public GameObject carPrefab;
    public float towerSpawnTime = 2f;
    private System.Random rand;

    // Use this for initialization
    void Start()
    {
        this.rand = new System.Random();
        //InvokeRepeating("addEnemy", 0, spawnTime);
    }


    private void Update()
    {
        int isGenerated = rand.Next(0, 300);

        if (isGenerated == 1)
        {
            Instantiate(towerPrefab);
        }

        isGenerated = rand.Next(0, 300);
        if (isGenerated == 1)
        {
            Instantiate(carPrefab);
        }
    }



}

