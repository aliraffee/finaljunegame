using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public enum PlayerPhase
{
    PlayerOne,
    PlayerTwo
}

public class currentplayer : MonoBehaviour
{
    public PlayerPhase currentPhase;
    public GameObject pnlswitch,pnlgameend;
    public TextMeshProUGUI txtplayer;
    public gamemanager gm;
    public int icount,cardpickedup = 0;
    public int p1trains, p2trains;
    bool gameen=false;
    public pickingfaceupcard pk;
    public int round=1;
    public removeshow rmv1,rmv2;
    private void Start()
    {
        p1trains = 45;
        p2trains = 45;
        currentPhase = PlayerPhase.PlayerOne;
    }
    private void FixedUpdate()
    {
        if (cardpickedup>=2)
        {
            ChangePhase();
            cardpickedup = 0;
        }
        if(p1trains<3)
        {
            gameen = true;
        }
        if (p2trains<3)
        {
            gameen = true;
        }
    }
    public void ChangePhase()
    {
        round++;
        rmv2.increases = 1000;
        rmv1.increases = 1000;
        pnlswitch.SetActive(true);
        if (round==2)
        {
            pk.starting4cards();
        }
      
        
        
        if (currentPhase == PlayerPhase.PlayerOne)
        {
            currentPhase = PlayerPhase.PlayerTwo;
            txtplayer.text = "Player 2";


        }
        else
        {
            currentPhase = PlayerPhase.PlayerOne;
            txtplayer.text = "Player 1";

        }
        gm.UpdateCountTexts();
        if (gameen)
        {
            icount++;
            if (icount >= 3)
            {
                pnlgameend.SetActive(true);
            }
        }
    }

}
