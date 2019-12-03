using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject lightning;
    public GameObject claw;
    public GameObject heart;

    public string value;
    string[] faces = { "1", "2", "3", "claw", "lightning", "heart" };

    // Start is called before the first frame update
    void Start()
    {

        if (value.Equals("1"))
        {
            this.GetComponent<SpriteRenderer>().sprite = one.GetComponent<SpriteRenderer>().sprite;
        }

        else if (value.Equals("2"))
        {
            this.GetComponent<SpriteRenderer>().sprite = two.GetComponent<SpriteRenderer>().sprite;
        }

        else if (value.Equals("3"))
        {
            this.GetComponent<SpriteRenderer>().sprite = three.GetComponent<SpriteRenderer>().sprite;
        }

        else if (value.Equals("claw"))
        {
            this.GetComponent<SpriteRenderer>().sprite = claw.GetComponent<SpriteRenderer>().sprite;
        }

        else if (value.Equals("lightning"))
        {
            this.GetComponent<SpriteRenderer>().sprite = lightning.GetComponent<SpriteRenderer>().sprite;
        }

        else if (value.Equals("heart"))
        {
            this.GetComponent<SpriteRenderer>().sprite = heart.GetComponent<SpriteRenderer>().sprite;
        }
        else
        {
            value = null;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setValue(string newVal)
    {
        value = newVal;
        Debug.Log("value of value isssss" + value);

        if (value.Equals("1"))
        {
            this.GetComponent<SpriteRenderer>().sprite = one.GetComponent<SpriteRenderer>().sprite;
        }

        else if (value.Equals("2"))
        {
            this.GetComponent<SpriteRenderer>().sprite = two.GetComponent<SpriteRenderer>().sprite;
        }

        else if (value.Equals("3"))
        {
            this.GetComponent<SpriteRenderer>().sprite = three.GetComponent<SpriteRenderer>().sprite;
        }

        else if (value.Equals("claw"))
        {
            this.GetComponent<SpriteRenderer>().sprite = claw.GetComponent<SpriteRenderer>().sprite;
        }

        else if (value.Equals("lightning"))
        {
            this.GetComponent<SpriteRenderer>().sprite = lightning.GetComponent<SpriteRenderer>().sprite;
        }

        else // value == "heart"
        {
            Debug.Log("THIS EXECUTED!! :(");
            this.GetComponent<SpriteRenderer>().sprite = heart.GetComponent<SpriteRenderer>().sprite;
        }
    }

}
