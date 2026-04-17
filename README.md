# Absolute Perfection
Can you beat every ULTRAKILL level without getting hurt once?

# Development
## Dependencies
This mod depends on the following packages:
- Configgy, `BepInEx/plugins/Configgy.dll`
- AUU, `BepInEx/plugins/AUU.dll`

## Using a custom ULTRAKILL path?
If you're using a custom ULTRAKILL path, for example to preserve hard drive space on your OS partition, or for other reasons, ULTRAPORTAL will not compile out of the box.
You need to create a file in the project root directory called `ULTRAKILLPATH.user`, where you can specify your custom game path like this:
```
<Project>
  <PropertyGroup>
    <ULTRAKILLPath>INSERT THE PATH TO THE DIRECTORY CONTAINING ULTRAKILL.exe/</ULTRAKILLPath>
  </PropertyGroup>
</Project>
```

Keep in mind that the path needs to be to the directory that contains your ULTRAKILL executable file. For example `D:/Steam/steamapps/common/ULTRAKILL`.
