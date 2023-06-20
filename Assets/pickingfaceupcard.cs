using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickingfaceupcard : MonoBehaviour
{
    public playerhandscript playerhand;
    public gamemanager gm;
    public Canvas canvasTransform;
    public List<GameObject> discardedCards = new List<GameObject>();
    public int i,m,j;
    public Button button;
    public float delay = 5f;
    public bool waiting=false;
    private float buttonClickTime = 0f;
    Card randomcard;

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
   

    void OnMouseDown()
    {
        for (i = 0; i <= playerhand.playerslot.Length; i++)
        {
            if (playerhand.poneavailableslot[i] == true)
            {
                checkiffilled();
                this.transform.SetParent(playerhand.playerslot[i].transform);
                transform.localPosition = new Vector2(0, 0);
                playerhand.poneavailableslot[i] = false;

                string tag = gameObject.tag;
                gm.annnumber(tag, 1);
                gm.Draw();
              
                return;

            }
        }
    }
        public void drawfromdeck()
        {
        Debug.Log("1");
        if (this.gameObject.tag == "btn")
        {
            Debug.Log("2");
            for (j = 0; j < 2; j++)
            {


                Debug.Log("4");
                if (playerhand.poneavailableslot[j] == true)
                {
                    Debug.Log("3");
                    checkiffilled();
                    randomcard = gm.deck[Random.Range(0, gm.deck.Count)];
                    randomcard.transform.SetParent(playerhand.playerslot[j].transform);
                    randomcard.transform.localPosition = new Vector2(0, 0);
                    gm.deck.Remove(randomcard);
                    playerhand.poneavailableslot[j] = false;

                    string tag = randomcard.gameObject.tag;
                    gm.annnumber(tag, 1);
                    buttonClickTime = Time.time;
                    waiting = true;
                    return;

                }
            }
        }
        }
   
 

    


   

}
