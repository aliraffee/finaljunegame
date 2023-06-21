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
    public currentplayer cpl;

    private void Start()
    {
        if (this.gameObject.tag == "btn")
        {
            starting4cards();
        }

    }
    

    public void starting4cards()
    {
        if (this.gameObject.tag == "btn")
        {

            for (int p = 0; p < 4; p++)
            {
                {
                    randomcard = gm.deck[Random.Range(0, gm.deck.Count)];
                    gm.deck.Remove(randomcard);
                    string tag = randomcard.gameObject.tag;
                    gm.annnumber(tag, 1);
                    buttonClickTime = Time.time;
                    waiting = true;


                }
            }
        }
    }

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
                cpl.cardpickedup++;
                gm.annnumber(tag, 1);
                gm.Draw();
              
                return;

            }
        }
    }
        public void drawfromdeck()
        {
   
        if (this.gameObject.tag == "btn")
        {
         
            for (j = 0; j < 2; j++)
            {


               
                if (playerhand.poneavailableslot[j] == true)
                {
                    cpl.cardpickedup++;
                   
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
