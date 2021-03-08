using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGScroll : MonoBehaviour
{
    public float speed;
    Vector3 startPOS;

    void Start()
    {
        startPOS = transform.position;
    }

    void Update()
    {
        transform.Translate((new Vector3(0,-1,0))* speed * Time.deltaTime);
       
    }
    public void ResetBackground()
    {
        transform.position = startPOS;
       
    }
    
}
