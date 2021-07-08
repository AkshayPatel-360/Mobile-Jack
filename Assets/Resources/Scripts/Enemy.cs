using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]private GameObject player;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float helth;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (player != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, moveSpeed * Time.deltaTime);
        }

        
    }



}
