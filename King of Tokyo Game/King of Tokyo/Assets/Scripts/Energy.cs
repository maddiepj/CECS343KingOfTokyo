using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy : MonoBehaviour
{

    int total;

    // Start is called before the first frame update
    void Start()
    {
        total = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void addEnergy(int n)
    {
        total += n;
    }

    public void removeEnergy(int n)
    {
        total -= n;
    }

    public int getEnergy()
    {
        return total;
    }

}
