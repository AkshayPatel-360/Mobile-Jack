using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageText : MonoBehaviour
{

    private void OnEnable()
    {
        
    }
    private void Start()
    {
        Invoke("DisableObj", 1f);
    }

    private void Update()
    {
        
    }

    

    private void DisableObj()
    {
        this.gameObject.SetActive(false);


    }

}
