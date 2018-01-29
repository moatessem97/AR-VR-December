using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIB : MonoBehaviour {

    public Transform[] nodes;
    
    private Transform currNode;
    public float speed;
    private GameObject head;
	// Use this for initialization
	void Start ()
    {
        currNode = nodes[8];
      //  head = transform.GetChild(0).gameObject;
	}

    // Update is called once per frame
    void Update()
    {
        if (transform.position != currNode.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, currNode.position, speed * Time.deltaTime);
        }
        //if (GameObject.FindGameObjectWithTag("Hand"))
        //{
        //    head.transform.LookAt(GameObject.FindGameObjectWithTag("Hand").transform);
        //}
	}

    public void newPos(int nodePos)
    {
        currNode = nodes[nodePos];
    }
    
}
