<Project Sdk="Microsoft.NET.Sdk.WindowsDesktop">
  <PropertyGroup>
    <AssemblyName>NaInSec Virus</AssemblyName>
    <GenerateAssemblyInfo>False</GenerateAssemblyInfo>
    <OutputType>WinExe</OutputType>
    <UseWindowsForms>True</UseWindowsForms>
    <TargetFramework>net45</TargetFramework>
    <Prefer32Bit>True</Prefer32Bit>
  </PropertyGroup>
  <PropertyGroup>
    <LangVersion>11.0</LangVersion>
    <AllowUnsafeBlocks>True</AllowUnsafeBlocks>
  </PropertyGroup>
  <PropertyGroup>
    <ApplicationIcon>app.ico</ApplicationIcon>
    <ApplicationManifest>app.manifest</ApplicationManifest>
    <RootNamespace />
  </PropertyGroup>
  <ItemGroup />
  <ItemGroup>
    <Reference Include="Microsoft.VisualBasic" />
    <Reference Include="System.Xml.Linq">
      <HintPath>../../../../usr/share/dotnet/shared/Microsoft.NETCore.App/6.0.25/System.Xml.Linq.dll</HintPath>
    </Reference>
    <Reference Include="System.Core">
      <HintPath>../../../../usr/share/dotnet/shared/Microsoft.NETCore.App/6.0.25/System.Core.dll</HintPath>
    </Reference>
  </ItemGroup>
</Project>