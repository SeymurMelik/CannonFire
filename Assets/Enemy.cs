using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour , IDamagable
{
    int EnemyHealth = 2;
    public GameObject ParticleEffect;

    int shotChance = 3;

    public void TakeDamage()
    {
        EnemyHealth -= 1;
        Instantiate(ParticleEffect,gameObject.transform.position, Quaternion.identity);
        if (EnemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IDamagable Health = collision.GetComponent<IDamagable>();
        if (Health != null)
        {
            Health.TakeDamage();
        }
        if (Health == null)
        {
            shotChance -= 1;
            if (shotChance <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

}
