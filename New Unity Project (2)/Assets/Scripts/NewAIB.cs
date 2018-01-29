using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NewAIB : MonoBehaviour {

    public Transform [] targets;
    [SerializeField]
    private Transform currtarget;
    NavMeshAgent agent;

	// Use this for initialization
	void Start ()
    {
        agent = GetComponent<NavMeshAgent>();
        currtarget = targets[6];
        agent.SetDestination(currtarget.position); 
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (agent.transform.position != currtarget.position)
        {
            agent.SetDestination(currtarget.position);
        }
       // agent.SetDestination(target.position);
	}

    public void newpos(int nodePos)
    {
        currtarget = targets[nodePos];
    }
}
