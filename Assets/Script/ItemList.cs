using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemList{

    public List<Sprite> sprite = new List<Sprite>();
    public List<float> value = new List<float>();

    public ItemList()
    {
        sprite.Add(Resources.Load<Sprite>("A"));
        sprite.Add(Resources.Load<Sprite>("B"));
        sprite.Add(Resources.Load<Sprite>("C"));
        sprite.Add(Resources.Load<Sprite>("D"));
        sprite.Add(Resources.Load<Sprite>("E"));
        sprite.Add(Resources.Load<Sprite>("F"));
        value.Add(1);
        value.Add(2);
        value.Add(3);
        value.Add(4);
        value.Add(5);
        value.Add(10);
    }
}
