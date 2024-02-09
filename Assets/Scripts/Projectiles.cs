using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Shots", menuName = "Shots/projectiles", order = 1)]
public class Projectiles : ScriptableObject
{
    [SerializeField]
    public GameObject Projectile;
    public float ShotsSpeed = 5;
    public int ShotsDamage = 2;

    public GameObject FastProjectile;
    public float FastShotsSpeed = 7.5f;
    public int WeakShotsDamage = 1;

    public GameObject SlowProjectile;
    public float SlowShotsSpeed = 2.5f;
    public int StrongShotsDamage = 3;
}
