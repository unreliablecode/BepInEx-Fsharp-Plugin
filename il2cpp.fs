namespace MyBepInPlugin

open BepInEx
open UnityEngine

[<BepInPlugin("unreliablecode.com", "MyPlugin", "1.0.0")>]
type MainClass() =
    inherit BepInEx.Unity.IL2CPP.BasePlugin()

    override this.Load() =
        let newObject = GameObject("MyGameObject")
        Object.DontDestroyOnLoad(newObject)
        newObject.hideFlags <- HideFlags.HideAndDontSave

        UnityEngine.Debug.Log("Plugin loaded and GameObject created!")
