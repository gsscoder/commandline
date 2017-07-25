@echo off

cls

.paket\paket.bootstrapper.exe
if errorlevel 1 (
  exit /b %errorlevel%
)

.paket\paket.exe restore
if errorlevel 1 (
  exit /b %errorlevel%
)

.\packages\FAKE\tools\Fake %*

dotnet restore
dotnet build --configuration Release --output .\build\netstandard1.5 --framework netstandard1.5 src\commandline
dotnet build --configuration Release --output .\build\netstandard2.0 --framework netstandard2.0 src\commandline\commandline.netstandard.csproj
