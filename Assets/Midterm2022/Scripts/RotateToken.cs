using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToken : MonoBehaviour
{
    public int rotSpeed = 2;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotSpeed, 0, Space.World);
    }
}
