using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillsAppear : MonoBehaviour
{
    [SerializeReference] GameObject Skills;
    bool lol = false;

    private void OnMouseDown()
    {
        lol = !lol;
        Skills.SetActive(lol);
    }
}
