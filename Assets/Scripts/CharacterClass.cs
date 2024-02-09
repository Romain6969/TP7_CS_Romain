using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "Players/joueurs", order = 1)]
public class SO_players : ScriptableObject
{
    [SerializeField]
    public GameObject NormalPlayer;
    public int Health = 5;
    public float Speed = 5;

    [SerializeField]
    public GameObject TankyPlayer;
    public int TankHealth = 10;
    public float TankSpeed = 2.5f;

    [SerializeField]
    public GameObject SpeedyPlayer;
    public int FastHealth = 2;
    public float FastSpeed = 7.5f;

    [SerializeField]
    public ScriptableObject Projectiles;

    
}
