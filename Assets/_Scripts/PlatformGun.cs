using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGun : MonoBehaviour
{
    [SerializeField] public Camera cam;
    private float range = 100f;

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            if (GameManager.cubos > 0)
            {
                ShootPlatform();
                GameManager.cubos--;
                Debug.Log(GameManager.cubos);
            }

            else
            {
                Debug.Log("sem munição");
                Debug.Log(GameManager.cubos);
            }
        }
    }

    void ShootPlatform()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            Hittable hittable = hit.transform.GetComponent<Hittable>();
            if (hittable != null)
            {
                Vector3 hitLocation = hit.point;
                hittable.SpawnPlatform(hitLocation);
            }
        }
    }
}
