using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int health_player;
    private ScoreManagerPlayer sm1;
    public GameObject player;
    public GameObject enemy;
    public Transform SelfTransform;
    private Vector3 _force;

    private void Start()
    {
        sm1 = FindObjectOfType<ScoreManagerPlayer>();
    }
    void Update()
    {
        SelfTransform.position += _force;

        if (Input.GetKey(KeyCode.W))
        {
            _force += (SelfTransform.up * Time.deltaTime) * 0.04f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            _force += (SelfTransform.up * Time.deltaTime) * -0.01f;
        }
        else
        {
            _force = Vector3.Lerp(_force, Vector3.zero, Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            SelfTransform.Rotate(0, 0, 0.9f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            SelfTransform.Rotate(0, 0, -0.9f);
        }

        if (health_player <= 0)
        {
            sm1.Kill();
            Debug.Log("ah, shit, here we go again");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Debug.Log("Restart Scenes");
        }
    }

    public void TakeDamage(int damage_player)
    {
        health_player -= damage_player;
    }

    public void ChangeHealth(int healthValue)
    {
        health_player += healthValue;
    }
}