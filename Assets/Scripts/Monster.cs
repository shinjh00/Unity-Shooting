using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour, IDamagable
{
    [SerializeField] new Rigidbody rigid;
    [SerializeField] int hp;
    [SerializeField] float damageForce;

    public void TakeDamage(int damage)
    {
        hp -= damage;
        rigid.AddForce(Vector3.forward * damageForce, ForceMode.Impulse);
        if (hp <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
