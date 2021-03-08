using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AmmoScore2 : MonoBehaviour
{
    Text AmmoText2;
    // Start is called before the first frame update
    void Start()
    {
         AmmoText2 = GetComponent <Text> ();
    }

    // Update is called once per frame
    void Update()
    {
         AmmoText2.text = "Ammo:" + weapon4.Ammo;
    }
}
