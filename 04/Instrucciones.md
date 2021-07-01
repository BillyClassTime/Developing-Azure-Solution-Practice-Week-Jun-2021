Llamada con clave a la función


```
https://prac03funcbmvb.azurewebsites.net/api/TriggerHTTP?code=xgf5nUd1H4oqVMn11qKDteKiBraCC5/xasv5pHFzQ9w4aiNlEk3b8w==
```


Llamada anónima


```
https://prac03funcbmvb.azurewebsites.net/api/TriggerHTTP
```

Llamada a la funcion con clave y con el parametro name

```
https://prac03funcbmvb.azurewebsites.net/api/TriggerHTTP?code=xgf5nUd1H4oqVMn11qKDteKiBraCC5/xasv5pHFzQ9w4aiNlEk3b8w==&name=Billy
```



El Req(uest) de la llamada HTTP POST o por GET 

```
code=xgf5nUd1H4oqVMn11qKDteKiBraCC5/xasv5pHFzQ9w4aiNlEk3b8w==
&
city=Madrid
```

Cadena de conexión en los settings de la función:

```
azcosbmvb03_DOCUMENTDB
```



```
$RESOURCEGROUP="grupoRGprac04moda"
az group create --name $RESOURCEGROUP --location francecentral
$STORAGEACCT="caprac04moda"
$FUNCTIONAPP="funcprac04modoa"
az storage account create --resource-group $RESOURCEGROUP `
  --name $STORAGEACCT `
  --kind StorageV2 `
  --location francecentral
az functionapp create `
  --resource-group $RESOURCEGROUP `
  --name $FUNCTIONAPP `
  --storage-account $STORAGEACCT `
  --runtime node `
  --consumption-plan-location francecentral `
  --functions-version 2 
  
  
func azure functionapp publish   $FUNCTIONAPP
```

