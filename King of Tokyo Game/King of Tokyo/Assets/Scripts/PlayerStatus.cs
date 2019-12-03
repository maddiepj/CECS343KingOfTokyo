using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{

    public MainMenuController menuControl;
    public List<GameObject> players;

    // Start is called before the first frame update
    void Start()
    {
        players = menuControl.getPlayerList();
    }

    // Update is called once per frame
    void Update()
    {
        checkHealth();
        checkVP();
        lastOneStanding();
    }

    public void checkHealth()
    {
        foreach (GameObject player in players)
        {
            Health pHealth = player.GetComponent<Health>();
            if (pHealth.getLifePoints() <= 0)
            {
                players.Remove(player);
                // load death screen??
            }
        }
    }

    public void checkVP()
    {
        foreach (GameObject player in players)
        {
            VictoryPoints VP = player.GetComponent<VictoryPoints>();
            if (VP.getVP() >= 20)
            {
                //load Victory Screen? 
            }
        }
    }

    public void lastOneStanding()
    {
        if (players.Count == 1)
        {
            // load Victory Screen?
        }
    }

}
