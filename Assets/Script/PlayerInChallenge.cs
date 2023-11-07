using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInChallenge : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _players;
    [SerializeField]
    private Transform _spawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        int index = PlayerPrefs.GetInt("i");
        GameObject prefeb = _players[index];
        GameObject clone = Instantiate(prefeb, _spawnPosition.position, Quaternion.identity);
        clone.name = "Player";
        clone.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
