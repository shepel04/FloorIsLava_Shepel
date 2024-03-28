using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasRenderModeChanger : MonoBehaviour
{
    public GameObject InstructionCanvas;
    public GameObject PauseCanvas;
    
    public void EnableInstructionCanvas()
    {
        InstructionCanvas.SetActive(true);
    }
    public void EnablePauseCanvas()
    {
        PauseCanvas.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            InstructionCanvas.SetActive(false);
            PauseCanvas.SetActive(false);
            Time.timeScale = 0f;
        }
    }
}