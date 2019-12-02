using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class DiceManager : MonoBehaviour
{
    // Start is called before the first frame update

    public Dice dice;
    ArrayList savedDice = new ArrayList();
    ArrayList diceToRoll = new ArrayList();
    string[] faces = { "1", "2", "3", "claw", "lightning", "heart" };

    int randomIndex;
    int moneyCount;
    int attackCount;
    int healthCount;

    void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            Instantiate(dice);
            diceToRoll.Add(dice);
            Debug.Log("die " + i + " value: " + dice.value);
        }

        roll();


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
            Debug.Log("randomIndex: " + randomIndex);
            die.setValue(faces[randomIndex]);
        }

        for (int i = 0; i < diceToRoll.Count; i++)
        {

            Debug.Log("die " + i + " value: " + dice.value);

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
