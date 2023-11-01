using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    [SerializeField]
    private Button _nextPlayer, _prevoiusPlayer,_startGame;
    [SerializeField]
    private GameObject[] _players=new GameObject[2];
    public  GameObject _currentPlayer;
    public int i = 0;
    void Start()
    {
        _currentPlayer = _players[i];

        _nextPlayer.onClick.AddListener(Next);
        _prevoiusPlayer.onClick.AddListener(Previous);
        _startGame.onClick.AddListener(goToLobby);
    }

    
    void Update()
    {
        
    }

    void Next()
    {
        i++;
        if (i<_players.Length)
        {
            _currentPlayer.SetActive(false);
            _currentPlayer = _players[i];
            _currentPlayer.SetActive(true);
        }
        
    }

    void Previous()
    {
        i--;
        if (i>=0)
        {
            _currentPlayer.SetActive(false);
            _currentPlayer = _players[i];
            _currentPlayer.SetActive(true);
        }
        
    }

    void goToLobby()
    {
        PlayerPrefs.SetInt("i", i);
        SceneManager.LoadScene("Lobby");
    }
}
