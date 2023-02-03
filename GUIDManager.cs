using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Attach this to GameObjects

public class GUIDManager : MonoBehaviour
{
    public string generatedGUID;

    public void GenerateGUID()
    {
        generatedGUID = Guid.NewGuid().ToString();
    }
}
