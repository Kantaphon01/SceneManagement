using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

    

public class MainMenuControlScript : MonoBehaviour
{
    [SerializeField] Button _startButton;
    [SerializeField] Button _loadsaveButton;
    [SerializeField] Button _leaderboardButton;
    [SerializeField] Button _optionsButton;
    [SerializeField] Button _exitButton;

    void Start()
    {
        _startButton.onClick.AddListener (
            delegate{StartButtonClick(_startButton);});
            _optionsButton.onClick.AddListener (
                delegate{OptionsButtonClick(_optionsButton);});
                _exitButton.onClick.AddListener (
            delegate{ExitButtonClick(_exitButton);});
        _leaderboardButton.onClick.AddListener(
            delegate { LeaderboardButtonClick(_leaderboardButton); });
        _loadsaveButton.onClick.AddListener(
            delegate { LoadSaveButtonClick(_loadsaveButton); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartButtonClick(Button button) {
        SceneManager.LoadScene("SceneGameplay");
    }
   public void OptionsButtonClick(Button button) { 
       if(!GameApplicationManager.Instance.IsOptionMenuActive)
       {
           SceneManager.LoadScene("SceneOptions", LoadSceneMode.Additive);
           GameApplicationManager.Instance.IsOptionMenuActive =true;

       }
   }
    public void LeaderboardButtonClick(Button button)
    {
            SceneManager.LoadScene("SceneLeaderboard", LoadSceneMode.Additive);
    }
    public void LoadSaveButtonClick(Button button)
    {
        SceneManager.LoadScene("SceneLoadSave", LoadSceneMode.Additive);
    }

    public void ExitButtonClick(Button button) {
       Application.Quit();
   }
}
