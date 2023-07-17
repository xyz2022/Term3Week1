using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private float rotateSpeed = 9;
    private float moveSpeed = 15;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { 
        

        if (transform.position.z > -70)
            transform.Translate(Vector3.forward * -1 * moveSpeed * Time.deltaTime, Space.World);

        if (transform.rotation.x > -0.3f)
            transform.Rotate(Vector3.right * -1 * rotateSpeed * Time.deltaTime, Space.World);

    }


}
