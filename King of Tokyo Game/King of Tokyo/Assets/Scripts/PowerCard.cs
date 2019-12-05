using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerCard : MonoBehaviour
{
    public GameObject owner;
    public int cost;
    public string name;
    public string type;

    // Start is called before the first frame update
    void Start()
    {
        
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


    public void setOwner(GameObject player)
    {
        owner = player;
    }

}
