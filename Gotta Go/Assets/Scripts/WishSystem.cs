using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WishSystem : MonoBehaviour
{
    [SerializeReference] GameObject Placeholder;
    private Animator anim;

    void Start()
    {
        anim = Placeholder.GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        Placeholder.SetActive(false);
    }

    public void MakeAWish()
    {
        int r = Random.Range(0, 100);

        if (r <= 2)
        {
            Placeholder.SetActive(true);
            anim.SetTrigger("Gold");
        }
        if (r <= 10 && r > 2)
        {
            Placeholder.SetActive(true);
            anim.SetTrigger("Purple");
        }
        if (r > 10)
        {
            Placeholder.SetActive(true);
            anim.SetTrigger("Blue");
        }
    }
}
