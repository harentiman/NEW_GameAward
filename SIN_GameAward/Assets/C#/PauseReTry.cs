using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseReTry: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        Time.timeScale = 1;
        FadeManager.Instance.LoadScene(SceneManager.GetActiveScene().name, 2f);
    }
}
