using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemieMouvement : MonoBehaviour
{
    public Enemies Ennemie;
    public SO_players Player;
    public Projectiles Projectile;

    public GameObject Joueur;

    private int ViePlayer;
    private int VieEnnemie;
    private int DegatsProjectile;

    private void Awake()
    {
        ViePlayer = Player.Health;
        VieEnnemie = Ennemie.Health;
        DegatsProjectile = Projectile.ShotsDamage;
    }
    void FixedUpdate()
    {
        Ray2D ray = new Ray2D(transform.position, Joueur.transform.position);
        float Vitesse = Ennemie.Speed;
        transform.position = Vector2.MoveTowards(transform.position, ray.direction, Vitesse * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        ViePlayer--;
        Destroy(gameObject);
        Debug.Log(ViePlayer);
        if (ViePlayer <= 0)
        {
            Destroy(Joueur);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Projectile")
        {
            VieEnnemie = VieEnnemie - DegatsProjectile;
            Debug.Log(VieEnnemie);
            if (VieEnnemie <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
