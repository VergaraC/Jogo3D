using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGun : MonoBehaviour
{
    [SerializeField] public Camera cam;
    private float range = 100f;

    void Update()
    {
        if(Input.GetButtonDown("Fire1") && !MenuController.GameIsPaused)
        {
            if (GameManager.cubos > 0)
            {
                ShootPlatform();
            }

            else
            {
                Debug.Log("sem munição");
                Debug.Log(GameManager.cubos);
            }
        }

        if (Input.GetButtonDown("Fire2") && !MenuController.GameIsPaused)
        {
            DeletePlatform();
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

    void DeletePlatform()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            Destroyable destroyable = hit.transform.GetComponent<Destroyable>();
            if (destroyable != null)
            {
                destroyable.DeletePlatform();
            }
        }
    }
}

