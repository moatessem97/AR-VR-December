using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public int buttNum;


    public void OnTriggerEnter(Collider col)
    {
       if (col.tag == ("Hand"))
        {
            GameObject.FindObjectOfType<NewManager>().Verify(buttNum);
        } 
    }

   




}
