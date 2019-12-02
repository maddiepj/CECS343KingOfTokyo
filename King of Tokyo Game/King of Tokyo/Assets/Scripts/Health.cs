using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    int lifePoints;

    // Start is called before the first frame update
    void Start()
    {

        lifePoints = 10;

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
        if (lifePoints >= 10)
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
