using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AmmoScore : MonoBehaviour
{
    Text AmmoText;
    // Start is called before the first frame update
    void Start()
    {
         AmmoText = GetComponent <Text> ();
    }

    // Update is called once per frame
    void Update()
    {
         AmmoText.text = "Ammo:" + weapon2.Ammo;
    }
}
