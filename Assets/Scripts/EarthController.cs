using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthController : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Rotate(Vector3.up * 50 * Time.deltaTime, Space.World);
    }
}
