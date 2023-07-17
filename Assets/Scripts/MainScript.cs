using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    public GameObject rocketPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
           


        for(int i = 0;  i < 3; i++)
        {
            Instantiate(rocketPrefab, new Vector3(i, 2, 0), Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
