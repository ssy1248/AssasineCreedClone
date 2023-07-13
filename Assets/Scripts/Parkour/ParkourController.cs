using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkourController : MonoBehaviour
{
    public EnviromentChecker enviromentChecker;

    private void Update()
    {
        var hitData = enviromentChecker.CheckObstacle();

        if(hitData.hitFound)
        {
            Debug.Log("Object Founded" + hitData.hitInfo.transform.name);
        }
    }
}
