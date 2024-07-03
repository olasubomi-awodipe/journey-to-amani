using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneTransition : MonoBehaviour
{
    void OnEnable()
    {
        // Only specifying the sceneName or sceneBuildIndesx will load the scene with the Single mode
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }
}
