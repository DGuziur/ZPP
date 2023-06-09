using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWin : MonoBehaviour
{
    [SerializeReference] GameObject Enemy1;
    [SerializeReference] GameObject WinScreen;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Enemy1 == null)
        {
            WinScreen.SetActive(true);
        }
    }
}
