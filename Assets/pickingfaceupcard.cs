using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickingfaceupcard : MonoBehaviour
{
    public playerhandscript playerhand;
    public gamemanager gm;

    void checkiffilled()
    {
        for(int m=0;m<=gm.availableslot.Length; m++)
        {
            if (this.transform.position==gm.cardslot[m].transform.position)
            {
                gm.availableslot[m] = true;
            }
        }
    }
    private void DestroyObject()
    {

        // Destroy the game object
        Destroy(gameObject);
    }

    void OnMouseDown()
    {
              
        for (int i = 0; i <= playerhand.playerslot.Length; i++)
        {
            if (playerhand.poneavailableslot[i] == true)
            {
                checkiffilled();
                this.transform.SetParent(playerhand.playerslot[i].transform);
                transform.localPosition = new Vector2(0,0);
                playerhand.poneavailableslot[i] = false;
                
                string tag = gameObject.tag;
                gm.annnumber(tag, 1);
                gm.Draw();
                    Invoke("DestroyObject", 5f); 
                return;
                
            }
        }
        
    }
}
