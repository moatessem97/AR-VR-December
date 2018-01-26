using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewManager : MonoBehaviour {

    public int[] buttOrder;

    int i = 0;


    public void Verify(int buttNum)
    {
        if (buttNum == buttOrder[i])
        {
            i++;
            GameObject.FindObjectOfType<AIB>().newPos();
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
