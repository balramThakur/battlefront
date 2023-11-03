using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInLobby : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _Players;
    public Transform spwanPosition;

    // Start is called before the first frame update
    void Start()
    {
        int index = PlayerPrefs.GetInt("i");
        Debug.Log(index);
        GameObject prefeb = _Players[index];
        GameObject clone = Instantiate(prefeb, spwanPosition.position, Quaternion.identity);
        clone.name = "Player Variant(Clone)";
        clone.SetActive(true);
        clone.transform.parent = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
