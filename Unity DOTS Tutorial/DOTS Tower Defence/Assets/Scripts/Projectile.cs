using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField]
    public static Transform pfProjectile;
    private static void Create()
    {
        Instantiate(pfProjectile);
    }
}
