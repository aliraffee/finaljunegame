using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkifcorrectvalue : MonoBehaviour


{
    public Slider slidRed, slidBlue, slidYellow, slidGreen, slidPurple, slidBlack, slidGrey, slidWhite, slidOrange;
    public int checkvalue, actualvalue;
    public gamemanager gm;
    int red = 0, blue = 0, green = 0, white = 0, black = 0, yellow = 0, grey = 0, orange = 0, purple = 0;
    public buttrack bt;
    public accessscriptableobject asc;
    public currentplayer cpl;
    public GameObject pnl;

    
    
    // Start is called before the first frame update
   
    public void minusamonu()
    {
        red = 0;
        blue = 0;
        green = 0;
        white = 0;
        black = 0;
        yellow = 0;
        grey = 0;
        orange = 0;
        purple = 0;
        if (slidRed.IsActive())
        {
            red += (int)slidRed.value;
        }

        if (slidBlue.IsActive())
        {
            blue += (int)slidBlue.value;
        }

        if (slidYellow.IsActive())
        {
            yellow += (int)slidYellow.value;
        }

        if (slidGreen.IsActive())
        {
            green += (int)slidGreen.value;
        }

        if (slidPurple.IsActive())
        {
            purple += (int)slidPurple.value;
        }

        if (slidOrange.IsActive())
        {
            orange += (int)slidOrange.value;
        }

        if (slidWhite.IsActive())
        {
            white += (int)slidWhite.value;
        }

        if (slidBlack.IsActive())
        {
            black += (int)slidBlack.value;
        }

        if (slidGrey.IsActive())
        {
            grey += (int)slidGrey.value;
        }
          if (cpl.currentPhase == PlayerPhase.PlayerOne)
        {

            gm.redNumber -= red;
            gm.blueNumber -= blue;
            gm.greenNumber -= green;
            gm.whiteNumber -= white;
            gm.blackNumber -= black;
            gm.yellowNumber -= yellow;
            gm.rainbowNumber -= grey;
            gm.orangeNumber -= orange;
            gm.purpleNumber -= purple;


        }
        else
        {
            gm.redNumber2 -= red;
            gm.blueNumber2 -= blue;
            gm.greenNumber2 -= green;
            gm.whiteNumber2 -= white;
            gm.blackNumber2 -= black;
            gm.yellowNumber2 -= yellow;
            gm.rainbowNumber2 -= grey;
            gm.orangeNumber2 -= orange;
            gm.purpleNumber2 -= purple;

        }
        gm.UpdateCountTexts();
    }

    
    public void checkifenough()
    {
        checkvalue = 0;
        if (slidRed.IsActive())
        {
            checkvalue += ((int)slidRed.value);


        }
        if (slidBlue.IsActive())
        {
            checkvalue += (int)slidBlue.value;
        }

        if (slidYellow.IsActive())
        {
            checkvalue += (int)slidYellow.value;
        }

        if (slidGreen.IsActive())
        {
            checkvalue += (int)slidGreen.value;
        }

        if (slidPurple.IsActive())
        {
            checkvalue += (int)slidPurple.value;
        }
        if (slidOrange.IsActive())
        {
            checkvalue += (int)slidOrange.value;
        }
        if (slidWhite.IsActive())
        {
            checkvalue += (int)slidWhite.value;
        }

        if (slidBlack.IsActive())
        {
            checkvalue += (int)slidBlack.value;
        }

        if (slidGrey.IsActive())
        {
            checkvalue += (int)slidGrey.value;
        }
        if (checkvalue==actualvalue)
        {
            Debug.Log("coorect amount selected");
            
            gm.iscorercyvelue = true;
            gm.playerpoint(actualvalue);
            gm.changeclr();
            pnl.SetActive(false);
            minusamonu();




            cpl.ChangePhase();





        }
        else
        {
            Debug.Log("incoorect amount selected");
        }
    }

}
