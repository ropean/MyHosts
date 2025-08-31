# Build Scripts

This directory contains scripts to build and clean the MyHosts project.

## Scripts

### build.cmd

Builds the project in Release configuration (optimized for production).

**Usage:**

```cmd
scripts\build.cmd
```

**What it does:**

1. Restores NuGet packages
2. Builds the project in Release configuration
3. Reports success or failure

### clean.cmd

Cleans build artifacts for both Debug and Release configurations.

**Usage:**

```cmd
scripts\clean.cmd
```

**What it does:**

1. Runs MSBuild clean target for all configurations
2. Removes `bin\Debug` and `bin\Release` directories
3. Removes `obj\Debug` and `obj\Release` directories
4. Removes legacy `packages` directory (if exists)
5. Shows the cleaned project structure

## Requirements

- Windows with MSBuild installed
- .NET Framework 4.8
- Internet connection for NuGet package restore (first run)

## Dependencies

**No third-party libraries are used.** The project relies solely on the .NET Framework 4.8 and standard system assemblies for all functionality.

**Previously removed packages:**

- RestSharp (removed due to security vulnerabilities)
- Fody (removed to eliminate third-party dependencies)
- Costura.Fody (removed to eliminate third-party dependencies)

## Quick Start

To build the project:

```cmd
# From the project root directory
scripts\build.cmd
```

To clean and rebuild:

```cmd
scripts\clean.cmd
scripts\build.cmd
```

## Notes

- The build script will automatically restore NuGet packages on first run
- Both scripts provide clear output about what they're doing
- Error handling is included to help diagnose build issues
