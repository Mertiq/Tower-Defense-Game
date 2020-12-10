using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    void Awake()
    {
        if(instance != null)
        {
            Debug.Log("more than one buildmanager");
            return;
        }
        instance = this;
    }

    public GameObject standartTurrentPrefab;

    private void Start()
    {
        turrentToBuild = standartTurrentPrefab;
    }

    GameObject turrentToBuild;

    public GameObject GetTurrentToBuild()
    {
        return turrentToBuild;
    }
}
