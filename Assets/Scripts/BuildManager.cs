using System.Collections;
using System.Collections.Generic;
using System.Threading;
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

    public GameObject standartTurretPrefab;
    public GameObject MissileLauncherTurretPrefab;
    /*public GameObject LaserBeamerTurretPrefab;*/

    TurretBlueprint turretToBuild;

    public GameObject buildEffect;

    public bool CanBuild { get { return turretToBuild != null; } }
    public bool HasMoney { get { return PlayerStats.Money >= turretToBuild.cost; } }
    
    public void BuildTurretOn(Node node)
    {
        if (PlayerStats.Money < turretToBuild.cost)
        {
            Debug.Log("not enough money");
            return;
        }

        PlayerStats.Money -= turretToBuild.cost;

        if (turretToBuild.prefab.name == "MissileLauncher")
        {
            node.offset = new Vector3(0, 0, 0);
        }
        else
        {
            node.offset = new Vector3(0, 0, 3f);
        }
        node.turret = (GameObject) Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        GameObject effect = Instantiate(buildEffect, node.GetBuildPosition() - node.offset, Quaternion.identity);
        Destroy(effect, 5f);
    }

    public void SelectTurretToBuild(TurretBlueprint turret)
    {
        turretToBuild = turret;
    }
}
