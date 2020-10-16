using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(HighScores))] //je custom l'éditor pour les objet de type "highscore"
public class HighScore_Editor : Editor
{

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        EditorGUILayout.BeginHorizontal();
        {
            //EditorGUILayout.Space();
            if (GUILayout.Button("Save"))
            {
                (target as HighScores).Save();
            }

            //EditorGUILayout.Space();

            if (GUILayout.Button("Load"))
            {
                (target as HighScores).Load();
            }
        }
        EditorGUILayout.EndHorizontal();
    }

}
