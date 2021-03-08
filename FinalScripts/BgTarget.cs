using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgTarget : MonoBehaviour
{
      public BGScroll back;

     void OnBecameVisible()
     {
         print("VISIBLE");
        back.ResetBackground();
     }
        
  
}
