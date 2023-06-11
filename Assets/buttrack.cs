using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class buttrack : MonoBehaviour
{
    public gamemanager gm;
    public Slider btnRed, btnBlue, btnYellow, btnGreen, btnPurple, btnBlack, btnGrey;
    public Image notEnoughCardsImage;

    public void test()
    {
        buytrack("red",4);
    }

    public void buytrack(string colour, int amount)
    {
        switch (colour)
        {
            case "red":
                if (gm.redNumber + gm.rainbowNumber >= amount)
                {
                    btnRed.gameObject.SetActive(true);
                }
                else
                {
                    notEnoughCardsImage.gameObject.SetActive(true);
                }
                break;

            case "blue":
                if (gm.blueNumber + gm.rainbowNumber >= amount)
                {
                    btnBlue.gameObject.SetActive(true);
                }
                else
                {
                    notEnoughCardsImage.gameObject.SetActive(true);
                }
                break;

            case "yellow":
                if (gm.yellowNumber + gm.rainbowNumber >= amount)
                {
                    btnYellow.gameObject.SetActive(true);
                }
                else
                {
                    notEnoughCardsImage.gameObject.SetActive(true);
                }
                break;

            case "green":
                if (gm.greenNumber + gm.rainbowNumber >= amount)
                {
                    btnGreen.gameObject.SetActive(true);
                }
                else
                {
                    notEnoughCardsImage.gameObject.SetActive(true);
                }
                break;

            case "purple":
                if (gm.purpleNumber + gm.rainbowNumber >= amount)
                {
                    btnPurple.gameObject.SetActive(true);
                }
                else
                {
                    notEnoughCardsImage.gameObject.SetActive(true);
                }
                break;

            case "black":
                if (gm.blackNumber + gm.rainbowNumber >= amount)
                {
                    btnBlack.gameObject.SetActive(true);
                }
                else
                {
                    notEnoughCardsImage.gameObject.SetActive(true);
                }
                break;


            case "grey":
                if (gm.redNumber + gm.rainbowNumber >= amount)
                {
                    btnRed.gameObject.SetActive(true);
                }

                if (gm.blueNumber + gm.rainbowNumber >= amount)
                {
                    btnBlue.gameObject.SetActive(true);
                }

                if (gm.yellowNumber + gm.rainbowNumber >= amount)
                {
                    btnYellow.gameObject.SetActive(true);
                }

                if (gm.greenNumber + gm.rainbowNumber >= amount)
                {
                    btnGreen.gameObject.SetActive(true);
                }

                if (gm.purpleNumber + gm.rainbowNumber >= amount)
                {
                    btnPurple.gameObject.SetActive(true);
                }

                if (gm.blackNumber + gm.rainbowNumber >= amount)
                {
                    btnBlack.gameObject.SetActive(true);
                }
                break;

            default:
                Debug.Log("Unknown colour.");
                break;
        }
        
          
        
    }

    
}
