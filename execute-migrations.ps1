$infrastructurePath = ".\ScrumFlush.Infrastructure\"
$apiPath = "..\ScrumFlush.Api"

try {
    Set-Location $infrastructurePath
    dotnet ef database update --context SqlContext --startup-project $apiPath
    Write-Host "Database migration applied successfully."
} catch {
    Write-Error "Failed to update the database. Error: $_"
} finally {
    Set-Location -Path ".."
}