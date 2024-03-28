using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyListener : MonoBehaviour
{
    public GameObject InstructionCanvas;
    public GameObject PauseCanvas;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.H))
        {
            InstructionCanvas.SetActive(true);
            
        }
        if (Input.GetKey(KeyCode.P))
        {
            PauseCanvas.SetActive(true);
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
