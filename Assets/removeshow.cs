using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeshow : MonoBehaviour
 {
    public  int childCount, increases;
    public int whichpos;
    public pickingfaceupcard pk;
    Transform childtransform;
    private GameObject childObject;
    public Transform canvasTransform;
    private void FixedUpdate()
    {
       if (childCount !=1)
        {
            pk.playerhand.poneavailableslot[whichpos] = true;
        }
        childCount = transform.childCount;

        if (childCount==1)
        {
            increases++;
            if (increases > 50)
            {
                childtransform = transform.GetChild(0);
                childObject = childtransform.gameObject;
                pk.discardedCards.Add(childObject);
                pk.playerhand.poneavailableslot[whichpos] = true;
                childObject.transform.SetParent(null);
                childObject.transform.SetParent(canvasTransform);
                childtransform.transform.localPosition = new Vector2(-1220,-239);

                increases = 0;
            }
        }
    }
}


