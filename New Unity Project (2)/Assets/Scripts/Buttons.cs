using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public int buttNum;


    public void OnCollisionEnter(Collision col)
    {
       if (col.gameObject.tag == ("Hand"))
        {
            GameObject.FindObjectOfType<NewManager>().Verify(buttNum);
        } 
    }




}
