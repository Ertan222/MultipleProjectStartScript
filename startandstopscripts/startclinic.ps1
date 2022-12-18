$command = 'Start-Process -NoNewWindow powershell {dotnet run --project APIConsumeTry/APIConsumeTry.csproj}'
$command2 = 'Start-Process -NoNewWindow powershell {dotnet run --project CitiesConsumingAPI/CitiesConsumingAPI.csproj}'

$scriptblock = [Scriptblock]::Create($command)
Start-Job -ScriptBlock $scriptblock

$scriptblock2 = [Scriptblock]::Create($command2)
Start-Job -ScriptBlock $scriptblock2

