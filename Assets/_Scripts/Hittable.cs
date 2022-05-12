using System.Collections;
using UnityEngine;


public class Hittable : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    public void SpawnPlatform(Vector3 p)
    {
        Instantiate(prefab, p, Quaternion.identity);
        GameManager.cubos--;
    }
}
