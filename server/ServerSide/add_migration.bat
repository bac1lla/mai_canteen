@echo off
for /f "tokens=1-6 delims=-" %%a in ('PowerShell -Command "& {Get-Date -format "yyyy-MM-dd-HH-mm-ss"}"') do (
    dotnet ef migrations add "%a/%b/%c %d:%e:%f" --context DataContext
    dotnet ef migrations add "%a/%b/%c %d:%e:%f" --context ArchiveDataContext
)

dotnet ef database update --context DataContext
dotnet ef database update --context ArchiveDataContext
