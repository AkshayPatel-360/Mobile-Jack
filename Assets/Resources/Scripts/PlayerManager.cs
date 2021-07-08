using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager 
{
    #region Singleton
    private PlayerManager() { }
    private static PlayerManager _instance;
    public static PlayerManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new PlayerManager();
            }
            return _instance;
        }
    }
    #endregion

   
    public GameObject Player { get; set; }


    public void Initialize()
    {
       
    }
    public void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");

        Debug.Log("jmcv");

    }



    public void Refresh()
    {

    }

    public void FixedRefresh()
    {

    }
}
