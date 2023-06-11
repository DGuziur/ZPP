using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WishPanelExitBttn : MonoBehaviour
{
    [SerializeReference] GameObject WishPanel;

    private void OnMouseDown()
    {
        WishPanel.SetActive(false);
    }
}
