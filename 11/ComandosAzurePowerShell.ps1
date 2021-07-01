$filter = 'prac'
 
#Find Resource Groups by Filter -> Verify Selection
Get-AzResourceGroup | ? ResourceGroupName -match $filter | Select-Object ResourceGroupName

Get-AzResourceGroup | ? ResourceGroupName -match $filter | Remove-AzResourceGroup -AsJob -Force