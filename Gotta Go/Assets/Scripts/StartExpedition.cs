using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartExpedition : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene(1);
    }
}
