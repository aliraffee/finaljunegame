using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class buttrack : MonoBehaviour
{
    public gamemanager gm;
    public Slider btnRed, btnBlue, btnYellow, btnGreen, btnPurple, btnBlack, btnGrey,btnOrange,btnWhite;
    public Image notEnoughCardsImage;
    public checkifcorrectvalue cf;
    private Image image;
    public GameObject pnl;
    public bool isgrey = false;

    public Slider[] sliders;
    //blue,yellow,green,purple,black,grey,orange,white
    private void Start()
    {
        // Attach the OnValueChanged method to the onValueChanged event of all sliders
        foreach (Slider slider in sliders)
        {
            slider.onValueChanged.AddListener((float value) => OnSliderValueChanged(value));
        }
    }

    private void OnSliderValueChanged(float value)
    {
        if (!isgrey)
            return;

        Slider changedSlider = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.GetComponent<Slider>();

    
        foreach (Slider slider in sliders)
        {
            if (slider != changedSlider)
            {
                slider.value = 0f;
            }
        }
    }

    public void buytrack(string colour, int amount)
    {
        cf.actualvalue = amount;
        btnRed.gameObject.SetActive(false);
        btnOrange.gameObject.SetActive(false);
        btnWhite.gameObject.SetActive(false);
        btnBlue.gameObject.SetActive(false);
        btnYellow.gameObject.SetActive(false);
        btnGreen.gameObject.SetActive(false);
        btnPurple.gameObject.SetActive(false);
        btnBlack.gameObject.SetActive(false);
        isgrey = false;
        btnGrey.maxValue = gm.rainbowNumber;
        switch (colour)
        {
            case "red":
                if (gm.redNumber + gm.rainbowNumber >= amount)
                {
                    btnRed.gameObject.SetActive(true);
                    btnRed.maxValue = gm.redNumber;
 
                }
                else
                {
                    notEnoughCardsImage.gameObject.SetActive(true);
                }
                break;

            case "orange":
                if (gm.orangeNumber + gm.rainbowNumber >= amount)
                {
                    btnOrange.gameObject.SetActive(true);
                    btnOrange.maxValue = gm.orangeNumber;
                }
                else
                {
                    notEnoughCardsImage.gameObject.SetActive(true);
                }
                break;

            case "white":
                if (gm.whiteNumber + gm.rainbowNumber >= amount)
                {
                    btnWhite.gameObject.SetActive(true);
                    btnWhite.maxValue = gm.whiteNumber;

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
                    btnBlue.maxValue = gm.blueNumber;
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
                    btnYellow.maxValue = gm.yellowNumber;
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
                    btnGreen.maxValue = gm.greenNumber;
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
                    btnPurple.maxValue = gm.purpleNumber;
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
                    btnBlack.maxValue = gm.blackNumber;
                }
                else
                {
                    notEnoughCardsImage.gameObject.SetActive(true);
                }
                break;

               
            case "grey":

                isgrey = true;
                btnGrey.maxValue = gm.rainbowNumber;
                if (gm.redNumber + gm.rainbowNumber >= amount)
                {
                    btnRed.gameObject.SetActive(true);
   
                }

                if (gm.blueNumber + gm.rainbowNumber >= amount)
                {
                    btnBlue.gameObject.SetActive(true);
                    btnBlue.maxValue = gm.blueNumber;
                }

                if (gm.yellowNumber + gm.rainbowNumber >= amount)
                {
                    btnYellow.gameObject.SetActive(true);
                    btnYellow.maxValue = gm.yellowNumber;
                }

                if (gm.greenNumber + gm.rainbowNumber >= amount)
                {
                    btnGreen.gameObject.SetActive(true);
                    btnGreen.maxValue = gm.greenNumber;
                }

                if (gm.purpleNumber + gm.rainbowNumber >= amount)
                {
                    btnPurple.gameObject.SetActive(true);
                    btnPurple.maxValue = gm.purpleNumber;
                }

                if (gm.blackNumber + gm.rainbowNumber >= amount)
                {
                    btnBlack.gameObject.SetActive(true);
                    btnBlack.maxValue = gm.blackNumber;
                }
                if (gm.orangeNumber + gm.rainbowNumber >= amount)
                {
                    btnOrange.gameObject.SetActive(true);
                    btnOrange.maxValue = gm.orangeNumber;
                }
                if (gm.whiteNumber + gm.rainbowNumber >= amount)
                {
                    btnWhite.gameObject.SetActive(true);
                    btnWhite.maxValue = gm.whiteNumber;
                }

                break;

            default:
                Debug.Log("Unknown colour.");
                break;
        }


        if (notEnoughCardsImage.gameObject.activeSelf == false)
        {
            pnl.SetActive(true);
        }
    }
     

    
}
