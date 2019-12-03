using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class DiceManager : MonoBehaviour
{
    // Start is called before the first frame update

    ArrayList savedDice = new ArrayList();
    
    public GameObject dicezero;
    public GameObject diceone;
    public GameObject dicetwo;
    public GameObject dicethree;
    public GameObject dicefour;
    public GameObject dicefive;
    public GameObject rollButton;
    public int rollNum = 0;
    GameObject[] diceToRoll = new GameObject[6];
    string[] faces = { "1", "2", "3", "claw", "lightning", "heart" };

    int randomIndex;
    int moneyCount;
    int attackCount;
    int healthCount;

    void Start()
    {
        diceToRoll[0] = dicezero;
        diceToRoll[1] = diceone;
        diceToRoll[2] = dicetwo;
        diceToRoll[3] = dicethree;
        diceToRoll[4] = dicefour;
        diceToRoll[5] = dicefive;
        //for (int i = 0; i < 6; i++)
        //{
        //    GameObject die = Instantiate(dice);
        //    Dice d = die.GetComponent<Dice>();
        //    d.setValue(faces[randomNumber(0,6)]);
        //    diceToRoll.Add(die);

        //}

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int randomNumber(int min, int max)
    {
        System.Random random = new System.Random((int)System.DateTime.Now.Ticks);
        return random.Next(min, max);
    }

    public void roll()
    {

        foreach (GameObject die in diceToRoll)
        {
            if (die.GetComponent<Dice>().saved == false)
            {
                randomIndex = randomNumber(0, 6);
                Debug.Log("face rolled: " + faces[randomIndex]);
                die.GetComponent<Dice>().setValue(faces[randomIndex]);
            }
        }

        rollNum++;

        if(rollNum == 3)
        {
            rollButton.SetActive(false);
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

        rollNum = 0;
        rollButton.SetActive(true);

    }

    public void dicezeroSelected(bool retVal)
    {
        diceToRoll[0].GetComponent<Dice>().saved = retVal;
    }

    public void diceoneSelected(bool retVal)
    {
        diceToRoll[1].GetComponent<Dice>().saved = retVal;
    }

    public void dicetwoSelected(bool retVal)
    {
        diceToRoll[2].GetComponent<Dice>().saved = retVal;
    }

    public void dicethreeSelected(bool retVal)
    {
        diceToRoll[3].GetComponent<Dice>().saved = retVal;
    }

    public void dicefourSelected(bool retVal)
    {
        diceToRoll[4].GetComponent<Dice>().saved = retVal;
    }

    public void dicefiveSelected(bool retVal)
    {
        diceToRoll[5].GetComponent<Dice>().saved = retVal;
    }


}
