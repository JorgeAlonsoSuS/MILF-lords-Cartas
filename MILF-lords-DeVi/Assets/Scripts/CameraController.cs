using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Deck
{
public class CameraController : MonoBehaviour
{
    
    public Camera MainCamera;
    public Camera MenuCamera;

    public void ShowMenuView() {
        MainCamera.enabled = false;
        MenuCamera.enabled = true;
    }
    
    public void ShowGameView() {
        MainCamera.enabled = true;
        MenuCamera.enabled = false;
        //Aqui hay que hacer un singleton a game managar para que empecemos aqui el game loop
    }
    
}
}
