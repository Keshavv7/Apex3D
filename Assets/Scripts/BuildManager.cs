using UnityEngine;

public class BuildManager : MonoBehaviour
{

    public static BuildManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("More than one BuildManager in scene!");
        }
        instance = this; 
    }

    public GameObject standardTurretPrefab;
    public GameObject missileLauncherPrefab;

    private GameObject turretToBuild;

    public GameObject GetTurretToBuild()
    {
       return turretToBuild;
    }

    public void SetTurretToBuild(GameObject turretSelected)
    {
        turretToBuild = turretSelected;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
