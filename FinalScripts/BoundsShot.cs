using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsShot : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -1.481f, 1.479f),
    Mathf.Clamp(transform.position.y, -100.66f, -8.34f), transform.position.z);
    }
}
