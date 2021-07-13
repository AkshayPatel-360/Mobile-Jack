using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager 
{
    #region Singleton
    private EnemyManager() { }
    private static EnemyManager _instance;
    public static EnemyManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new EnemyManager();
            }
            return _instance;
        }
    }
    #endregion


    private float spawnTime = 4;
    private float timeTillNextSpawn;
    private Vector3 spawnPosition;
    
    private GameObject[] enemies;
    

    public void Initialize()
    {
        
        timeTillNextSpawn = 1;
        enemies = Resources.LoadAll<GameObject>("Prefabs/Enemies");
    }

    public void Start()
    { }
    public void Refresh()
    {

        if ((Time.time > timeTillNextSpawn))
        {
            timeTillNextSpawn = Time.time + spawnTime;
            TimeManager.Instance.AddDelegate(() => Spawn(), 1, 1);
        }

        //  TimeManager.Instance.AddDelegate(() => Spawn(), 1, 1);


    }

    public void FixedRefresh()
    {

    }

    void Spawn()
    {
        spawnPosition = PlayerManager.Instance.Player.transform.position; // getting the player pos
        spawnPosition.x = Random.Range(-17, 17);
        spawnPosition.y = Random.Range(-17, 17);
        spawnPosition.z = PlayerManager.Instance.Player.transform.position.z;
        GameObject.Instantiate(enemies[UnityEngine.Random.Range(0, enemies.Length )], spawnPosition, Quaternion.identity);

    }
}
