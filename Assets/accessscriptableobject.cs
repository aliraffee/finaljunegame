using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class accessscriptableobject : MonoBehaviour
{
    public scriptableobjecttrain scrobj;
    public buttrack bt;
   
   // private Renderer objectRenderer;
    public gamemanager gm;

    // Start is called before the first frame update
    private void OnMouseDown()
    {


        //  Debug.Log("reached here");

        gm.ima = GetComponent<Image>();
        bt.buytrack(scrobj.colour, scrobj.numberoftracks);
     

    }
   


}
