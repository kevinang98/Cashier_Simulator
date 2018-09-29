using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAgain : MonoBehaviour {

    public void OnMouseDown()
    {
        Application.LoadLevel(1);
        transform.localScale *= 0.9f;
    }
}
