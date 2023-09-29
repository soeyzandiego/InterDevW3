using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] float waitTime = 1f;

    int sceneToLoad = 0;

    // Update is called once per frame
    void Update()
    {
        // r to restart
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void QueueSceneOfIndex(int _index)
    {
        sceneToLoad = _index;
        StartCoroutine(WaitAndLoad());
    }

    IEnumerator WaitAndLoad()
    {
        yield return new WaitForSecondsRealtime(waitTime);
        SceneManager.LoadScene(sceneToLoad);
    }
}
