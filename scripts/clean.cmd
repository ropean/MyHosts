@echo off
echo ========================================
echo MyHosts Clean Script ^(Debug ^& Release^)
echo ========================================

set PROJECT_FILE=MyHosts\MyHosts.csproj
set PROJECT_DIR=MyHosts

echo Cleaning build artifacts for both Debug and Release...

REM Clean using MSBuild for all configurations
echo Running MSBuild clean for all configurations...
msbuild "%PROJECT_FILE%" /t:Clean /verbosity:quiet
if %errorlevel% neq 0 (
    echo WARNING: MSBuild clean failed, continuing with manual cleanup...
)

REM Remove specific Debug and Release directories
if exist "%PROJECT_DIR%\bin\Debug" (
    echo Removing %PROJECT_DIR%\bin\Debug directory...
    rmdir /s /q "%PROJECT_DIR%\bin\Debug"
)

if exist "%PROJECT_DIR%\bin\Release" (
    echo Removing %PROJECT_DIR%\bin\Release directory...
    rmdir /s /q "%PROJECT_DIR%\bin\Release"
)

REM Remove entire bin directory if empty or if it contains other configs
if exist "%PROJECT_DIR%\bin" (
    dir /b "%PROJECT_DIR%\bin" 2>nul | findstr "." >nul
    if %errorlevel% neq 0 (
        echo Removing empty %PROJECT_DIR%\bin directory...
        rmdir "%PROJECT_DIR%\bin"
    ) else (
        echo Keeping %PROJECT_DIR%\bin directory (contains other configurations)
    )
)

REM Remove obj directories for both configurations
if exist "%PROJECT_DIR%\obj\Debug" (
    echo Removing %PROJECT_DIR%\obj\Debug directory...
    rmdir /s /q "%PROJECT_DIR%\obj\Debug"
)

if exist "%PROJECT_DIR%\obj\Release" (
    echo Removing %PROJECT_DIR%\obj\Release directory...
    rmdir /s /q "%PROJECT_DIR%\obj\Release"
)

REM Remove entire obj directory if empty
if exist "%PROJECT_DIR%\obj" (
    dir /b "%PROJECT_DIR%\obj" 2>nul | findstr "." >nul
    if %errorlevel% neq 0 (
        echo Removing empty %PROJECT_DIR%\obj directory...
        rmdir "%PROJECT_DIR%\obj"
    ) else (
        echo Keeping %PROJECT_DIR%\obj directory (contains other configurations)
    )
)

REM Also clean packages directory if it exists (legacy cleanup)
if exist "packages" (
    echo Removing packages directory...
    rmdir /s /q "packages"
)

echo.
echo ========================================
echo Clean completed successfully!
echo ========================================

REM Show current directory contents
echo.
echo Current project structure:
dir /b "%PROJECT_DIR%" | findstr /v "^$"
