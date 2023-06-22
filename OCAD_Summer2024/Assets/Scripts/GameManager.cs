using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public static bool IsPaused = false;
    public static bool IsShopping = false;

    public List<City> cities = new List<City>();


    private void Awake()
    {
        Instance = this;
    }

    public bool CheckForCompletion()
    {
        foreach (City c in cities)
        {
            if (c.CityLevel < 5)
            {
                return false;
            }
        }
        
        CompleteGame();
        return true;
    }

    private void Update()
    {
        // Reuse the same code for quit to menu
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CompleteGame();
        }
    }

    private void CompleteGame()
    {
        SceneManager.UnloadSceneAsync(1);
        SceneManager.LoadSceneAsync(0);        
    }


}
