 ```
 dotnet new console --name PhotoSharingApp
 ```



```
az login

az group create --name prac10RG --location francecentral

az storage account create `
  --resource-group prac10RG `
  --location francecentral `
  --sku Standard_LRS `
  --name prac10bmvb
```

```
dotnet add package Azure.Storage.Blobs
```



```
dotnet add package Microsoft.Extensions.Configuration.Json
```









```
prac10bmvb
prac10bmvb.core.windows.net

https://prac10bmvb.blob.core.windows.net/mycontainer?restype=container&comp=list

https://prac10bmvb.blob.core.windows.net/?comp=list

GET https://[url-for-service-account]/?comp=list&include=metadata

GET https://prac10bmvb.core.windows.net/?comp=list&include=metadata

```

