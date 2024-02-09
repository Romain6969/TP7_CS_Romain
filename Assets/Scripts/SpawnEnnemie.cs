using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnnemie : MonoBehaviour
{
    public GameObject Ennemie;

    private float Timerspawn = 0;
    void Update()
    {
        Timerspawn += 1 * Time.deltaTime;

        if (Timerspawn >= 2)
        {
            GameObject instantier = Instantiate(Ennemie);
            instantier.transform.position = new Vector2(-5,0);
            Timerspawn = 0;
        }
    }
}
