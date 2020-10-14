$projectName="bring-me-food-dev"
$resourceGroupName="bring-me-food-dev-rg"
$resourceGroupLocation = 'westeurope'
$templateFile="./arm/azuredeploy.json"
$templateParameterFile="./arm/azuredeploy.parameters.dev.json"
$deploymentName="create-environment"

# Initialization:
# ===============
#Connect-AzAccount
#Set-AzContext [SubscriptionID/SubscriptionName]

# Check if resource group already exists
$resourceGroupCount = Get-AzResourceGroup | Where { $_.ResourceGroupName -match $resourceGroupName } | Measure | Select Count
if ($resourceGroupCount.Count -eq 0) {
    # Resource group does not yet exist, create it
    New-AzResourceGroup -Name $resourceGroupName -Location $resourceGroupLocation -Verbose -Force -ErrorAction Stop
}

New-AzResourceGroupDeployment -ResourceGroupName $resourceGroupName -TemplateFile $templateFile -TemplateParameterFile $templateParameterFile -Name $deploymentName -ProjectName $projectName