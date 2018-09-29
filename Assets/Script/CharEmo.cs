using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharEmo{

    public List<Sprite> ekspresi = new List<Sprite>();

    public CharEmo()
    {
        ekspresi.Add(Resources.Load<Sprite>("M Biasa"));
        ekspresi.Add(Resources.Load<Sprite>("M Marah"));
        ekspresi.Add(Resources.Load<Sprite>("M Seneng"));
        ekspresi.Add(Resources.Load<Sprite>("F Biasa"));
        ekspresi.Add(Resources.Load<Sprite>("F Marah"));
        ekspresi.Add(Resources.Load<Sprite>("F Seneng"));
    }
}
