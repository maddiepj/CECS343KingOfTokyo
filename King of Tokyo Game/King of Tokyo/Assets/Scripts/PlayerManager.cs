using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public MainMenuController menuInstance;
    public GameObject Playernamestring;
    public GameObject PlayerHealthString;
    public GameObject PlayerEnergyString;
    public GameObject PlayerVictoryString;
    List<GameObject> playerList = new List<GameObject>();
    int i = 0;
    string pName;

   // Start is called before the first frame update
    void Start()
    {
        playerList = menuInstance.getPlayerList();
        Debug.Log(playerList.Count);
        //player 1 starts
        playerTurn(playerList[i]);


    }

    // Update is called once per frame
    void Update()
    {
        PlayerHealthString.GetComponent<UnityEngine.UI.Text>().text = this.getCurrentPlayer().GetComponent<Health>().getLifePoints().ToString();
        PlayerEnergyString.GetComponent<UnityEngine.UI.Text>().text = this.getCurrentPlayer().GetComponent<Energy>().getEnergy().ToString();
        PlayerVictoryString.GetComponent<UnityEngine.UI.Text>().text = this.getCurrentPlayer().GetComponent<VictoryPoints>().getVP().ToString();
    }

    public void playerTurn(GameObject player)
    {
        Debug.Log("Here's i: " + i);
        pName = player.GetComponent<PlayerDesc>().getName();
        Debug.Log(pName + "'s Turn");
        Playernamestring.GetComponent<UnityEngine.UI.Text>().text = pName + "'s";

        //foreach (GameObject p in playerList)
        //{
        //    Debug.Log(p.GetComponent<PlayerDesc>().getName());
        //}
    }

    public void endTurn()
    {
        int nextInt = this.nextPlayer();
        Debug.Log("this is nextint" + nextInt);
        playerTurn(playerList[nextInt]);
    }

    public int nextPlayer()
    {
        Debug.Log("This is i when calling next player." + i);
        if((i + 1) == playerList.Count)
        {
            i = 0;
            return i;
        }
        else
        {
            i++;
            return i;
        }
    }

    public GameObject getCurrentPlayer()
    {
        return playerList[i];
    }
}
