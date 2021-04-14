using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManagerPlayer : MonoBehaviour
{
    public int score1;
    public int score2;

    public Text scoreDispley;
    public Text bestScoreDisplay;

    private void Awake()
    {
        bestScoreDisplay.text = "BestScore: " + score2.ToString();
        score2 = PlayerPrefs.GetInt("BestScore", score2);
    }

    
    void Update()
    {
        if (score1 > score2)
        {
            PlayerPrefs.SetInt("ScorePlayer", score1);
            PlayerPrefs.Save();
        }

        score2 = PlayerPrefs.GetInt("ScorePlayer", score2);
        scoreDispley.text = "ScorePlayer: " + score1.ToString();
        bestScoreDisplay.text = "BestScore: " + score2.ToString();
        PlayerPrefs.SetInt("ScorePlayer", score1);
        PlayerPrefs.SetInt("BestScore", score2);

        PlayerPrefs.Save();

        bestScoreDisplay.text = "BestScore: " + score2.ToString();

        if (score1 <= score2)
        {
            scoreDispley.text = "ScorePlayer: " + score1.ToString();
            PlayerPrefs.SetInt("ScorePlayer", score1);
        }

        if (score1 >= score2)
        {
            scoreDispley.text = "ScorePlayer: " + score1.ToString();
            bestScoreDisplay.text = "BestScore: " + score2.ToString();
            score2 = PlayerPrefs.GetInt("BestScore", score2);
            PlayerPrefs.SetInt("ScorePlayer", score1);
            PlayerPrefs.SetInt("BestScore", score2);
        }
    }

    public void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //restart
        //PlayerPrefs.DeleteKey("ScorePlayer");
        //PlayerPrefs.DeleteKey("BestScore");
        Debug.Log("Restart Scenes");
    }
    public void Kill()
    {
        score1++; // при попадании - добавляем на 1
        score2++;
    }

}
//    void Update() //TO DO .. не допиплил((
//    {
//        if (score1 > score2)
//        {
//            PlayerPrefs.SetInt("ScorePlayer", score1);
//            PlayerPrefs.Save();
//        }

//        score2 = PlayerPrefs.GetInt("ScorePlayer", score2);
//        scoreDispley.text = "ScorePlayer: " + score1.ToString();
//        bestScoreDisplay.text = "BestScore: " + score2.ToString();
//        PlayerPrefs.SetInt("ScorePlayer", score1);
//        PlayerPrefs.SetInt("BestScore", score2);

//        PlayerPrefs.Save();

//        bestScoreDisplay.text = "BestScore: " + score2.ToString();

//        if (score1 <= score2)
//        {
//            scoreDispley.text = "ScorePlayer: " + score1.ToString();
//            //score2 = PlayerPrefs.GetInt("BestScore", score2);
//            //bestScoreDisplay.text = "BestScore: " + score2.ToString();
//            PlayerPrefs.SetInt("ScorePlayer", score1);
//        }

//        if (score1 >= score2)
//        {
//            scoreDispley.text = "ScorePlayer: " + score1.ToString();
//            bestScoreDisplay.text = "BestScore: " + score2.ToString();
//            score2 = PlayerPrefs.GetInt("BestScore", score2);
//            PlayerPrefs.SetInt("ScorePlayer", score1);
//            PlayerPrefs.SetInt("BestScore", score2);public Text scorePlayer;

//    //if (Input.GetKeyDown(KeyCode.Space))
//    //   {
//    //       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
//       }

//{ }
//    //}   // scorePlayer.text = ("You Score: ") + sm1.score1.ToString();


//    public void Restart()
//    {

//        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // restart
//        //PlayerPrefs.DeleteKey("ScorePlayer");
//        //PlayerPrefs.DeleteKey("BestScore");
//        Debug.Log("Restart Scenes");
//    }
//    public void Kill()
//{
//    score1++; // при попадании - добавляем на 1
//    score2++;


//}
