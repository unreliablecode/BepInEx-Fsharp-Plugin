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
        newObject.hideFlags <- HideFlags.HideAndDontSave
        ClassInjector.RegisterTypeInIl2Cpp<MyMonoBehaviour>()
        let myMonoBehaviour = newObject.AddComponent<MyMonoBehaviour>()
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

        member private this.NormalStart() =
            printfn("MyMonoBehaviour Start") //Changed From Debug.Log since idk how to cast string to il2cpp object in FSharp
        member private this.NormalUpdate() =
                printfn("MyMonoBehaviour Update") //Changed From Debug.Log since idk how to cast string to il2cpp object in FSharp
    end
