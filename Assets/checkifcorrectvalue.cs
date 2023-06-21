using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkifcorrectvalue : MonoBehaviour


{
    public Slider slidRed, slidBlue, slidYellow, slidGreen, slidPurple, slidBlack, slidGrey, slidWhite, slidOrange;
    public int checkvalue, actualvalue;
    public gamemanager gm;
    public buttrack bt;
    public accessscriptableobject asc;
    public currentplayer cpl;
    
    // Start is called before the first frame update
   
           

    
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
            
            for (int i = 0; i < 50; i++)
            {
                Debug.Log("waiting");
                
            }
            cpl.ChangePhase();





        }
        else
        {
            Debug.Log("incoorect amount selected");
        }
    }

}
