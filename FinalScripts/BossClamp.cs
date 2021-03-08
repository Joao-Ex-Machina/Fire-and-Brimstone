using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossClamp : MonoBehaviour
{
   // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -1.481f, 1.479f),
    Mathf.Clamp(transform.position.y, 100f, -9.12f), transform.position.z);
    }
}
