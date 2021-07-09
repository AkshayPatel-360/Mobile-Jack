using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float damage;
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Enemy enemy = collision.GetComponent<Enemy>();
            enemy.Helth -= damage;
            gameObject.SetActive(false);

            if (enemy.Helth <= 0)
            {
                enemy.Helth = 0;
                enemy.Die();
            }

            


        }
    }


}
