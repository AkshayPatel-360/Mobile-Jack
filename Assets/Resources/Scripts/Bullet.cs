using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    [SerializeField] private float bulletSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnEnable()
    {
        Invoke("DisableObj", 2f);
    }


    private void DisableObj()
    {
        gameObject.SetActive(false);

    }
}
