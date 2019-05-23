<#
  This script deploys a package in the development-only user profile source to a remote development web server.
  Deployment Config is created here without reference to a CSV file. This is only allowed for dev web sites.
  Application parameters are still referenced from the source-controlled location, so get latest as needed from TFS. 
  
  The application deployed here is: 
  
  Name: CORLibraryDebtSetOff
  Team: Services 
#>

#Requires –Modules CorDeploy

$applicationName = "BlazorDemo"
$site = "starappdev"
$appPool = "starapp_CommunityServices_4.0"
$DevParamFile = "Parameters\Development\CommunityServices\BlazorDemo.xml"

Import-Module CorDeploy

New-CorDeploymentConfig $applicationName (Join-Path $WebDeployRoot $DevParamFile) $site $appPool | Publish-CorWebApp -UseDevPackageSource