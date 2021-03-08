using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour{
public static int ScoreValue;
public static int ScoreBoost;
private static int ScoreTotal;
Text ScoreText;


    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GetComponent <Text> ();
        

    }

    // Update is called once per frame
    void Update()
    {
        ScoreTotal = ScoreValue + ScoreBoost;
        ScoreText.text = "Score:" + ScoreTotal;
    }
}
