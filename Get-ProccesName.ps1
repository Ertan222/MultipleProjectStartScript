$_match=$Args[0].ToLowerInvariant()
Get-Process | where {$_.Description -ne $null -and $_.Description.ToLowerInvariant().Contains($_match)} | select Path, Description, ProcessName
