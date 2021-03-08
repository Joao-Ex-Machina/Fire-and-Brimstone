using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -1.481f, 1.479f),
    Mathf.Clamp(transform.position.y, -9.66f, -8.34f), transform.position.z);
    }
}
