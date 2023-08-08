open BepInEx
open UnityEngine

[<BepInPlugin("unreliablecode", "Mono", "1.0.0")>]
type MainClass() =
    inherit BaseUnityPlugin()

    override this.Load() =
        let newObject = GameObject("MyGameObject")
        Object.DontDestroyOnLoad(newObject)
        newObject.hideFlags <- HideFlags.HideAndDontSave

        UnityEngine.Debug.Log("Plugin loaded and GameObject created!")
