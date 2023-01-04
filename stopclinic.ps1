cls
Get-Job | select Id | Remove-Job
Start-sleep 1
cls
write-host "All of the programs has been killed, thank you for using my application"
