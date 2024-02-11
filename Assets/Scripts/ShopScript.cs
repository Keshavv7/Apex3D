using UnityEngine;

public class ShopScript : MonoBehaviour
{
    BuildManager buildManager;

    public void PurchaseStandardTurret ()
    {
        Debug.Log("Standard Turret Selected!");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
    }

    public void PurchaseMissileLauncher()
    {
        Debug.Log("Missile Launcher Selected!");
        buildManager.SetTurretToBuild(buildManager.missileLauncherPrefab);
    }

    // Start is called before the first frame update
    void Start()
    {
        buildManager = BuildManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
