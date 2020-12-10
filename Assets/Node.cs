using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    Color startColor;
    Renderer rend;
    GameObject turret;
    public Vector3 offset;

    private void Awake()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    private void OnMouseDown()
    {
        if(turret != null)
        {
            Debug.Log("Cant build here");
            return;
        }

        GameObject turretToBuild = BuildManager.instance.GetTurrentToBuild();
        turret = Instantiate(turretToBuild, transform.position + offset, transform.rotation);
    }

    private void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
