using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Code pour faire bouger le joueur.
    public SO_players VitessePersonnage;

    private 
    void FixedUpdate()
    {
        float speed = VitessePersonnage.Speed;
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(x, y);
        transform.Translate(movement * speed *  Time.deltaTime);
    }
}
