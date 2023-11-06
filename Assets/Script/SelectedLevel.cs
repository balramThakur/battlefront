using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectedLevel : MonoBehaviour
{
    [SerializeField]
    private int level;

    public void ChangeLevelScreen()
    {
        SceneManager.LoadScene("Level " + level.ToString());
    }
}
