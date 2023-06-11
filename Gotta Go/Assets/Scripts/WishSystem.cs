using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WishSystem : MonoBehaviour
{
    [SerializeReference] GameObject Placeholder;
    private Animation anim;

    void Start()
    {
        anim = Placeholder.GetComponent<Animation>();
    }

    public void MakeAWish()
    {
        int r = Random.Range(0, 100);

        if (r <= 2)
        {
            Placeholder.SetActive(true);
            Debug.Log("Gold");
        }
        if (r <= 10 && r > 2)
        {
            Placeholder.SetActive(true);
            Debug.Log("Purple");
        }
        if (r > 10)
        {
            Placeholder.SetActive(true);
            Debug.Log("Blue");
        }
    }
}
