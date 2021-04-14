using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager_Intro : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene("1");
        Debug.Log("Преход в меню");
    }
}
