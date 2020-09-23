using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadSaveMenuScript : MonoBehaviour
{
    [SerializeField] Button _backButton;
    [SerializeField] Button _Save1Button;
    void Start()
    {
        _backButton.onClick.AddListener(delegate { BackToMainMenuButtonClick(_backButton); });
        _Save1Button.onClick.AddListener(delegate { Save1ButtonClick(_Save1Button); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackToMainMenuButtonClick(Button button)
    {
         SceneManager.UnloadSceneAsync("SceneLeaderboard");
         SceneManager.LoadScene("SceneMainMenu");
         }
    public void Save1ButtonClick(Button button)
    {
        SceneManager.UnloadSceneAsync("SceneLoadSave");
        SceneManager.LoadScene("SceneGameplay");
    }
}
