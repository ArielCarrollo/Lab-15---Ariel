using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerController : MonoBehaviour
{ 
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)== true)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
    public void CAMBIOdecena()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
