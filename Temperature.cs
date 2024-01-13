using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Temperature : MonoBehaviour
{
    public Health health;
    public float temp = 36.6f;
    public float temp_norm = 36.6f;
    public float temp_crit = 34.0f;
    public float freezeSpeed = 0.05f; 
    public int damage = 2;
    public float FreezeDamageTime = 1f;
    public float FreezeDamageDelay = 2f;
    void Update()
    {
        temp -= freezeSpeed * Time.deltaTime;
        if (temp <= temp_crit)
        {
            if (FreezeDamageTime <= 0)
            {
                health.TakeDamage(damage * Time.deltaTime);
                FreezeDamageTime += FreezeDamageDelay;
            }
            else
            {
                FreezeDamageTime -= Time.deltaTime;
            }
        }
    }
}
