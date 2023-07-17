using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    bool startNow = false;
    void Start()
    {
        StartCoroutine(RandomDelayStart());
    }

    // Update is called once per frame
    void Update()
    {
        if (startNow == true)
        {
            if (transform.position.y < 80)
                transform.Translate(Vector3.forward * -1 * 5 * Time.deltaTime, Space.World);

            if (transform.rotation.x > -25)
                transform.Rotate(Vector3.right * -1 * 3 * Time.deltaTime, Space.World);
        }
    }

    IEnumerator RandomDelayStart()
    {
        yield return new WaitForSeconds(UnityEngine.Random.Range(1.0f, 2.0f));
        startNow = true;
    }
}
