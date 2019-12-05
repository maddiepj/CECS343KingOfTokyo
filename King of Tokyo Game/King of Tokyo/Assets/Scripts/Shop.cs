using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{

    List<PowerCard> deck;
    List<PowerCard> discardDeck;
    List<PowerCard> stock;
    List<PowerCard> playerHand;
    PlayerManager playerMgr;
    GameObject pmObj;
    GameObject player;
    Energy playerPts;

    public GameObject DeathFromAboveCard;
    public GameObject EvacuationOrdersCard;
    public GameObject FlameThrowerCard;
    public GameObject SolarPoweredCard;
    public GameObject EvenBiggerCard;

    // Start is called before the first frame update
    void Start()
    {
        playerMgr = pmObj.GetComponent<PlayerManager>();
        player = playerMgr.getCurrentPlayer();
        playerHand = player.GetComponent<CardHand>().getHand();

        createDeck();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void purchaseCard(PowerCard card)
    {
        Energy e = player.GetComponent<Energy>();
        if (card.getCost() > e.getEnergy())
        {
            Debug.Log("You do not have enough Energy to purchase this card.");
        }
        else
        {
            e.removeEnergy(card.getCost());
            playerHand.Add(card);
            stock.Remove(card);
            if (card.getType().Equals("Discard"))
            {
                card.executeCard();
                playerHand.Remove(card);
            }

            if (deck.Count >= 1)
            {
                stock.Add(deck[0]);
            }
            else
            {
                Debug.Log("The deck is empty!");
            }

        }
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

    public void createDeck()
    {
        GameObject card1 = Instantiate(DeathFromAboveCard);
        deck.Add(card1.GetComponent<PowerCard>());

        GameObject card2 = Instantiate(EvacuationOrdersCard);
        deck.Add(card2.GetComponent<PowerCard>());

        GameObject card3 = Instantiate(FlameThrowerCard);
        deck.Add(card3.GetComponent<PowerCard>());

        GameObject card4 = Instantiate(SolarPoweredCard);
        deck.Add(card4.GetComponent<PowerCard>());

        GameObject card5 = Instantiate(EvenBiggerCard);
        deck.Add(card5.GetComponent<PowerCard>());

    }


}
