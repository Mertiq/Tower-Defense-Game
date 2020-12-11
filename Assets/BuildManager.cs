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

    public GameObject standartTurretPrefab;/*
    public GameObject MissileLauncherTurretPrefab;
    public GameObject LaserBeamerTurretPrefab;*/

    public GameObject turretToBuild;
    
    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    public void SetTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }
}
