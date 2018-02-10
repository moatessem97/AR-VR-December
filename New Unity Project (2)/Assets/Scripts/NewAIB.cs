using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NewAIB : MonoBehaviour {

    public Transform[] targets;
    [SerializeField]
    private Transform currtarget;
    NavMeshAgent agent;
    GameObject cube;
    private Animator anim;
    // Use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        currtarget = targets[6];
        agent.SetDestination(currtarget.position);
        cube = GameObject.Find("MyCube");
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //AgentMoveToNode();
        agent.SetDestination(cube.transform.position);
        AnimUpdate();
    }

    private void AgentMoveToNode()
        {
            if (agent.transform.position != currtarget.position)
            {
                agent.SetDestination(currtarget.position);
            }
        }

    public void newpos(int nodePos)
        {
            currtarget = targets[nodePos];
        }

    private void AnimUpdate()
    {

        Vector3 currVel = agent.desiredVelocity;
        if (currVel.magnitude > 1)
        {
            currVel.Normalize();
        }
        currVel = transform.InverseTransformDirection(currVel);
        anim.SetFloat("BlendY", currVel.magnitude, 0.1f, Time.deltaTime);

    }

    

    }

