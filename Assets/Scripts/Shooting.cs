using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    //Code pour définir Quand il faut trirer les projectiles.
    public Projectiles projectiles;

    public Rigidbody2D Rb2D;

    public GameObject Projectile;
    public Vector2 Direction { get; set; }

    void Start()
    {
        transform.rotation = Quaternion.LookRotation(Vector3.forward, Direction);
    }
    void Update()
    {
        Rb2D.velocity = Direction * projectiles.ShotsSpeed;
        float SpeedProjectile = projectiles.ShotsSpeed;
        bool Shoot = Input.GetKeyDown(KeyCode.Mouse0);
        if (Shoot == true)
        {
            GameObject instantieted = Instantiate(Projectile);
            instantieted.transform.position = new Vector2(transform.position.x, transform.position.y);
        }
    }
}
