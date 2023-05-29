using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CombatTrigger : MonoBehaviour
{
    // Update is called once per frame
    void Trigger(Collision2D Collider)
    {
        if (Collider.gameObject.name == "Player")
        {
            SceneManager.LoadScene("BattleScene");
        }
    }
}
