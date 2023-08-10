# FSharp BepInEx Plugin Example

![GitHub License](https://img.shields.io/github/license/unreliablecode/BepInEx-Fsharp-Plugin)
![GitHub Stars](https://img.shields.io/github/stars/unreliablecode/BepInEx-Fsharp-Plugin)
![GitHub Issues](https://img.shields.io/github/issues/unreliablecode/BepInEx-Fsharp-Plugin)

An illustrative example demonstrating how to write BepInEx plugins using FSharp.

## Overview

This repository provides an example of creating BepInEx plugins using FSharp, a functional-first programming language. The example demonstrates the creation of a simple BepInEx plugin that utilizes FSharp to extend game functionality.

## Prerequisites

- [BepInEx](https://github.com/BepInEx/BepInEx)

## Getting Started

1. Clone the repository: `git clone https://github.com/unreliablecode/BepInEx-Fsharp-Plugin.git`
2. Build the solution or use the precompiled binaries.
3. Place the compiled `.dll` files in your BepInEx plugins folder.
4. Copy the `FSharp.Core.dll` from the `FSharpBepInExPlugin\bin\Debug\netstandard2.0` directory to your `BepInEx\core` folder.
5. Run the game and observe the behavior of the FSharp plugin.

## Plugin Details

### `MainClass`

The main plugin class, inheriting from `BepInEx.Unity.IL2CPP.BasePlugin()`. It demonstrates plugin initialization and the creation of a `MyMonoBehaviour` instance.

### `MyMonoBehaviour`

A simple `MonoBehaviour` demonstrating several features:

- Initialization and lifecycle methods such as `Initialize`, `Start`, `Update`, and `OnGUI`.
- Displaying UI elements using `GUILayout`.
- Handling button clicks.

## Limitations

This example serves as a starting point for writing BepInEx plugins in FSharp. Developers are encouraged to expand upon this foundation to create more advanced and feature-rich plugins.

## License

This project is licensed under the [MIT License](LICENSE).

## Support

For any questions or assistance, please [create an issue](https://github.com/unreliablecode/BepInEx-Fsharp-Plugin/issues) or contact us at [your-email@example.com](mailto:your-email@example.com).

---

**Note:** This example provides insight into the process of writing BepInEx plugins using FSharp. It may require adjustments or enhancements to fit specific project requirements. Developers are encouraged to explore and modify the code to suit their needs.
