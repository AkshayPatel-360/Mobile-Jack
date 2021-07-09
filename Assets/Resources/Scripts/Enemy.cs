using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update

    public float moveSpeed;
     public float Helth = 100;
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {

       // EnemyManager.Instance.Follow(this.gameObject);

        Die();
        Follow();


    }

    public void Die()
    {
        if (Helth<= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Follow()
    {
        if (PlayerManager.Instance.Player != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, PlayerManager.Instance.Player.transform.position, moveSpeed * Time.deltaTime);
        }
    }



}
