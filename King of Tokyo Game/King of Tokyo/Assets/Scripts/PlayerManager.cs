using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public MainMenuController menuInstance;
    public GameObject Playernamestring;
    List<GameObject> playerList = new List<GameObject>();
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        playerList = menuInstance.getPlayerList();
        //player 1 starts
        playerTurn(playerList[i]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playerTurn(GameObject player)
    {
        string Name = "test"; //player.getName();
        Playernamestring.GetComponent<UnityEngine.UI.Text>().text = Name + "'s";
    }

    public void endTurn()
    {
        playerTurn(playerList[this.nextPlayer()]);
    }

    public int nextPlayer()
    {
        if(i++ == playerList.Count)
        {
            i = 0;
            return i;
        }
        else
        {
            return i++;
        }
    }
}
