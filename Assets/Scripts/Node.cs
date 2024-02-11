
using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{
    private Color nodeColor;
    private GameObject turretOnTop;
    public Color hoverColor = Color.yellow;
    private Renderer r;
    private bool colored;
    public Vector3 turretOffset;

    BuildManager buildManager;

    private void Start()
    {
        r = GetComponent<Renderer>();
        nodeColor = r.material.color;
        colored = false;

        buildManager = BuildManager.instance;
    }

    void OnMouseDown()
    {

        if (buildManager.GetTurretToBuild() == null)
        {
            return;
        }
        
        if (colored)
        {
            r.material.color = nodeColor;
        }
        colored = !colored;
        if (turretOnTop != null)
        {
            Debug.Log("Turret already there!");
            r.material.color = Color.red;
            return;
        }

        // Build turret
        GameObject turretToBuild = buildManager.GetTurretToBuild();
        turretOnTop = (GameObject)Instantiate(turretToBuild, transform.position + turretOffset, transform.rotation);
        r.material.color = Color.green;
        
    }

    void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
        if (buildManager.GetTurretToBuild() == null)
        {
            return;
        }
        r.material.color = hoverColor;
    }
    void OnMouseExit()
    {
        r.material.color = nodeColor;
    }
}
