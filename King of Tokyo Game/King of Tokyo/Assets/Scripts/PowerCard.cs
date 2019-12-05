using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerCard : MonoBehaviour
{
    MainMenuController menuControl;
    List<GameObject> players;
    public string owner;
    public int cost;
    public string name;
    public string type;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        players = menuControl.playerList;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual int getCost()
    {
        return cost;
    }

    public virtual string getName()
    {
        return name;
    }

    public virtual string getType()
    {
        return type;
    }

    public virtual void executeCard()
    {

    }

    public virtual string description()
    {
        return "";
    }


    public void setOwner(string playerOwner)
    {
        owner = playerOwner;

        foreach (GameObject p in players)
        {
            if (p.GetComponent<PlayerDesc>().getName().Equals(owner))
            {
                player = p;
            }
        }
    }

    public string getOwner()
    {
        return name;
    }

    public GameObject getOwnerObj()
    {
        return player;
    }

 

}
