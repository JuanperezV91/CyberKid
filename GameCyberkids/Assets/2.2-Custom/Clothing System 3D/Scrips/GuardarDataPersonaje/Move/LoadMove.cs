using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadMove : MonoBehaviour {

    public int nextSceneIndex;
    bool load;

    void OnTriggerEnter()
    {
        if (!load)
        {
            load = true;
            StartCoroutine(ChangeScene());
        }
    }

    IEnumerator ChangeScene()
    {
        SceneManager.LoadScene(nextSceneIndex, LoadSceneMode.Additive);
        Scene nextScene = SceneManager.GetSceneAt(2);
        SceneManager.MoveGameObjectToScene(gameObject, nextScene);

        yield return null;
        SceneManager.UnloadScene(nextSceneIndex - 1);
    }

   
}
