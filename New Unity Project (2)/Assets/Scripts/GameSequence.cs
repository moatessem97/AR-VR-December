using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSequence : MonoBehaviour {

    public GameObject button1, button2, button3, button4, button5, button6, button7;
    public bool butt1actvi, butt2atvi, butt3atvi, butt4atvi, butt5atvi, butt6atvi, butt7atvi;
    public Light lit;
    

	// Use this for initialization
	void Start ()
    {
        lit.color = Color.red; 
        button1 = GameObject.FindGameObjectWithTag("button1");
        button2 = GameObject.FindGameObjectWithTag("button2");
        button3 = GameObject.FindGameObjectWithTag("button3");
        button4 = GameObject.FindGameObjectWithTag("button4");

        /* butt1actvi = false;
         butt2atvi = false;
         butt3atvi = false;
         butt3atvi = false;*/
        scenario1();


    }
	
	// Update is called once per frame
	void Update ()
    {
        if (butt1actvi == true && butt2atvi == true && butt3atvi == true && butt4atvi == true)
        {
            scenario2();
        }
        if (butt1actvi == true && butt2atvi == true && butt3atvi == true && butt4atvi == true && butt5atvi == true && butt6atvi == true && butt7atvi == true)
        {
            scenario3();
        }
		
	}

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == ("button1"))
        {
            butt1actvi = true;
        }
        if (col.gameObject.tag == ("button2"))
        {
            butt2atvi = true;
        }
        if (col.gameObject.tag == ("button3"))
        {
            butt3atvi = true;
        }
        if (col.gameObject.tag == ("button4"))
        {
            butt4atvi = true;
        }
        if (col.gameObject.tag == ("button5"))
        {
            butt5atvi = true;
        }
        if (col.gameObject.tag == ("button6"))
        {
            butt6atvi = true;
        }
        if (col.gameObject.tag == ("button7"))
        {
            butt7atvi = true;
        }
    }

    void scenario1()
    {
        butt1actvi = true;
        butt2atvi = false;
        butt3atvi = false;
        butt4atvi = false;
        butt5atvi = true;
        butt6atvi = true;
        butt7atvi = true;
    }
    void scenario2()
    {
        butt1actvi = false;
        butt2atvi = false;
        butt3atvi = true;
        butt4atvi = false;
        butt5atvi = false;
        butt6atvi = true;
        butt7atvi = true;
    }
    void scenario3()
    {
        butt1actvi = true;
        butt2atvi = true;
        butt3atvi = false;
        butt4atvi = false;
        butt5atvi = false;
        butt6atvi = false;
        butt7atvi = false;
    }


}
