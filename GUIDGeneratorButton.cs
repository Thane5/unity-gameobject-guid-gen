using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

// Move this file into a folder named "Editor", or building will fail.

[CustomEditor((typeof(GUIDManager)))]
public class GUIDGeneratorButton : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        
        GUIDManager linkedScript = (GUIDManager)target;
        if (GUILayout.Button("Generate GUID"))
        {
            linkedScript.GenerateGUID();
        }
    }
}
