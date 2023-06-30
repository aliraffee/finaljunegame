using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gamemanager : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Card> deck = new List<Card>();
    [SerializeField]
    public Transform[] cardslot;
    public currentplayer cpl;
    public SpriteRenderer ima;
    public bool[] availableslot;
    public bool iscorercyvelue=false;
    public TextMeshProUGUI player1text, player2text, playerpointtext, redCountText, blueCountText, yellowCountText, greenCountText, purpleCountText, rainbowCountText, blackCountText, whiteCountText, orangeCountText;
    public int  redNumber, blueNumber, yellowNumber, greenNumber, purpleNumber, rainbowNumber, blackNumber, whiteNumber,orangeNumber, player1point, player2point, playerinc;
    public int redNumber2, blueNumber2, yellowNumber2, greenNumber2, purpleNumber2, rainbowNumber2, blackNumber2, whiteNumber2, orangeNumber2;


    public void playerpoint(int point)
    {
        playerinc = 0;
        switch (point)
        {
            case 1:
                playerinc += 1 ;


                break;

            case 2:
                playerinc += 2;

                break;

            case 3:
                playerinc += 4;

                break;

            case 4:
                playerinc += 7;

                break;

            case 5:
                playerinc += 10;

                break;

            case 6:
                playerinc += 15;

                break;

            default:
                
                Debug.Log("Value is not between 1 and 6");
                break;
        }
        if (cpl.currentPhase == PlayerPhase.PlayerOne)
        {
            player1point += playerinc;
            player1text.text = player1point.ToString();
            cpl.p1trains -= point;
            
            
        }
        else
        {
            player2point += playerinc;
            player2text.text = player2point.ToString();
            cpl.p2trains -= point;

        }
        
    }
    public void changeclr()
    {
        if (cpl.currentPhase == PlayerPhase.PlayerOne)
        {
            player1point += playerinc;
            player1text.text = player1point.ToString();

            ima.color = Color.red;
            iscorercyvelue = false;
            Color newColor = ima.color;
            newColor.a = 0.5f;
            ima.color = newColor;

        }
        else
        {
            player2point += playerinc;
            player2text.text = player2point.ToString();

            ima.color = Color.blue;
            Color newColor = ima.color;
            newColor.a = 0.5f; 
            ima.color = newColor;

        }

       


    }
    public void UpdateCountTexts()

    {
        if (cpl.currentPhase == PlayerPhase.PlayerOne)
        {

            redCountText.text = redNumber.ToString();
            blueCountText.text = blueNumber.ToString();
            yellowCountText.text = yellowNumber.ToString();
            greenCountText.text = greenNumber.ToString();
            purpleCountText.text = purpleNumber.ToString();
            rainbowCountText.text = rainbowNumber.ToString();
            blackCountText.text = blackNumber.ToString();
            whiteCountText.text = whiteNumber.ToString();
            orangeCountText.text = orangeNumber.ToString();

        }
        else
        {

            redCountText.text = redNumber2.ToString();
            blueCountText.text = blueNumber2.ToString();
            yellowCountText.text = yellowNumber2.ToString();
            greenCountText.text = greenNumber2.ToString();
            purpleCountText.text = purpleNumber2.ToString();
            rainbowCountText.text = rainbowNumber2.ToString();
            blackCountText.text = blackNumber2.ToString();
            whiteCountText.text = whiteNumber2.ToString();
            orangeCountText.text = orangeNumber2.ToString();

        }
       



    }
    [SerializeField]
    public void annnumber(string colour,int amount)
    {

        if (cpl.currentPhase == PlayerPhase.PlayerTwo)
        {
            switch (colour)
            {
                case "red":

                    redNumber2 += amount;
                    break;
                case "blue":
                    blueNumber2 += amount; ;
                    break;
                case "yellow":
                    yellowNumber2 += amount; ;
                    break;
                case "green":
                    greenNumber2+= +amount; ;
                    break;
                case "purple":
                    purpleNumber2 += +amount; ;
                    break;
                case "rainbow":
                    rainbowNumber2 += +amount;
                    break;
                case "black":
                    blackNumber2 += +amount; ;
                    break;

                case "orange":
                    orangeNumber2 += +amount; ;
                    break;
                case "white":
                    whiteNumber2 += +amount; ;
                    break;
            }


        }
        else
        {
            switch (colour)
            {
                case "red":
                    redNumber += amount;
                    break;

                case "blue":
                    blueNumber += amount;
                    break;

                case "yellow":
                    yellowNumber += amount;
                    break;

                case "green":
                    greenNumber += amount;
                    break;

                case "purple":
                    purpleNumber += amount;
                    break;

                case "rainbow":
                    rainbowNumber += amount;
                    break;

                case "black":
                    blackNumber += amount;
                    break;

                case "orange":
                    orangeNumber += amount;
                    break;

                case "white":
                    whiteNumber += amount;
                    break;
            }

        }
      
        UpdateCountTexts();
    }
    private void Start()
    {
        for(int k = 0; k < 5; k++)
        {
            Draw();
        }
    }
    public void Draw()
    {
        //for later code when we need to track the amount of cards in the deck
        if (deck.Count>=1)
        {
            Card randomcard = deck[Random.Range(0, deck.Count)];
            for (int i = 0; i < availableslot.Length; i++)
            {
                    if (availableslot[i]== true)
                    {
                        randomcard.gameObject.SetActive(true);
                        randomcard.transform.position = cardslot[i].position;
                        availableslot[i] = false;
                    deck.Remove(randomcard);
                        
                        return;
                    }
            }
        }
    }
}
