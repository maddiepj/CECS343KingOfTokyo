using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathFromAbove : PowerCard
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
        VictoryPoints vp = player.GetComponent<VictoryPoints>();
        TokyoCheck tokyoCheck = player.GetComponent<TokyoCheck>();
        vp.addVP(2);

        if (!tokyoCheck.inTokyo())
        {
            foreach (GameObject player2 in players)
            {
         
                TokyoCheck check = player2.GetComponent<TokyoCheck>();
                if (check.inTokyo() && (player2 != player))
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
