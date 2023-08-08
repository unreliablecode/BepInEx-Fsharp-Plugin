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

        UnityEngine.Debug.Log("Plugin loaded, GameObject created, and MyMonoBehaviour added!")

and MyMonoBehaviour() =
    class
        inherit UnityEngine.MonoBehaviour()
        let mutable TimeDown = 5f
        member this.Initialize() =
            UnityEngine.Debug.Log("MyMonoBehaviour initialized!")

        member this.Start() =
            this.NormalStart()

        member this.Update() =
            this.NormalUpdate()

        member private this.NormalStart() =
            UnityEngine.Debug.Log("MyMonoBehaviour Start")
        member private this.NormalUpdate() =
            TimeDown <- TimeDown - Time.deltaTime
            if TimeDown < 0.0f then
                UnityEngine.Debug.Log("MyMonoBehaviour Update")
    end
