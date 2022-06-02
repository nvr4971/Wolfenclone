using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{
    public AudioSource clickSound;
    public GameObject fadeOut;

    private int loadScene;
    private int loadLives;
    private int loadScore;
    private int loadAmmo;

    public void NewGame()
    {
        StartCoroutine(NewGameRoutine());
    }

    IEnumerator NewGameRoutine()
    {
        clickSound.Play();
        fadeOut.SetActive(true);

        GlobalComplete.currentFloor = 3;

        yield return new WaitForSeconds(2);

        SceneManager.LoadScene(3);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ResetGame()
    {
        PlayerPrefs.SetInt("SceneToLoad", 0);
        PlayerPrefs.SetInt("LivesSaved", 0);
        PlayerPrefs.SetInt("ScoreSaved", 0);
        PlayerPrefs.SetInt("AmmoSaved", 0);
    }

    public void LoadGame()
    {
        StartCoroutine(LoadGameRoutine());
    }

    IEnumerator LoadGameRoutine()
    {
        PlayerPrefs.GetInt("SceneToLoad", loadScene);
        PlayerPrefs.GetInt("LivesSaved", loadLives);
        PlayerPrefs.GetInt("ScoreSaved", loadScore);
        PlayerPrefs.GetInt("AmmoSaved", loadAmmo);

        clickSound.Play();
        fadeOut.SetActive(true);

        GlobalComplete.currentFloor = 3;

        yield return new WaitForSeconds(2);

        GlobalComplete.currentFloor = loadScene;
        GlobalLives.livesValue = loadLives;
        GlobalScore.scoreValue = loadScore;
        GlobalAmmoCount.currentAmmo = loadAmmo;

        SceneManager.LoadScene(loadScene);
    }

    public void Credit()
    {
        clickSound.Play();
        SceneManager.LoadScene(1);
    }
}
