using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewManager : MonoBehaviour {

    public int[] buttOrder;
    public GameObject[] buttons;
    int i = 0;
    int p;
    int s = 0;
    private GameObject currBut;
    public Text ButtScore;
    private void Start()
    {
        
        p = buttOrder[i];
        currBut = buttons[p-1];
        currBut.GetComponent<Renderer>().material.color = Color.blue;
        ButtScore.text = "Buttons Pushed:" + s.ToString();
    }
   
    public void Verify(int buttNum)
    {

        
        if (buttNum == buttOrder[i])
        {
            GameObject.FindObjectOfType<NewAIB>().newpos(buttNum);
            i++; s++;
            ButtScore.text = "Buttons Pushed:" + s.ToString();
            if (i == buttOrder.Length)
            {
                Debug.Log("game won");
                return;
            }
            
            ColorChange();
        }
        else
        {
            Debug.Log("lost");
        }
    }

    private void ColorChange()
    {
        p = buttOrder[i];
        currBut.GetComponent<Renderer>().material.color = Color.white;
        currBut = buttons[p - 1];
        currBut.GetComponent<Renderer>().material.color = Color.blue;
    }


}
