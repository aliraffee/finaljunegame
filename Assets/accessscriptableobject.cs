using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class accessscriptableobject : MonoBehaviour
{
    public scriptableobjecttrain scrobj;
    public buttrack bt;
    public TextMeshProUGUI score;
    public int playerpoint ;
    
   
   // private Renderer objectRenderer;
    public gamemanager gm;

    // Start is called before the first frame update
    private void OnMouseDown()
    {


        //  Debug.Log("reached here");

        gm.ima = GetComponent<Image>();
        bt.buytrack(scrobj.colour, scrobj.numberoftracks);
        gm.playerpoint(scrobj.numberoftracks);
     

    }

  
   


}
