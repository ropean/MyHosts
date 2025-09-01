@echo off
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

echo Restoring NuGet packages...
msbuild "%PROJECT_FILE%" /t:Restore /verbosity:quiet
if %errorlevel% neq 0 (
    echo ERROR: Failed to restore NuGet packages
    goto :error
)

echo.
echo Building Release configuration...
msbuild "%PROJECT_FILE%" /p:Configuration=Release /verbosity:minimal
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
