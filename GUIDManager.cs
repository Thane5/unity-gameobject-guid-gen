using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIDManager : MonoBehaviour
{
    // Attach this to GameObjects
    public string generatedGUID;

    public void GenerateGUID()
    {
        generatedGUID = Guid.NewGuid().ToString();
    }
}
