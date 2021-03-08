using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finalscore : MonoBehaviour
{
Text FinalScoreText;


    // Start is called before the first frame update
    void Start()
    {
        FinalScoreText = GetComponent <Text> ();
        

    }

    // Update is called once per frame
    void Update()
    {
        FinalScoreText.text = " Final Score:" + Score.ScoreTotal;
    }
}
