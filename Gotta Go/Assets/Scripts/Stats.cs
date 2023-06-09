using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    [SerializeField] float HP;
    [SerializeField] float ATK;
    [SerializeField] float DEF;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(HP <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
