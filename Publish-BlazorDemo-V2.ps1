#cd into the IIS director
#cd C:\IIS

# stop the website
Stop-WebSite -Name "blazordemo"

#pause the script for a few seconds to allow the site to stop
Start-Sleep -Seconds 5

#now we need to delete the existing folder if it exists
IF (Test-Path C:\IIS\BlazorDemo) 
{
	#recursively delete
   Remove-Item -Recurse -Force C:\IIS\BlazorDemo
	#Write-Host 'the folder exists'
}

#recursively copy the folder from the WebDeploy folder to the IIS folder
$sourceRoot = "C:\Users\macivoce\Documents\WebDeploy\LocalPackages\BlazorDemo"
$destinationRoot = "C:\IIS\BlazorDemo"

Copy-Item -Path $sourceRoot -Recurse -Destination $destinationRoot -Container


#restart the website
Start-Website -Name "blazordemo"