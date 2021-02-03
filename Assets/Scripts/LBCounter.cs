using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LBCounter : MonoBehaviour
{
    public static int LBCount;
    // Start is called before the first frame update
    void Start()
    {
        LBCount = GameObject.FindGameObjectsWithTag("leisure block").Length;
    }
    private void OnDestroy()
    {
        LBCount--;
    }
}
