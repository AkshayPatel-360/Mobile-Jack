using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


   /* [SerializeField] private float spawnTime = 2;
    [SerializeField] public float spawnDelay;       // The amount of time before spawning starts.
    [SerializeField] private Transform spawnPosition;

    private Enemy enemy1;      


    public GameObject enemy;

    public int maxDistance;
    public Transform target;
    public Transform myTransform;*/


    public void Awake()
    {
        PlayerManager.Instance.Initialize();
        EnemyManager.Instance.Initialize(); 
    }
    public void Start()
    {
        PlayerManager.Instance.Start();
        EnemyManager.Instance.Start();
    }
    public void Update()
    {
        PlayerManager.Instance.Refresh();
        EnemyManager.Instance.Refresh();

        //InvokeRepeating("Spawn", spawnTime, spawnTime);
    }
    public void FixedUpdate()
    {
        PlayerManager.Instance.FixedRefresh();
        EnemyManager.Instance.FixedRefresh();
    }
}
    

