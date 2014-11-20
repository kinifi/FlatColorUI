using UnityEngine;
using UnityEditor;
using System.IO;
using System.Collections;

public class FlatColorUI : EditorWindow
{

    #region showColor Bools
    public bool showReds = false;
    public bool showPinks = false;
    public bool showPurple = false;
    public bool showBlue = false;
    public bool showGreen = false;
    public bool showYellow = false;
    public bool showOrange = false;
    public bool showGray = false;
    public bool showOptions = false;
    #endregion

    //the scroll position stored in a Vector2
    private Vector2 scrollPos;

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
    private Color Derby = new Color(1, 0.925f, 0.858f);
    private Color SunsetOrange = new Color(0.964f, 0.278f, 0.278f);
    private Color WaxFlower = new Color(0.945f, 0.662f, 0.627f);
    private Color Cabaret = new Color(0.823f, 0.321f, 0.498f);
    private Color NewYorkPink = new Color(0.878f, 0.509f, 0.513f);
    private Color RadicalRed = new Color(0.964f, 0.141f, 0.349f);
    private Color Sunglo = new Color(0.886f, 0.415f, 0.415f);
    #endregion

    #region Purple
    private Color Snuff = new Color(0.862f, 0.776f, 0.878f);
    private Color RebeccaPurple = new Color(0.4f, 0.2f, 0.6f);
    private Color HoneyFlower = new Color(0.403f, 0.254f, 0.447f);
    private Color Wistful = new Color(0.682f, 0.658f, 0.827f);
    private Color Plum = new Color(0.568f, 0.239f, 0.533f);
    private Color Seance = new Color(0.603f, 0.070f, 0.701f);
    private Color MediumPurple = new Color(0.749f, 0.333f, 0.925f);
    private Color LightWisteria = new Color(0.745f, 0.564f, 0.831f);
    private Color Studio = new Color(0.556f, 0.266f, 0.678f);
    private Color Wisteria = new Color(0.607f, 0.349f, 0.713f);
    #endregion

    #region Blue
    private Color SanMarino = new Color(0.266f, 0.423f, 0.701f);
    private Color AliceBlue = new Color(0.894f, 0.945f, 0.996f);
    private Color RoyalBlue = new Color(0.254f, 0.513f, 0.843f);
    private Color PictonBlue = new Color(0.349f, 0.670f, 0.890f);
    private Color Spray = new Color(0.505f, 0.811f, 0.878f);
    private Color Shakespeare = new Color(0.321f, 0.701f, 0.850f);
    private Color HummingBird = new Color(0.772f, 0.937f, 0.968f);
    private Color PictonBlueTwo = new Color(0.203f, 0.596f, 0.858f);
    private Color Madison = new Color(0.172f, 0.243f, 0.313f);
    private Color DodgerBlue = new Color(0.098f, 0.709f, 0.996f);
    private Color Ming = new Color(0.2f, 0.431f, 0.482f);
    private Color EbonyClay = new Color(0.133f, 0.192f, 0.247f);
    private Color Malibu = new Color(0.419f, 0.725f, 0.941f);
    private Color CuriousBlue = new Color(0.117f, 0.545f, 0.764f);
    private Color Chambray = new Color(0.227f, 0.325f, 0.607f);
    private Color PickledBlueWood = new Color(0.203f, 0.286f, 0.368f);
    private Color Hoki = new Color(0.403f, 0.501f, 0.623f);
    private Color JellyBean = new Color(0.145f, 0.454f, 0.662f);
    private Color JacksonsPurple = new Color(0.121f, 0.227f, 0.576f);
    private Color JordyBlue = new Color(0.537f, 0.768f, 0.956f);
    private Color SteelBlue = new Color(0.294f, 0.466f, 0.745f);
    private Color FoundtainBlue = new Color(0.360f, 0.592f, 0.749f);
    #endregion

    #region Green
    private Color MediumTurquoise = new Color(0.305f, 0.803f, 0.768f);
    private Color AquaIsland = new Color(0.635f, 0.870f, 0.815f);
    private Color Gossip = new Color(0.529f, 0.827f, 0.486f);
    private Color DarkSeaGreen = new Color(0.564f, 0.776f, 0.584f);
    private Color Eucalyptus = new Color(0.149f, 0.650f, 0.356f);
    private Color CaribbeanGreen = new Color(0.011f, 0.650f, 0.356f);
    private Color SilverTree = new Color(0.407f, 0.764f, 0.639f);
    private Color Downy = new Color(0.396f, 0.776f, 0.733f);
    private Color MountainMeadow = new Color(0.105f, 0.737f, 0.607f);
    private Color LightSeaGreen = new Color(0.105f, 0.639f, 0.611f);
    private Color MediumAquaMarine = new Color(0.4f, 0.8f, 0.6f);
    private Color Turquoise = new Color(0.211f, 0.843f, 0.717f);
    private Color Madang = new Color(0.784f, 0.968f, 0.772f);
    private Color Riptide = new Color(0.525f, 0.886f, 0.835f);
    private Color Shamrock = new Color(0.180f, 0.8f, 0.443f);
    private Color MountainMeadowTwo = new Color(0.086f, 0.627f, 0.521f);
    private Color Emerald = new Color(0.247f, 0.764f, 0.501f);
    private Color GreenHaze = new Color(0.003f, 0.596f, 0.458f);
    private Color FreeSpeechAquaMarine = new Color(0.011f, 0.650f, 0.470f);
    private Color OceanGreen = new Color(0.301f, 0.686f, 0.486f);
    private Color Niagara = new Color(0.164f, 0.733f, 0.607f);
    private Color Jade = new Color(0, 0.694f, 0.415f);
    private Color Salem = new Color(0.117f, 0.509f, 0.298f);
    private Color Observatory = new Color(0.015f, 0.576f, 0.447f);
    private Color JungleGreen = new Color(0.149f, 0.760f, 0.505f);
    #endregion

    #region Yellow
    private Color CreamCan = new Color(0.960f, 0.843f, 0.431f);
    private Color RipeLemon = new Color(0.968f, 0.792f, 0.094f);
    private Color Saffron = new Color(0.956f, 0.815f, 0.247f);
    #endregion

    [MenuItem("Window/FlatColorUI")]
    public static void ShowWindow()
    {
        //Show existing window instance. If one doesn't exist, make one.
        EditorWindow.GetWindow(typeof(FlatColorUI));
    }


    // Use this for initialization
    void Start()
    {

    }

    /// Create Material
    /// <summary>
    /// Create a material in the Assets Folder
    /// </summary>
    /// <param name="newColor"></param>
    /// <param name="materialName"></param>
    void CreateMaterial(Color newColor, string materialName)
    {
        var newMaterial = new Material(Shader.Find("Diffuse"));
        newMaterial.color = newColor;
        AssetDatabase.CreateAsset(newMaterial, "Assets/" + materialName + ".mat");
        Debug.Log("Created FlatUI Material: " + AssetDatabase.GetAssetPath(newMaterial));
    }

    void OnGUI()
    {
        //Title
        GUILayout.Space(10);
        GUILayout.Label("Flat Color UI: Created by @kinifi");

        scrollPos = EditorGUILayout.BeginScrollView(scrollPos);

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
        EditorGUI.indentLevel = 0;
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

            #region Derby
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Derby = EditorGUILayout.ColorField("Derby:", Derby);
            if (GUILayout.Button("Create Derby"))
            {
                CreateMaterial(Derby, "Derby");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region SunsetOrange
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            SunsetOrange = EditorGUILayout.ColorField("SunsetOrange:", SunsetOrange);
            if (GUILayout.Button("Create SunsetOrange"))
            {
                CreateMaterial(SunsetOrange, "SunsetOrange");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region WaxFlower
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            WaxFlower = EditorGUILayout.ColorField("WaxFlower:", WaxFlower);
            if (GUILayout.Button("Create WaxFlower"))
            {
                CreateMaterial(WaxFlower, "WaxFlower");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region Cabaret
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Cabaret = EditorGUILayout.ColorField("Cabaret:", Cabaret);
            if (GUILayout.Button("Create Cabaret"))
            {
                CreateMaterial(Cabaret, "Cabaret");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region NewYorkPink
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            NewYorkPink = EditorGUILayout.ColorField("NewYorkPink:", NewYorkPink);
            if (GUILayout.Button("Create NewYorkPink"))
            {
                CreateMaterial(NewYorkPink, "NewYorkPink");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region RadicalRed
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            RadicalRed = EditorGUILayout.ColorField("RadicalRed:", RadicalRed);
            if (GUILayout.Button("Create RadicalRed"))
            {
                CreateMaterial(RadicalRed, "RadicalRed");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region Sunglo
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Sunglo = EditorGUILayout.ColorField("Sunglo:", Sunglo);
            if (GUILayout.Button("Create Sunglo"))
            {
                CreateMaterial(Sunglo, "Sunglo");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

        }
        #endregion

        #region Purple Colors
        EditorGUI.indentLevel = 0;
        showPurple = EditorGUILayout.Foldout(showPurple, "Purples");
        if (showPurple)
        {

            #region Snuff
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Snuff = EditorGUILayout.ColorField("Snuff:", Snuff);
            if (GUILayout.Button("Create Snuff"))
            {
                CreateMaterial(Snuff, "Snuff");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region RebeccaPurple
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            RebeccaPurple = EditorGUILayout.ColorField("RebeccaPurple:", RebeccaPurple);
            if (GUILayout.Button("Create RebeccaPurple"))
            {
                CreateMaterial(RebeccaPurple, "RebeccaPurple");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region HoneyFlower
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            HoneyFlower = EditorGUILayout.ColorField("HoneyFlower:", HoneyFlower);
            if (GUILayout.Button("Create HoneyFlower"))
            {
                CreateMaterial(HoneyFlower, "HoneyFlower");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region Wistful
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Wistful = EditorGUILayout.ColorField("Wistful:", Wistful);
            if (GUILayout.Button("Create Wistful"))
            {
                CreateMaterial(Wistful, "Wistful");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region Plum
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Plum = EditorGUILayout.ColorField("Plum:", Plum);
            if (GUILayout.Button("Create Plum"))
            {
                CreateMaterial(Plum, "Plum");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region Seance
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Seance = EditorGUILayout.ColorField("Seance:", Seance);
            if (GUILayout.Button("Create Seance"))
            {
                CreateMaterial(Seance, "Seance");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region MediumPurple
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            MediumPurple = EditorGUILayout.ColorField("MediumPurple:", MediumPurple);
            if (GUILayout.Button("Create MediumPurple"))
            {
                CreateMaterial(MediumPurple, "MediumPurple");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region LightWisteria
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            LightWisteria = EditorGUILayout.ColorField("LightWisteria:", LightWisteria);
            if (GUILayout.Button("Create LightWisteria"))
            {
                CreateMaterial(LightWisteria, "LightWisteria");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region Studio
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Studio = EditorGUILayout.ColorField("Studio:", Studio);
            if (GUILayout.Button("Create Studio"))
            {
                CreateMaterial(Studio, "Studio");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region Wisteria
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Wisteria = EditorGUILayout.ColorField("Wisteria:", Wisteria);
            if (GUILayout.Button("Create Wisteria"))
            {
                CreateMaterial(Wisteria, "Wisteria");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

        }
        #endregion

        #region Blue Colors
        EditorGUI.indentLevel = 0;
        showBlue = EditorGUILayout.Foldout(showBlue, "Blue");
        if (showBlue)
        {
            #region SanMarino
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            SanMarino = EditorGUILayout.ColorField("SanMarino:", SanMarino);
            if (GUILayout.Button("Create SanMarino"))
            {
                CreateMaterial(SanMarino, "SanMarino");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region AliceBlue
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            AliceBlue = EditorGUILayout.ColorField("AliceBlue:", AliceBlue);
            if (GUILayout.Button("Create AliceBlue"))
            {
                CreateMaterial(AliceBlue, "AliceBlue");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region RoyalBlue
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            RoyalBlue = EditorGUILayout.ColorField("RoyalBlue:", RoyalBlue);
            if (GUILayout.Button("Create RoyalBlue"))
            {
                CreateMaterial(RoyalBlue, "RoyalBlue");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region PictonBlue
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            PictonBlue = EditorGUILayout.ColorField("PictonBlue:", PictonBlue);
            if (GUILayout.Button("Create PictonBlue"))
            {
                CreateMaterial(PictonBlue, "PictonBlue");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region Spray
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Spray = EditorGUILayout.ColorField("Spray:", Spray);
            if (GUILayout.Button("Create Spray"))
            {
                CreateMaterial(Spray, "Spray");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region Shakespeare
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Shakespeare = EditorGUILayout.ColorField("Shakespeare:", Shakespeare);
            if (GUILayout.Button("Create Shakespeare"))
            {
                CreateMaterial(Shakespeare, "Shakespeare");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region HummingBird
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            HummingBird = EditorGUILayout.ColorField("HummingBird:", HummingBird);
            if (GUILayout.Button("Create HummingBird"))
            {
                CreateMaterial(HummingBird, "HummingBird");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region PictonBlueTwo
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            PictonBlueTwo = EditorGUILayout.ColorField("PictonBlueTwo:", PictonBlueTwo);
            if (GUILayout.Button("Create PictonBlueTwo"))
            {
                CreateMaterial(PictonBlueTwo, "PictonBlueTwo");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region Madison
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Madison = EditorGUILayout.ColorField("Madison:", Madison);
            if (GUILayout.Button("Create Madison"))
            {
                CreateMaterial(Madison, "Madison");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region DodgerBlue
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            DodgerBlue = EditorGUILayout.ColorField("DodgerBlue:", DodgerBlue);
            if (GUILayout.Button("Create DodgerBlue"))
            {
                CreateMaterial(DodgerBlue, "DodgerBlue");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region Ming
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Ming = EditorGUILayout.ColorField("Ming:", Ming);
            if (GUILayout.Button("Create Ming"))
            {
                CreateMaterial(Ming, "Ming");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region EbonyClay
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            EbonyClay = EditorGUILayout.ColorField("EbonyClay:", EbonyClay);
            if (GUILayout.Button("Create EbonyClay"))
            {
                CreateMaterial(EbonyClay, "EbonyClay");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region Malibu
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Malibu = EditorGUILayout.ColorField("Malibu:", Malibu);
            if (GUILayout.Button("Create Malibu"))
            {
                CreateMaterial(Malibu, "Malibu");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region CuriousBlue
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            CuriousBlue = EditorGUILayout.ColorField("CuriousBlue:", CuriousBlue);
            if (GUILayout.Button("Create CuriousBlue"))
            {
                CreateMaterial(CuriousBlue, "CuriousBlue");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region Chambray
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Chambray = EditorGUILayout.ColorField("Chambray:", Chambray);
            if (GUILayout.Button("Create Chambray"))
            {
                CreateMaterial(Chambray, "Chambray");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region PickledBlueWood
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            PickledBlueWood = EditorGUILayout.ColorField("PickledBlueWood:", PickledBlueWood);
            if (GUILayout.Button("Create PickledBlueWood"))
            {
                CreateMaterial(PickledBlueWood, "PickledBlueWood");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region Hoki
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Hoki = EditorGUILayout.ColorField("Hoki:", Hoki);
            if (GUILayout.Button("Create Hoki"))
            {
                CreateMaterial(Hoki, "Hoki");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region JellyBean
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            JellyBean = EditorGUILayout.ColorField("JellyBean:", JellyBean);
            if (GUILayout.Button("Create JellyBean"))
            {
                CreateMaterial(JellyBean, "JellyBean");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region JacksonsPurple
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            JacksonsPurple = EditorGUILayout.ColorField("JacksonsPurple:", JacksonsPurple);
            if (GUILayout.Button("Create JacksonsPurple"))
            {
                CreateMaterial(JacksonsPurple, "JacksonsPurple");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region JordyBlue
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            JordyBlue = EditorGUILayout.ColorField("JordyBlue:", JordyBlue);
            if (GUILayout.Button("Create JordyBlue"))
            {
                CreateMaterial(JordyBlue, "JordyBlue");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region SteelBlue
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            SteelBlue = EditorGUILayout.ColorField("SteelBlue:", SteelBlue);
            if (GUILayout.Button("Create SteelBlue"))
            {
                CreateMaterial(SteelBlue, "SteelBlue");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region FoundtainBlue
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            FoundtainBlue = EditorGUILayout.ColorField("FoundtainBlue:", FoundtainBlue);
            if (GUILayout.Button("Create FoundtainBlue"))
            {
                CreateMaterial(FoundtainBlue, "FoundtainBlue");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

        }
        #endregion

        #region Green Colors
        EditorGUI.indentLevel = 0;
        showGreen = EditorGUILayout.Foldout(showGreen, "Green");
        if (showGreen)
        {
            #region MediumTurquoise
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            MediumTurquoise = EditorGUILayout.ColorField("MediumTurquoise:", MediumTurquoise);
            if (GUILayout.Button("Create MediumTurquoise"))
            {
                CreateMaterial(MediumTurquoise, "MediumTurquoise");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region AquaIsland
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            AquaIsland = EditorGUILayout.ColorField("AquaIsland:", AquaIsland);
            if (GUILayout.Button("Create AquaIsland"))
            {
                CreateMaterial(AquaIsland, "AquaIsland");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region Gossip
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Gossip = EditorGUILayout.ColorField("Gossip:", Gossip);
            if (GUILayout.Button("Create Gossip"))
            {
                CreateMaterial(Gossip, "Gossip");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region DarkSeaGreen
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            DarkSeaGreen = EditorGUILayout.ColorField("DarkSeaGreen:", DarkSeaGreen);
            if (GUILayout.Button("Create DarkSeaGreen"))
            {
                CreateMaterial(DarkSeaGreen, "DarkSeaGreen");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region Eucalyptus
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Eucalyptus = EditorGUILayout.ColorField("Eucalyptus:", Eucalyptus);
            if (GUILayout.Button("Create Eucalyptus"))
            {
                CreateMaterial(Eucalyptus, "Eucalyptus");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region CaribbeanGreen
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            CaribbeanGreen = EditorGUILayout.ColorField("CaribbeanGreen:", CaribbeanGreen);
            if (GUILayout.Button("Create CaribbeanGreen"))
            {
                CreateMaterial(CaribbeanGreen, "CaribbeanGreen");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region SilverTree
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            SilverTree = EditorGUILayout.ColorField("SilverTree:", SilverTree);
            if (GUILayout.Button("Create SilverTree"))
            {
                CreateMaterial(SilverTree, "SilverTree");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region Downy
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Downy = EditorGUILayout.ColorField("Downy:", Downy);
            if (GUILayout.Button("Create Downy"))
            {
                CreateMaterial(Downy, "Downy");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region MountainMeadow
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            MountainMeadow = EditorGUILayout.ColorField("MountainMeadow:", MountainMeadow);
            if (GUILayout.Button("Create MountainMeadow"))
            {
                CreateMaterial(MountainMeadow, "MountainMeadow");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region LightSeaGreen
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            LightSeaGreen = EditorGUILayout.ColorField("LightSeaGreen:", LightSeaGreen);
            if (GUILayout.Button("Create LightSeaGreen"))
            {
                CreateMaterial(LightSeaGreen, "LightSeaGreen");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region MediumAquaMarine
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            MediumAquaMarine = EditorGUILayout.ColorField("MediumAquaMarine:", MediumAquaMarine);
            if (GUILayout.Button("Create MediumAquaMarine"))
            {
                CreateMaterial(MediumAquaMarine, "MediumAquaMarine");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region Turquoise
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Turquoise = EditorGUILayout.ColorField("Turquoise:", Turquoise);
            if (GUILayout.Button("Create Turquoise"))
            {
                CreateMaterial(Turquoise, "Turquoise");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region Madang
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Madang = EditorGUILayout.ColorField("Madang:", Madang);
            if (GUILayout.Button("Create Madang"))
            {
                CreateMaterial(Madang, "Madang");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region Riptide
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Riptide = EditorGUILayout.ColorField("Riptide:", Riptide);
            if (GUILayout.Button("Create Riptide"))
            {
                CreateMaterial(Riptide, "Riptide");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region Shamrock
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Shamrock = EditorGUILayout.ColorField("Shamrock:", Shamrock);
            if (GUILayout.Button("Create Shamrock"))
            {
                CreateMaterial(Shamrock, "Shamrock");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region MountainMeadowTwo
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            MountainMeadowTwo = EditorGUILayout.ColorField("MountainMeadowTwo:", MountainMeadowTwo);
            if (GUILayout.Button("Create MountainMeadowTwo"))
            {
                CreateMaterial(MountainMeadowTwo, "MountainMeadowTwo");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region Emerald
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Emerald = EditorGUILayout.ColorField("Emerald:", Emerald);
            if (GUILayout.Button("Create Emerald"))
            {
                CreateMaterial(Emerald, "Emerald");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region GreenHaze
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            GreenHaze = EditorGUILayout.ColorField("GreenHaze:", GreenHaze);
            if (GUILayout.Button("Create GreenHaze"))
            {
                CreateMaterial(GreenHaze, "GreenHaze");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region FreeSpeechAquaMarine
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            FreeSpeechAquaMarine = EditorGUILayout.ColorField("FreeSpeechAquaMarine:", FreeSpeechAquaMarine);
            if (GUILayout.Button("Create FreeSpeechAquaMarine"))
            {
                CreateMaterial(FreeSpeechAquaMarine, "FreeSpeechAquaMarine");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region OceanGreen
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            OceanGreen = EditorGUILayout.ColorField("OceanGreen:", OceanGreen);
            if (GUILayout.Button("Create OceanGreen"))
            {
                CreateMaterial(OceanGreen, "OceanGreen");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region Niagara
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Niagara = EditorGUILayout.ColorField("Niagara:", Niagara);
            if (GUILayout.Button("Create Niagara"))
            {
                CreateMaterial(Niagara, "Niagara");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region Jade
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Jade = EditorGUILayout.ColorField("Jade:", Jade);
            if (GUILayout.Button("Create Jade"))
            {
                CreateMaterial(Jade, "Jade");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region Salem
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Salem = EditorGUILayout.ColorField("Salem:", Salem);
            if (GUILayout.Button("Create Salem"))
            {
                CreateMaterial(Salem, "Salem");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region Observatory
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Observatory = EditorGUILayout.ColorField("Observatory:", Observatory);
            if (GUILayout.Button("Create Observatory"))
            {
                CreateMaterial(Observatory, "Observatory");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region JungleGreen
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            JungleGreen = EditorGUILayout.ColorField("JungleGreen:", JungleGreen);
            if (GUILayout.Button("Create JungleGreen"))
            {
                CreateMaterial(JungleGreen, "JungleGreen");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion
        }
        #endregion

        #region Yellow Colors
        EditorGUI.indentLevel = 0;
        showYellow = EditorGUILayout.Foldout(showYellow, "Yellows");
        if (showYellow)
        {
            #region CreamCan
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            CreamCan = EditorGUILayout.ColorField("CreamCan:", CreamCan);
            if (GUILayout.Button("Create CreamCan"))
            {
                CreateMaterial(CreamCan, "CreamCan");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region RipeLemon
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            RipeLemon = EditorGUILayout.ColorField("RipeLemon:", RipeLemon);
            if (GUILayout.Button("Create RipeLemon"))
            {
                CreateMaterial(RipeLemon, "RipeLemon");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion

            #region Saffron
            EditorGUI.indentLevel = 1;
            GUILayout.BeginHorizontal();
            Saffron = EditorGUILayout.ColorField("Saffron:", Saffron);
            if (GUILayout.Button("Create Saffron"))
            {
                CreateMaterial(CreamCan, "Saffron");
            }
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            #endregion
        }
        #endregion

        #region Orange Colors
        EditorGUI.indentLevel = 0;
        showOrange = EditorGUILayout.Foldout(showOrange, "Orange");
        if (showOrange)
        {

        }
        #endregion

        #region Gray Colors
        EditorGUI.indentLevel = 0;
        showGray = EditorGUILayout.Foldout(showGray, "Grays");
        if (showGray)
        {

        }
        #endregion


        EditorGUILayout.EndScrollView();
    }

}
