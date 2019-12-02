using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryPoints : MonoBehaviour
{

    int vp;

    // Start is called before the first frame update
    void Start()
    {
        vp = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addVP(int n)
    {
        vp += n;
    }

    public void removeVP(int n)
    {
        vp -= n;
    }

    public int getVP()
    {
        return vp;
    }

}
