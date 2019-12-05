using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameThrower : PowerCard
{

    public MainMenuController menuControl;
    public List<GameObject> players;
    public GameObject player;
    public string playerName;

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
        return 3;
    }

    public override string getName()
    {
        return "Flame Thrower";
    }

    public override string getType()
    {
        return "Discard";
    }

    public override void executeCard()
    {
        foreach (GameObject player2 in players)
        {
            if (player2 != player)
            {
                Health pHealth = player2.GetComponent<Health>();
                pHealth.takeDamage(2);
            }   
        }
    }

    public override string description()
    {
        return "All other Monsters lose 2 Life Points.";
    }

}
