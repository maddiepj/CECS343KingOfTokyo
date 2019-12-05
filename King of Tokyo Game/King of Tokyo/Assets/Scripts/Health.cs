using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    TokyoCheck tokyoCheck;
    int maxLife;
    int lifePoints;

    // Start is called before the first frame update
    void Start()
    {
        maxLife = 10;
        lifePoints = 10;
        tokyoCheck = this.GetComponent<TokyoCheck>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDamage(int dmg)
    {
        lifePoints -= dmg;
    }

    public int getLifePoints()
    {
        return lifePoints;
    }

    public void increaseLifePoints(int points)
    {

        if (tokyoCheck.insideTokyo)
        {
            Debug.Log("You cannot heal while in Tokyo!");
        }

        else {

            if (lifePoints >= maxLife)
            {
                Debug.Log("Player is at max Life Points");
            }

            else if ((lifePoints + points) >= 10)
            {
                lifePoints = 10;
            }
            else
            {
                lifePoints += points;
            }
        }
    }

    public void setMaxLife(int newMax)
    {
        maxLife = newMax;
    }

}
