# GitHub Release Workflow

This workflow automatically builds and releases the MyHosts application when you create a new version tag. It automatically wires the tag name into the application version and uses your existing `build.cmd` script.

## How to Use

### 1. Create a New Release

To create a new release, simply create and push a new tag:

```bash
git tag v1.0.0
git push origin v1.0.0
```

The workflow will automatically:

- Extract the version from the tag name (e.g., `v1.0.0` → `1.0.0`)
- Update `AssemblyInfo.cs` with the new version number
- Build the project using your existing `build.cmd` script
- Create a GitHub release with only the `MyHosts.exe` file
- Generate release notes from your commits

### 2. Manual Release

You can also trigger a release manually:

1. Go to the "Actions" tab in your GitHub repository
2. Select "Build and Release" workflow
3. Click "Run workflow"

### 3. Release Assets

The workflow will only include the compiled `MyHosts.exe` file in the release, keeping the release package clean and focused.

## Version Management

- **Tag Format**: Use semantic versioning (e.g., `v1.0.0`, `v2.1.3`)
- **Automatic Versioning**: The tag version is automatically injected into `AssemblyInfo.cs`
- **Assembly Version**: Both `AssemblyVersion` and `AssemblyFileVersion` are updated
- **Version Format**: Tag `v1.0.0` becomes assembly version `1.0.0.0`

## Workflow Details

- **Trigger**: Pushes to tags matching `v*` pattern or manual dispatch
- **Platform**: Windows (required for .NET Framework builds)
- **Build**: Uses your existing `scripts/build.cmd` script
- **Output**: Only the executable file is included in the release
- **Version Sync**: Automatically syncs GitHub tag with assembly version

## Local Build

The `build.cmd` script works from both locations:

- **Root directory**: `scripts\build.cmd`
- **Scripts directory**: `build.cmd`

## Requirements

- Your repository must have the `GITHUB_TOKEN` secret available (this is automatic for public repos)
- The workflow requires access to MSBuild and NuGet for building .NET Framework projects
- Your `build.cmd` script must be in the `scripts/` directory
