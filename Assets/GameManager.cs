using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int coinCount;
    public Text textCompenent;

    private void Start()
    {
        Application.targetFrameRate = 60;
        coinCount = 0;
    }
    public void SceneReset()
    {
        Screen.SetResolution(1920, 1080, false);
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
    }
    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }
    public void AddCoinCount()
    {
        coinCount = coinCount + 1;
        Debug.Log("コイン : " + coinCount.ToString());
        textCompenent.text = "コイン : " + coinCount.ToString();
    }
}
