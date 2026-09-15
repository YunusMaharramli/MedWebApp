@RTK.md

# RTK in this Windows project

RTK is installed locally at `.tools/rtk.exe`. From the project root, prefix
development CLI commands with `./rtk.ps1` in PowerShell, for example:

```powershell
./rtk.ps1 git status
./rtk.ps1 dotnet build WebMedApp.slnx
./rtk.ps1 gain
```

The wrapper stores RTK history under `.rtk/state/` and disables telemetry.
It is the project-local equivalent of the `rtk` prefix described in RTK.md.
On native Windows, Codex must call it explicitly; there is no automatic
command rewrite. Do not initialize RTK globally for this project.
