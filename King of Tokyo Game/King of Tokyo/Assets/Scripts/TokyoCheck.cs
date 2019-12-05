using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokyoCheck : MonoBehaviour
{

    public bool insideTokyo;

    // Start is called before the first frame update
    void Start()
    {
        insideTokyo = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool inTokyo()
    {
        return insideTokyo;
    }

    public bool enterTokyo()
    {
        insideTokyo = true;
    }

    public bool leaveTokyo()
    {
        insideTokyo = false;
    }

}
