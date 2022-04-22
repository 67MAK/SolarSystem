using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateController : MonoBehaviour
{
    int x, y, z;
    [SerializeField] bool dondurX, dondurY, dondurZ; 
    void Start()
    {
        
    }

    void Update()
    {
        if (dondurX) x = 1;
        else x = 0;
        if (dondurY) y = 1;
        else y = 0;
        if (dondurZ) z = 1;
        else z = 0;
        gameObject.transform.Rotate(x, y, z);
    }
}
