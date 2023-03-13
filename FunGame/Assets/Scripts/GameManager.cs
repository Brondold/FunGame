using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public void Update()
    {
        ReturnToMenu();
    }
    public void ReturnToMenu()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Escape pressed");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }


}
