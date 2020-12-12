using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchaseStandartTurret()
    {
        buildManager.SetTurretToBuild(buildManager.standartTurretPrefab);
    }/*
    public void PurchaseLaserBeamer()
    {
        buildManager.SetTurretToBuild(buildManager.LaserBeamerTurretPrefab);
    }*/
    public void PurchaseMissileLauncher()
    {
        buildManager.SetTurretToBuild(buildManager.MissileLauncherTurretPrefab);
    }
    
}
