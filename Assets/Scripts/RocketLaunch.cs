using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLaunch : MonoBehaviour
{
    bool startNow = false;
    bool hasExploded = false;
    ExplodeRocket explodeRocket;
    private float rocketSpeed = 15;

    void Start()
    {
        explodeRocket = GetComponent<ExplodeRocket>();
        StartCoroutine(RandomDelayStart());
    }

    // Update is called once per frame
    void Update()
    {
        if (startNow == true)
        {
            if(transform.position.y < 100)
                transform.Translate(Vector3.up * rocketSpeed * Time.deltaTime, Space.World);
            else
            {
                if (!hasExploded)
                {
                    hasExploded = true;
                    explodeRocket.Explode();
                }
            }

        }
    }

    IEnumerator RandomDelayStart()
    {
        yield return new WaitForSeconds(UnityEngine.Random.Range(1.0f, 2.0f));
        startNow = true;
    }
}
