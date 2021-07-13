using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DmgTextObjectPuller : MonoBehaviour
{
    public static DmgTextObjectPuller currentDmgTextObjectPuller;
    public GameObject PulledDmgTextObject;

    [SerializeField] private int pullAmount;
    private bool willGrow = true;

    private List<GameObject> pulledDmgTextObjects;

    void Start()
    {
        currentDmgTextObjectPuller = this;
        pulledDmgTextObjects = new List<GameObject>();

        for (int i = 0; i < pullAmount; i++)
        {
            GameObject obj = Instantiate(PulledDmgTextObject);
            obj.SetActive(false);
            pulledDmgTextObjects.Add(obj);
        }
    }

    public GameObject DepullDmgTextObject()
    {
        for (int i = 0; i < pulledDmgTextObjects.Count; i++)
        {
            if (!pulledDmgTextObjects[i].activeInHierarchy)
            {
                pulledDmgTextObjects[i].SetActive(true);
                
                return pulledDmgTextObjects[i];


            }
        }

        if (willGrow)
        {
            GameObject obj = Instantiate(PulledDmgTextObject);
            pulledDmgTextObjects.Add(obj);
            return obj;
        }

        return null;
    }
}
