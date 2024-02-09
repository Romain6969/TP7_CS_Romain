using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    //Code pour définir Quand il faut trirer les projectiles.

    public Projectiles projectiles;

    public GameObject Projectile;

    void Update()
    {
        float SpeedProjectile = projectiles.ShotsSpeed;
        bool Shoot = Input.GetKeyDown(KeyCode.Mouse0);
        if (Shoot == true)
        {
            Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPosition.z = 0;
            Vector3 ShootDirection = mouseWorldPosition - transform.position;

            GameObject instantieted = Instantiate(Projectile);
            instantieted.transform.position = new Vector2(transform.position.x, transform.position.y);

            MovementShooting bulletBehaviour =  instantieted.GetComponent<MovementShooting>();
            bulletBehaviour.Direction = ShootDirection;
        }
    }
}
