using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeCounterUI : MonoBehaviour
{
    public Text Counter;

    void Update()
    {
        Counter.text = $"BLOCKS: {GameManager.cubos}";
    }
}
