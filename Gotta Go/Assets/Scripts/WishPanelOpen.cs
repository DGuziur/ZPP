using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WishPanelOpen : MonoBehaviour
{
    [SerializeReference] GameObject WishPanel;

    private void OnMouseDown()
    {
        WishPanel.SetActive(true);
    }
}
