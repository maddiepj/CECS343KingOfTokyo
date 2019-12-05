using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    TokyoCheck tokyo;
    List<GameObject> players;
    public MainMenuController mControl;
    MainMenuController mm;

    // Start is called before the first frame update
    void Start()
    {
        tokyo = this.GetComponent<TokyoCheck>();
        mm = mControl.GetComponent<MainMenuController>();
        players = mm.getPlayerList();
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
