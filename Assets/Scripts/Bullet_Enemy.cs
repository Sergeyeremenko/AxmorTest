using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet_Enemy : MonoBehaviour
{
    public float speed; 
    public float lifetime; 
    public int damage_player;
    public float normalSpeed; 
    public int health;
    public float startStopTime; 
    public Player player;  
    public float stopTime; 
    private ScoreManagerPlayer sm;


    private void Start()
    {
        player = FindObjectOfType<Player>();
        Invoke("DestroyBullet", lifetime); 
        sm = FindObjectOfType<ScoreManagerPlayer>();
    }
    private void Update()
    {
        if (stopTime <= 0)
        {
            speed = normalSpeed;
        }
        else
        {
            speed = 0;
            stopTime -= Time.deltaTime;
        }
        if (health <= 0)
        {
            sm.Kill();
            Destroy(gameObject);
        }
        if (player.transform.position.x > transform.position.x) 
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime); // движение врага по карте за игроком
    }
    public void TakeDamage(int damage)
    {
        stopTime = startStopTime;
        health -= damage;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
        Player player = hitInfo.GetComponent<Player>();
        if (player != null)
        {
           player.TakeDamage(damage_player);
        }
    }
    public void DestroyBullet()
    {
        Destroy(gameObject);
    }
}