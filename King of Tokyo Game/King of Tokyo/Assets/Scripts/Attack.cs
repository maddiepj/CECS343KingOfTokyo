using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void attack(GameObject otherPlayer, int dmg)
    {
        Health otherHealth = otherPlayer.GetComponent<Health>();
        otherHealth.takeDamage(dmg);
    }

}
