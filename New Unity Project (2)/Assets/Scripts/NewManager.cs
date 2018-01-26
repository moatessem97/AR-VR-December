using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewManager : MonoBehaviour {

    public int[] buttOrder;

    int i = 0;


    public void Verify(int buttNum)
    {
        GameObject.FindObjectOfType<AIB>().newPos(buttNum);
        if (buttNum == buttOrder[i])
        {
            i++;
           
            if (i == buttOrder.Length)
            {
                Debug.Log("game won");
            } 
        }
        else
        {
            Debug.Log("lost");
        }
    }
	
	
}
