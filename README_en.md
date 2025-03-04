# MegaSolarSail

Enhance the power of the solar sail, default to ten times the power, can be modified through the configuration `cn.tursom.MegaSolarSail.cfg`.

## Development

To ensure the project correctly references the relevant files of Dyson Sphere Program, developers need to configure the following:

1. Find the `DefaultPath.props.example` file in the root directory of the project.
2. Copy and rename the `DefaultPath.props.example` file to `DefaultPath.props`.
3. Open the `DefaultPath.props` file and manually modify the value of the `DysonSphereProgramPath` property to your local Dyson Sphere Program installation path. For example:

    ```xml
    <PropertyGroup>
      <DysonSphereProgramPath>D:\SteamLibrary\steamapps\common\Dyson Sphere Program\DSPGAME_Data\Managed</DysonSphereProgramPath>
    </PropertyGroup>
    ```

After completing the above steps, the project will be able to correctly reference the relevant files of Dyson Sphere Program.
