﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvenBigger : PowerCard
{

    MainMenuController menuControl;
    List<GameObject> players;
    GameObject player;
    string playerName;

    // Start is called before the first frame update
    void Start()
    {
        players = menuControl.getPlayerList();
        player = base.getOwnerObj();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override int getCost()
    {
        return 4;
    }

    public override string getName()
    {
        return "Even Bigger";
    }

    public override string getType()
    {
        return "Keep";
    }

    public override void executeCard()
    {
        Health playerHealth = player.GetComponent<Health>();
        playerHealth.setMaxLife(12);
        playerHealth.increaseLifePoints(2);
    }

    public override string description()
    {
        return "+2 Life Points when you buy this card. Your maximum Life is increased to 12 Life Points as long as you own this card.";
    }

}
