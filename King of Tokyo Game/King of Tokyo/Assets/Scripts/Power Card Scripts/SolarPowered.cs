using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarPowered : PowerCard
{
    //protected MainMenuController menuControl;
    //protected List<GameObject> players;
    //protected GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //players = menuControl.getPlayerList();
        //player = base.getOwnerObj();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override int getCost()
    {
        return 2;
    }

    public override string getName()
    {
        return "Solar Powered";
    }

    public override string getType()
    {
        return "Keep";
    }

    public override void executeCard()
    {
        Energy playerEnergy = base.player.GetComponent<Energy>();
        if (playerEnergy.getEnergy() == 0)
        {
            playerEnergy.addEnergy(1);
        }
    }

    public override string description()
    {
        return "At the end of your turn, gain 1 Energy if you have no Energy.";
    }

}
