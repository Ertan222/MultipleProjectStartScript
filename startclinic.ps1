$command = 'Start-Process -NoNewWindow powershell {dotnet run --project APIConsumeTry/APIConsumeTry.csproj}'
$command2 = 'Start-Process -NoNewWindow {dotnet run --project CitiesConsumingAPI/CitiesConsumingAPI.csproj}'
$command2 = 'Start-Process -NoNewWindow {npm --prefix LocationsNodeAPI start}'

$scriptblock = [Scriptblock]::Create($command)
Start-Job -ScriptBlock $scriptblock

$scriptblock2 = [Scriptblock]::Create($command2)
Start-Job -ScriptBlock $scriptblock2

$scriptblock3 = [Scriptblock]::Create($command3)
Start-Job -ScriptBlock $scriptblock3
Start-Sleep 6
cls
Write-Host "ANIMALAPI is listening on https://localhost:7180/swagger/index.html if you want to test it" -ForegroundColor red -BackgroundColor black

Write-Host "SMILEYMEOW is listening on https://localhost:7041 if you want to test it" -ForegroundColor yellow -BackgroundColor black


Write-Host "LOCATIONSAPI is listening on https://localhost:3000 if you want to test it" -ForegroundColor green -BackgroundColor black

Write-host "Endpoints are for nodejs is:" -ForegroundColor green -BackgroundColor black
Write-host "/insertdistricts" -ForegroundColor green -BackgroundColor black
Write-host "/insertcities" -ForegroundColor green -BackgroundColor black
Write-host "/deletedistricts" -ForegroundColor green -BackgroundColor black
Write-host "/deletecities" -ForegroundColor green -BackgroundColor black
Write-host "/getalldistricts" -ForegroundColor green -BackgroundColor black
Write-host "/getlallcities" -ForegroundColor green -BackgroundColor black
Write-host "/getdistrict/id // id: cityId" -ForegroundColor green -BackgroundColor black

