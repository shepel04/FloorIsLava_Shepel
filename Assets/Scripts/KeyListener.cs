using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyListener : MonoBehaviour
{
    public GameObject InstructionCanvas;
    public GameObject PauseCanvas;
    private bool _isPauseActive;
    
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
            _isPauseActive = true;
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            if (_isPauseActive)
            {
                Time.timeScale = 1f;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                _isPauseActive = false;
            }
            else
            {
                Time.timeScale = 0f;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            
        }
    }
}
