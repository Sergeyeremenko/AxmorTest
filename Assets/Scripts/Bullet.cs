using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float lifetime;
    public int damage;
    public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.right * speed;
        Invoke("DestroyBullet", lifetime);
    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
        Bullet_Enemy enemy = hitInfo.GetComponent<Bullet_Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
    }
    void FixedUpdate()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
    public void DestroyBullet()
    {
        Destroy(gameObject);
        Debug.Log("Kill Bullet");
    }
}