﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDesc : MonoBehaviour
{
    string name = "";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setName(string s)
    {
        name = s;
    }

    public string getName()
    {
        return name;
    }
}
