namespace MyBepInPlugin

open BepInEx
open Il2CppInterop.Runtime
open Il2CppInterop.Runtime.Injection
open UnityEngine
open BepInEx.Unity.IL2CPP

[<BepInPlugin("unreliablecode.com", "MyPlugin", "1.0.0")>]
type MainClass() =
    inherit BepInEx.Unity.IL2CPP.BasePlugin()

    override this.Load() =
        
        let newObject = GameObject("MyGameObject")
        Object.DontDestroyOnLoad(newObject)
        ClassInjector.RegisterTypeInIl2Cpp<MyMonoBehaviour>()        
        let myMonoBehaviour = newObject.AddComponent<MyMonoBehaviour>()
        newObject.hideFlags <- HideFlags.HideAndDontSave
        myMonoBehaviour.Initialize() 
        Debug.Log(Il2CppSystem.Object(IL2CPP.ManagedStringToIl2Cpp("Mod Loaded")))
    

and MyMonoBehaviour() =
    class
        inherit UnityEngine.MonoBehaviour()
        member this.Initialize() =
            Debug.Log(Il2CppSystem.Object(IL2CPP.ManagedStringToIl2Cpp("My MonoBehaviour Initialized")))

        member this.Start() =
            this.NormalStart()

        member this.Update() =
            this.NormalUpdate()
        member this.OnGUI() =
            GUILayout.BeginArea(new Rect(10.0f,10.0f,500.0f,500.0f))
            GUILayout.Label("Fsharp Mod OnGUI!")
            if GUILayout.Button("Fsharp Button!") then 
                Debug.Log(Il2CppSystem.Object(IL2CPP.ManagedStringToIl2Cpp("Button Clicked!")))
            GUILayout.EndArea()
        member private this.NormalStart() =
            Debug.Log(Il2CppSystem.Object(IL2CPP.ManagedStringToIl2Cpp("My MonoBehaviour Start!")))
        
        member private this.NormalUpdate() =
            "dO sOMETHING!"
    end
