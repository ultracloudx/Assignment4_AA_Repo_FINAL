using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pinPrefab;
    public GameObject pauseMenuUI;

    private void Update()
    {
        if (!pauseMenuUI.activeInHierarchy)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                SpawnPin();
            }
        }
    }

    void SpawnPin()
    {
        Instantiate(pinPrefab, transform.position, transform.rotation);
    }

}
