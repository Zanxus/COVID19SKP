using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour, IPlaceable
{
    private Vector3 projectileShootFromPosition;

    private void Awake()
    {
        projectileShootFromPosition = transform.Find("ProjectileShootFromPosition").position;
    }

    public void Place()
    {
        
    }
}
