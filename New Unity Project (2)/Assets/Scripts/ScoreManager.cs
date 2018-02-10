using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text Score;
    float timescore;


	// Use this for initialization
	void Start ()
    {
       
	}
	
	// Update is called once per frame
	void Update ()
    {
        timescore = Time.time;
        Score.text = "Time :" + Mathf.Round(timescore).ToString();
        
		
	}
}
