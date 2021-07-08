using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public void Initialize()
    {
        
        PlayerManager.Instance.Initialize();
        EnemyManager.Instance.Initialize();
        
    }
    public void Start()
    {
        PlayerManager.Instance.Start();
        EnemyManager.Instance.Start();
        
    }
    public void Refresh()
    {
        PlayerManager.Instance.Refresh();
        EnemyManager.Instance.Refresh();
    }
    public void FixedRefresh()
    {
        PlayerManager.Instance.FixedRefresh();
        EnemyManager.Instance.FixedRefresh();
    }
    
}
