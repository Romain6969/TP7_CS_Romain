using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemies", menuName = "Enemies/Méchants", order = 1)]
public class Enemies : ScriptableObject
{
    public GameObject Ennemie;

    public int Health = 5;

    public float Speed = 3;
}
