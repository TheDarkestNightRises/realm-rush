using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] bool isPlaceable;
    public bool IsPlaceable { get { return isPlaceable; } }
    [SerializeField] Tower towerPrefab;



    private void OnMouseDown()
    {
        if (isPlaceable)
        {
            Debug.Log(transform.name);
            towerPrefab.CreateTower(towerPrefab, transform.position);
            isPlaceable = false;
        }
    }
}
