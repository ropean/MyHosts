# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased] - 2025-08-31

### Added

- MIT License (`LICENSE` file)
- Comprehensive build scripts (`scripts/build.cmd`, `scripts/clean.cmd`)
- Detailed project documentation (`README.md`, `scripts/README.md`)
- Project structure documentation

### Removed

- RestSharp package (due to security vulnerabilities)
- Fody and Costura.Fody packages (to eliminate third-party dependencies)
- packages.config (migrated to PackageReference format)
- FodyWeavers.xml configuration file

### Security

- Removed vulnerable RestSharp dependency
- Eliminated all third-party library dependencies
- Project now uses only .NET Framework 4.8 standard libraries

## [1.0.0] - 2024-12-XX

### Added

- Initial release of MyHosts application
- Windows Forms interface for hosts file management
- Add, edit, and remove host entries
- Backup and restore functionality
- Search and filter capabilities
- Administrator privilege handling
- Real-time hosts file editing with syntax validation

### Technical

- Built with .NET Framework 4.8
- C# Windows Forms application
- Target architecture: AnyCPU
- Release and Debug build configurations

---

## Types of changes

- `Added` for new features
- `Changed` for changes in existing functionality
- `Deprecated` for soon-to-be removed features
- `Removed` for now removed features
- `Fixed` for any bug fixes
- `Security` in case of vulnerabilities

## Version History Notes

### Migration to PackageReference

- Migrated from legacy packages.config to modern PackageReference format
- Improved build performance and dependency management
- Better Visual Studio integration

### Security Hardening

- Complete removal of third-party dependencies
- Pure .NET Framework implementation
- Reduced attack surface
- Enhanced supply chain security

### Build System Improvements

- Added dedicated build and clean scripts
- Optimized for Release mode builds
- Cross-platform script compatibility
- Automated cleanup of build artifacts

---

**Note**: This changelog reflects the evolution of the MyHosts project from its initial state through security hardening and modernization efforts.
