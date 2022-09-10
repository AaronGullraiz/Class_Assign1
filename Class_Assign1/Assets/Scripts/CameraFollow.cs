using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform obj;

    void Update()
    {
        var pos = transform.position;
        pos.y = obj.position.y + 2;
        pos.z = obj.position.z + 1;
        transform.position = pos;
    }
}