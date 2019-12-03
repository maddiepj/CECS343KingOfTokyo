using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class DiceManager : MonoBehaviour
{
    // Start is called before the first frame update

    ArrayList savedDice = new ArrayList();
    ArrayList diceToRoll = new ArrayList();
    public GameObject dice;
    string[] faces = { "1", "2", "3", "claw", "lightning", "heart" };

    int randomIndex;
    int moneyCount;
    int attackCount;
    int healthCount;

    void Start()
    {

        for (int i = 0; i < 6; i++)
        {
            GameObject die = Instantiate(dice);
            Dice d = die.GetComponent<Dice>();
            d.setValue(faces[randomNumber(0,6)]);
            diceToRoll.Add(die);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int randomNumber(int min, int max)
    {
        System.Random random = new System.Random();
        return random.Next(min, max);
    }

    public void roll()
    {

        foreach (Dice die in diceToRoll)
        {

            randomIndex = randomNumber(0,6);
            Debug.Log("face rolled: " + faces[randomIndex]);
            die.setValue(faces[randomIndex]);

        }

    }

    public void resolveDice()
    {

        foreach (Dice die in savedDice)
        {

            if (die.value == "lightning")
            {
                moneyCount++;
            }
            
            else if (die.value == "claw")
            {
                attackCount++;
            }

            else if (die.value == "heart")
            {
                healthCount++;
            }

        }

    }


}
