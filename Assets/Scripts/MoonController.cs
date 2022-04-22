using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonController : MonoBehaviour
{
    [SerializeField] Transform _earth;
    public float speed = 5.0f;

    void Update()
    {
        gameObject.transform.LookAt( _earth );
        gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
