# IKnowaGuyMorePlayers

A BepInEx mod for I Know a Guy that increases the maximum player count beyond the default 4-player limit.

## Features

- Configurable max player count (default: 8, up to 32)
- Host-only enforcement — only the host needs the mod for networking to work
- Patches both networking session limits and Steam lobby size
- Config file generated on first run for easy adjustment

## Requirements

- [BepInEx 6.0.0-be.755](https://bepinex.dev/) (Unity IL2CPP, win-x64)
- I Know a Guy (Steam)

## Installation

1. Install BepInEx
   1. Download `BepInEx-Unity.IL2CPP-win-x64-6.0.0-be.755+3fab71a.zip` from [BepInEx Bleeding Edge Builds](https://builds.bepinex.dev/projects/bepinex_be)
   2. Extract the ZIP into your I Know a Guy game folder (where `I Know a Guy.exe` is)
   3. **Linux/Steam Deck users:** Add this to the game's Steam Launch Options:
      ```
      WINEDLLOVERRIDES="winhttp=n,b" %command%
      ```
   4. Launch the game once and close it. This generates the required config and interop files.
   5. Edit `BepInEx/config/BepInEx.cfg` and set `UnityLogListening = false` under `[Logging]` (required for Unity 6 compatibility)

6. Install the Mod
   1. Download the `IKnowaGuyMorePlayers.dll` from this build
   2. Place it in `BepInEx/plugins/IKnowaGuyMorePlayers/` inside your game folder
   3. Launch the game

## Configuration

After the first launch with the mod installed, a config file is generated at:
```
BepInEx/config/com.github.IKnowaGuyMorePlayers.cfg
```

```ini
[General]

## The maximum number of players allowed in a lobby. Only applies when you are the host. Vanilla default is 4.
## Acceptable value range: From 2 to 32
MaxPlayers = 8
```

Change `MaxPlayers` to your desired value and relaunch the game.

## How It Works

The mod uses HarmonyX to patch two methods at runtime:

1. **`NetworkController.HostLobby`** — Overrides the player count when hosting
2. **`SteamMatchmaking.CreateLobby`** — Overrides the `cMaxMembers` parameter when the host creates a Steam lobby

Both patches only apply when you are the host. Clients joining your lobby do not need the mod installed (though it's recommended for the best experience).

## Building from Source

### Requirements

- .NET 6.0 SDK
- BepInEx installed in the game directory (for interop assembly references)

### Build

```bash
dotnet build
```

The output DLL is automatically copied to `BepInEx/plugins/IKnowaGuyMorePlayers/` after building.

## Known Limitations

- High player counts (>16) may cause instability with voice chat, UI, or game logic
- The game's lobby UI may not display more than 4 player slots
- The game may have exactly 4 spawn points — extra players might spawn in unexpected locations
- Game updates may break the mod if the developer changes method signatures