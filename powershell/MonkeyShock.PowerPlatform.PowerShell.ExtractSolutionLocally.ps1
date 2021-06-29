Import-Module Microsoft.Xrm.Data.Powershell

Write-Output "setting valid TLS version..."
[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12

$solution1Name = "MonkeyShock"
$solution1FileName = "MonkeyShock.zip"
$exportLocation = "..\solutions"

Write-Output "Creating solution folder if not exists..."
If(!(test-path $exportLocation))
{
       New-Item -ItemType Directory -Force -Path $exportLocation
 }

Write-Output "exporting customization file..."

$connection = Get-CrmConnection -InteractiveMode -MaxCrmConnectionTimeOutMinutes 60

Export-CrmSolution -SolutionName $solution1Name -SolutionFilePath $exportLocation -SolutionZipFileName $solution1FileName -conn $connection

Write-Output "Extracting customization file and removing downloaded zip archive..."
..\tools\SDK_9_1\Tools\CoreTools\SolutionPackager.exe `
/action:extract `
/folder:$exportLocation\$solution1Name\src  `
/zipfile:$exportLocation\$solution1FileName `
/allowdelete:yes `
/map: ..\src\MonkeyShock.PowerPlatform\Infrastructure\Resources\solution-map.xml 

Write-output "extraction process completed."

Write-Output "Deleting solution's file..."
Remove-Item $exportLocation\$solution1FileName
Write-Output "Operation completed."



