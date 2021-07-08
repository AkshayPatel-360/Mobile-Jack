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

    public void Initialize()
    {

    }
    public void Start()
    {

    }

    public void Refresh()
    {

    }

    public void FixedRefresh()
    {

    }
}
