namespace MyBepInPlugin

open BepInEx
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
        printfn("Mod Loaded") //Changed From Debug.Log since idk how to cast string to il2cpp object in FSharp
    

and MyMonoBehaviour() =
    class
        inherit UnityEngine.MonoBehaviour()
        member this.Initialize() =
            printfn("MyMonoBehaviour initialized!") //Changed From Debug.Log since idk how to cast string to il2cpp object in FSharp

        member this.Start() =
            this.NormalStart()

        member this.Update() =
            this.NormalUpdate()
        member this.OnGUI() =
            GUILayout.BeginArea(new Rect(10.0f,10.0f,500.0f,500.0f))
            GUILayout.Label("Fsharp Mod OnGUI!") //Cannot Draw GUILayout.Window since idk how do i cast the window method to GUI.WindowFunction
            if GUILayout.Button("Fsharp Button!") then
                printfn("Button Clicked") //Changed From Debug.Log since idk how to cast string to il2cpp object in FSharp
            GUILayout.EndArea()
        member private this.NormalStart() =
            printfn("MyMonoBehaviour Start") //Changed From Debug.Log since idk how to cast string to il2cpp object in FSharp
        
        member private this.NormalUpdate() =
            "dO sOMETHING!"
    end
