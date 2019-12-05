using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathFromAbove : PowerCard
{

    //protected MainMenuController menuControl;
    //protected List<GameObject> players;
    //protected GameObject player;
    //protected string playerName;

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
        return 5;
    }

    public override string getName()
    {
        return "Death From Above";
    }

    public override string getType()
    {
        return "Discard";
    }

    public override void executeCard()
    {
        VictoryPoints vp = base.player.GetComponent<VictoryPoints>();
        TokyoCheck tokyoCheck = base.player.GetComponent<TokyoCheck>();
        vp.addVP(2);

        if (!tokyoCheck.inTokyo())
        {
            foreach (GameObject player2 in base.players)
            {
         
                TokyoCheck check = player2.GetComponent<TokyoCheck>();
                if (check.inTokyo() && (player2 != base.player))
                {
                    check.leaveTokyo();
                }
            }

            tokyoCheck.enterTokyo();
        }
    }

    public override string description()
    {
        return "+2 Victory Points and take control of Tokyo if you don't already control it.";
    }




}
