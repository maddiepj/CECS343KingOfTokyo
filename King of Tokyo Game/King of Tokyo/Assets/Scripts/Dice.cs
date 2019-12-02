using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{

    public string value;
    string[] faces = { "1", "2", "3", "claw", "lightning", "heart" };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setValue(string newVal)
    {
        value = newVal;

    }

}
