@echo off
setlocal enabledelayedexpansion
echo ========================================
echo MyHosts Build Script (Release Mode)
echo ========================================

REM Auto-detect the correct path
if exist "MyHosts\MyHosts.csproj" (
    set PROJECT_FILE=MyHosts\MyHosts.csproj
) else if exist "..\MyHosts\MyHosts.csproj" (
    set PROJECT_FILE=..\MyHosts\MyHosts.csproj
) else (
    echo ERROR: Cannot find MyHosts.csproj
    echo Please run this script from the root directory or scripts directory
    exit /b 1
)

echo Using project file: %PROJECT_FILE%

rem Determine version from latest Git tag (fallback to 1.0.0)
set GIT_TAG=
where git >nul 2>nul
if %errorlevel% equ 0 (
  for /f "usebackq delims=" %%t in (`git describe --tags --abbrev=0 2^>nul`) do set GIT_TAG=%%t
)
if not defined GIT_TAG set GIT_TAG=1.0.0

echo Using version: %GIT_TAG%

echo Restoring NuGet packages...
msbuild "%PROJECT_FILE%" /t:Restore /verbosity:quiet
if %errorlevel% neq 0 (
    echo ERROR: Failed to restore NuGet packages
    goto :error
)

echo.
echo Building Release configuration...
msbuild "%PROJECT_FILE%" /p:Configuration=Release /p:AssemblyVersion=%GIT_TAG% /p:FileVersion=%GIT_TAG% /p:InformationalVersion=%GIT_TAG% /verbosity:minimal
if %errorlevel% neq 0 (
    echo ERROR: Build failed for Release configuration
    goto :error
)

echo Release build completed successfully

echo.
echo ========================================
echo Build completed successfully!
echo ========================================
goto :end

:error
echo.
echo ========================================
echo Build failed with errors!
echo ========================================
exit /b 1

:end
