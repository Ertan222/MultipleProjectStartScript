$command = 'Start-Process -NoNewWindow powershell {dotnet run --project APIConsumeTry/APIConsumeTry.csproj} -PassThru | select Id > start.pid'
$command2 = 'Start-Process -NoNewWindow {dotnet run --project CitiesConsumingAPI/CitiesConsumingAPI.csproj} -PassThru | select Id > start.pid'

$scriptblock = [Scriptblock]::Create($command)
Start-Job -ScriptBlock $scriptblock

$scriptblock2 = [Scriptblock]::Create($command2)
Start-Job -ScriptBlock $scriptblock2

