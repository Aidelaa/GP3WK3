using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(GameManager))]

public class GameManagerEditor : Editor
{
    // Start is called before the first frame update
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        GameManager myScript = (GameManager)target;
        if (GUILayout.Button("Reset"))
        {
            myScript.ResetValues();
        }
        if (GUILayout.Button("AddPowerUpConcentration"))
        {
            myScript.DamagePowerUp_Concentration();
        }
        if (GUILayout.Button("AddEXP"))
        {
            myScript.AddExp(myScript.expToAdd);
        }
    }
}
