using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    [SerializeField] TMPro.TextMeshProUGUI _scoreTxt;
    [SerializeField] TMPro.TextMeshProUGUI _gameOverTxt;
    [SerializeField] GameObject _startScreen;
    [SerializeField] GameObject _gameOverScreen;
    [SerializeField] GameObject _scoreScreen;

    [SerializeField] GameObject _playerCenter;
    [SerializeField] GameObject _playerPrefab;
    [SerializeField] GameObject _enemyPrefabs;
    [SerializeField] GameObject _background;
    [SerializeField] GameObject _cheeseCenter;

    void Start()
    {
        _gameOverScreen.SetActive(false);
    }

    public void WriteScore(int score)
    {
        _scoreTxt.text = score.ToString();
    }

    public void GameOver()
    {
        _gameOverScreen.SetActive(true);
        _gameOverTxt.text = "BUSTED";
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
        //Instantiate(_playerPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        //_gameOverScreen.SetActive(false);
    }

    public void StartGame()
    {
        _playerCenter.SetActive(true);
        _enemyPrefabs.SetActive(true);
        _background.SetActive(true);
        _cheeseCenter.SetActive(true);
        _scoreScreen.SetActive(true);
        _startScreen.SetActive(false);
    }
}
