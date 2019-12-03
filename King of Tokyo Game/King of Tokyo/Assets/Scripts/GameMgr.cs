using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour
{
    public MainMenuController menuControl;
    public List<GameObject> players;

    // Start is called before the first frame update
    void Start()
    {
        players = menuControl.getPlayerList();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
