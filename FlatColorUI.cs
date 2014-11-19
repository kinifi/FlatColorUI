using UnityEngine;
using UnityEditor;
using System.IO;
using System.Collections;

public class FlatColorUI : EditorWindow {

    public bool showReds = false;
    public bool showPinks = false;
    public bool showOptions = false;

    //Colors
    #region Reds
    private Color ChestNutRose = new Color(0.823f, 0.301f, 0.341f);
    private Color Pomegranate = new Color(0.95f, 0.14f, 0.074f);
    private Color Red = new Color(1, 0, 0);
    private Color ThunderBird = new Color(0.85f, 0.117f, 0.09f);
    private Color OldBrick = new Color(0.588f, 0.156f, 0.10f);
    private Color Flamingo = new Color(0.937f, 0.282f, 0.211f);
    //TODO: Check if Tall Poppy is correct. 
    private Color TallPoppy = new Color(0.752f, 0.22f, 0.168f);
    private Color Monza = new Color(0.811f, 0, 0.058f);
    private Color Cinnabar = new Color(0.905f, 0.298f, 0.235f);
    #endregion

    #region Pinks
    private Color Razzmatazz = new Color(0.858f, 0.0392f, 0.356f);
    #endregion


    [MenuItem("Window/FlatColorUI")]
    public static void ShowWindow()
    {
        //Show existing window instance. If one doesn't exist, make one.
        EditorWindow.GetWindow(typeof(FlatColorUI));
    }


	// Use this for initialization
	void Start () {
        
	}

    void CreateMaterial(Color newColor, string materialName)
    {
        var newMaterial = new Material(Shader.Find("Diffuse"));
        newMaterial.color = newColor;
        AssetDatabase.CreateAsset(newMaterial, "Assets/"+ materialName + ".mat");
        Debug.Log("Created FlatUI Material: " + AssetDatabase.GetAssetPath(newMaterial));
    }

    void OnGUI()
    {
        //Title
        GUILayout.Space(10);
        GUILayout.Label("Flat Color UI: Created by @kinifi");


        #region Red Colors
        showReds = EditorGUILayout.Foldout(showReds, "Reds");
        if (showReds)
        {
            GUILayout.Space(5);
            #region ChestNut Red
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            ChestNutRose = EditorGUILayout.ColorField("ChestNut Rose:", ChestNutRose);
            if (GUILayout.Button("Create ChestNut Rose"))
            {
                CreateMaterial(ChestNutRose, "ChestNut_Rose");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region Pomegranate
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Pomegranate = EditorGUILayout.ColorField("Pomegranate:", Pomegranate);
            if (GUILayout.Button("Create Pomegranate"))
            {
                CreateMaterial(Pomegranate, "Pomegranate");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region Red
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Red = EditorGUILayout.ColorField("Red:", Red);
            if (GUILayout.Button("Create Red"))
            {
                CreateMaterial(Red, "Red");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region ThunderBird
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            ThunderBird = EditorGUILayout.ColorField("ThunderBird:", ThunderBird);
            if (GUILayout.Button("Create ThunderBird"))
            {
                CreateMaterial(ThunderBird, "ThunderBird");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region OldBrick
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            OldBrick = EditorGUILayout.ColorField("OldBrick:", OldBrick);
            if (GUILayout.Button("Create OldBrick"))
            {
                CreateMaterial(OldBrick, "OldBrick");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region Flamingo
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Flamingo = EditorGUILayout.ColorField("Flamingo:", Flamingo);
            if (GUILayout.Button("Create Flamingo"))
            {
                CreateMaterial(Flamingo, "Flamingo");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region TallPoppy
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            TallPoppy = EditorGUILayout.ColorField("TallPoppy:", TallPoppy);
            if (GUILayout.Button("Create TallPoppy"))
            {
                CreateMaterial(TallPoppy, "TallPoppy");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region Monza
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Monza = EditorGUILayout.ColorField("Monza:", Monza);
            if (GUILayout.Button("Create Monza"))
            {
                CreateMaterial(Monza, "Monza");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region Cinnabar
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Cinnabar = EditorGUILayout.ColorField("Cinnabar:", Cinnabar);
            if (GUILayout.Button("Create Cinnabar"))
            {
                CreateMaterial(Cinnabar, "Cinnabar");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

        }
        #endregion

        #region Pinks Colors
        showPinks = EditorGUILayout.Foldout(showPinks, "Pinks");
        if (showPinks)
        {
            #region Razzmatazz
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Razzmatazz = EditorGUILayout.ColorField("Razzmatazz:", Razzmatazz);
            if (GUILayout.Button("Create Razzmatazz"))
            {
                CreateMaterial(Razzmatazz, "Razzmatazz");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion
        }
        #endregion

    }

}
