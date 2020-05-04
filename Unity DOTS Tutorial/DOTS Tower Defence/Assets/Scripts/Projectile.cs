using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    
    public static void Create(Vector3 spawnPosition)
    {
        Instantiate(GameAssets.Instance.pfProjectile, spawnPosition ,Quaternion.identity);
    }
}
