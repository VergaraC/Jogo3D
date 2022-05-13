using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyable : MonoBehaviour
{
    public void DeletePlatform()
    {
        Destroy(this.gameObject);
        GameManager.cubos++;
    }
}
