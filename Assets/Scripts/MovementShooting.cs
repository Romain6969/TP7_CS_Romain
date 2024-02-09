using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementShooting : MonoBehaviour
{
    //Code pour définir la direction du projectile selon la position de la souris (ça ne marche pas et je ne sais pas pourquoi).
    void FixedUpdate()
    {
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0;
        Vector3 ShootDirection = mouseWorldPosition - transform.position;

        Shooting bulletBehaviour = gameObject.GetComponent<Shooting>();
        bulletBehaviour.Direction = ShootDirection;
    }
}
