using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementShooting : MonoBehaviour
{
    //Code pour définir la direction du projectile selon la position de la souris (ça ne marche pas et je ne sais pas pourquoi).
    public Projectiles projectiles;

    private Rigidbody2D Rb2D;

    public Vector2 Direction { get; set; }

    private void Awake()
    {
        Rb2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        transform.rotation = Quaternion.LookRotation(Vector3.forward, Direction);
    }
    void FixedUpdate()
    {
        Rb2D.velocity = Direction * projectiles.ShotsSpeed;
    }
}
