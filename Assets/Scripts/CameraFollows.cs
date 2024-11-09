using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollows : MonoBehaviour
{
    public float camDelay = 2;
    public Transform target;
    public Vector3 offset = new Vector3(0, 2.5f, -10);

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = target.position + offset;
        transform.position = Vector3.Slerp(transform.position, targetPos, camDelay*Time.deltaTime);
        
    }
}
