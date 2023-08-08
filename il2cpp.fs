open BepInEx
open UnityEngine

[<BepInPlugin("unreliablecode", "IL2CPP", "1.0.0")>]
type MainClass() =
    inherit BasePlugin()

    override this.Load() =
        let newObject = GameObject("MyGameObject")
        Object.DontDestroyOnLoad(newObject)
        newObject.hideFlags <- HideFlags.HideAndDontSave

        UnityEngine.Debug.Log("Plugin loaded and GameObject created!")
