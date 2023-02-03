using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

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
