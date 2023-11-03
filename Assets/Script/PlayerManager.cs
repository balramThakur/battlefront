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

        
    }

    
    void Update()
    {
        
    }

    public void Next()
    {
        if (i < _players.Length-1)
        {
            _currentPlayer.SetActive(false);
            i++;
            _currentPlayer = _players[i];
            _currentPlayer.SetActive(true);

        }
    }

    public void Previous()
    {
        
        if (i>0)
        {  
            _currentPlayer.SetActive(false);
            i--;
            _currentPlayer = _players[i];
            _currentPlayer.SetActive(true);
        }
        
    }

    public void goToLobby()
    {
        PlayerPrefs.SetInt("i", i);
        SceneManager.LoadScene("Lobby");
    }
}
