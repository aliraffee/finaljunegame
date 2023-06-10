using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gamemanager : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Card> deck = new List<Card>();
    [SerializeField]
    public Transform[] cardslot;
    public bool[] availableslot;
    public TextMeshProUGUI redCountText, blueCountText, yellowCountText, greenCountText, purpleCountText, rainbowCountText, blackCountText;
    int redNumber, blueNumber, yellowNumber, greenNumber, purpleNumber, rainbowNumber, blackNumber;

    private void UpdateCountTexts()
    {
        redCountText.text = redNumber.ToString();
        blueCountText.text = blueNumber.ToString();
        yellowCountText.text = yellowNumber.ToString();
        greenCountText.text = greenNumber.ToString();
        purpleCountText.text = purpleNumber.ToString();
        rainbowCountText.text = rainbowNumber.ToString();
        blackCountText.text = blackNumber.ToString();
    }
    public void annnumber(string colour,int amount)
    {
        switch (colour)
        {
            case "red":
                redNumber+=amount;
                break;
            case "blue":
                blueNumber += amount; ;
                break;
            case "yellow":
                yellowNumber += amount; ;
                break;
            case "green":
                greenNumber += +amount; ;
                break;
            case "purple":
                purpleNumber += +amount; ;
                break;
            case "rainbow":
                rainbowNumber += +amount;
                break;
            case "black":
                blackNumber += +amount; ;
                break;
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
