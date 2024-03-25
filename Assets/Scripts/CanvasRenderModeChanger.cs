using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasRenderModeChanger : MonoBehaviour
{
    public GameObject BigCanvas;
    
    public void EnableBigCanvas()
    {
        BigCanvas.SetActive(true);

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            BigCanvas.SetActive(false);
        }
    }
}