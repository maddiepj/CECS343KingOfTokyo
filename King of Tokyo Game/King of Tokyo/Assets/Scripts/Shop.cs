using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{

    List<PowerCard> deck;
    List<PowerCard> discardDeck;
    List<PowerCard> stock;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sweep()
    {
        if (deck.Count != 0)
        {
            foreach (PowerCard card in stock)
            {
                discardDeck.Add(card);
                stock.Remove(card);
            }

            if (deck.Count >= 3)
            {
                stock.Add(deck[0]);
                stock.Add(deck[1]);
                stock.Add(deck[2]);
            }

            else
            {
                int i = 0;

                while (deck[i] != null)
                {
                    stock.Add(deck[i]);
                    i++;
                }
            }

        }

       else
        {
            Debug.Log("The deck is empty, you cannot refresh the shop.");
        }


    }



}
