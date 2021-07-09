using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    [SerializeField] private float spawnTime = 2;
    [SerializeField] public float spawnDelay;       // The amount of time before spawning starts.
    [SerializeField] private Transform spawnPosition;

    private Enemy enemy1;      


    public GameObject enemy;

    public int maxDistance;
    public Transform target;
    public Transform myTransform;


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

        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }
    public void FixedUpdate()
    {
        PlayerManager.Instance.FixedRefresh();
        EnemyManager.Instance.FixedRefresh();
    }
    void Spawn()
    {

    }
    /*void Spawn()
    {
        spawnPosition = PlayerManager.Instance.Player.transform.position; // getting the player pos
        spawnPosition.x = Random.Range(-17, 17);
        spawnPosition.y = Random.Range(-17, 17);
        spawnPosition.z = PlayerManager.Instance.Player.transform.position.z;
        GameObject.Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);
        

    }




















    public float spawnTime;        // The amount of time between each spawn.
    public float spawnDelay;       // The amount of time before spawning starts.
    public GameObject enemy;

    public int maxDistance;
    public Transform target;
    public Transform myTransform;

    void Awake()
    {
        myTransform = transform;

    }

    void Start()
    {
        GameObject stop = GameObject.FindGameObjectWithTag("Player");

        target = stop.transform;

        maxDistance = 5;

        StartCoroutine(SpawnTimeDelay());
    }

    IEnumerator SpawnTimeDelay()
    {
        while (true)
        {
            if (Vector3.Distance(target.position, myTransform.position) < maxDistance)
            {
                Instantiate(enemy, transform.position, Quaternion.identity);
                yield return new WaitForSeconds(spawnTime);
            }

            if (Vector3.Distance(target.position, myTransform.position) > maxDistance)
            {
                yield return null;
            }
        }
    }

*/







}
    

