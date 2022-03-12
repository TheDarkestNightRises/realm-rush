using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] bool isPlaceable;
    public bool IsPlaceable { get { return isPlaceable; } }
    [SerializeField] GameObject towerPrefab;



    private void OnMouseDown()
    {
        if (isPlaceable)
        {
            Debug.Log(transform.name);
            Instantiate(towerPrefab,transform.position,Quaternion.identity);
            isPlaceable = false;
        }
    }

  
}
