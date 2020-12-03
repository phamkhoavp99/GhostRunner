using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainmenuController : MonoBehaviour
{
    public void OnPlayButtonClick()
    {
        string currentLevel = PlayerPrefs.GetString("CURRENT_LEVEL", "Game");
        SceneManager.LoadScene(currentLevel);
    }
}
