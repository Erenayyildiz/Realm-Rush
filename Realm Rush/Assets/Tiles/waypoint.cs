using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class waypoint : MonoBehaviour
{
    [SerializeField] Tower TowerPrefab;

    [SerializeField] bool isPlaceable;
    public bool IsPlaceable { get { return isPlaceable; } }

    void OnMouseDown()
    {
        if (isPlaceable)
        {
            bool isPlaced = TowerPrefab.CreateTower(TowerPrefab, transform.position);
            isPlaceable = !isPlaced;
        }
    }
}
