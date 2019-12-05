using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvacuationOrders : PowerCard
{

    public MainMenuController menuControl;
    public List<GameObject> players;

    // Start is called before the first frame update
    void Start()
    {
        players = menuControl.playerList;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override int getCost()
    {
        return 7;
    }

    public override string getName()
    {
        return "Evacuation Orders";
    }

    public override string getType()
    {
        return "Discard";
    }

    public override void executeCard()
    {
       foreach (GameObject player in players)
        {
            VictoryPoints vp = player.GetComponent<VictoryPoints>();
            vp.removeVP(5);
        }
    }

    public override string description()
    {
        return "All other Monsters lose 5 Victory Points.";
    }

}
