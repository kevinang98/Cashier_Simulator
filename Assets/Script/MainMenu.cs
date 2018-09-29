using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    public void OnMouseDown()
    {
        Application.LoadLevel(0);
        transform.localScale *= 0.9f;
    }
}
