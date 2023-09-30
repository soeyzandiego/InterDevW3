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
        // restart
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }


    // I ended up not needing another scene
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
