 ```
 az storage account create --name staprac14 -g prac14RG --kind StorageV2 --sku Premium_LRS
 ```

```
az storage account create --name staprac14bmvb -g prac14RG --kind StorageV2 --sku Standard_LRS
```



```
az storage account keys list --account-name staprac14bmvb
```

Resultado del comando anterior:

```
[
  {
    "keyName": "key1",
    "permissions": "FULL",
    "value": "m09a9uJXVIw/ggEA3kdk8ZXLGCAT43GDZnUE8u5yGCT6OWRBLXMnGQ4fiJARJOPpFEyAdLCA9qYlb/7R6Wd1xA=="
  },
  {
    "keyName": "key2",
    "permissions": "FULL",
    "value": "qRRFZ9q9bAREt14ub4VK25kb4arVRFB3J7/i2RAcfKCl4gq5NCEdPpdWBd+lSVGxUjSfNlP77niLUJ8cAH10Gg=="
  }
]
```

Accediendo a las colas de almacenamiento

```
http://<storage account>.queue.core.windows.net/<queue name>
```

```
http://staprac14bmvb.queue.core.windows.net/<queue name>
```



```
az storage account show-connection-string --name staprac14bmvb --resource-group prac14RG
```

Resultado

```
 "connectionString": "DefaultEndpointsProtocol=https;EndpointSuffix=core.windows.net;AccountName=staprac14bmvb;AccountKey=m09a9uJXVIw/ggEA3kdk8ZXLGCAT43GDZnUE8u5yGCT6OWRBLXMnGQ4fiJARJOPpFEyAdLCA9qYlb/7R6Wd1xA=="
```

Recuperada desde el portal:

```
DefaultEndpointsProtocol=https;AccountName=staprac14bmvb;AccountKey=qRRFZ9q9bAREt14ub4VK25kb4arVRFB3J7/i2RAcfKCl4gq5NCEdPpdWBd+lSVGxUjSfNlP77niLUJ8cAH10Gg==;EndpointSuffix=core.windows.net
```

Recuperar mensajes de la cola desde Azure Cli

```
az storage message peek --queue-name newsqueue --connection-string "<connection-string>"

az storage message peek --queue-name newqueue --connection-string "DefaultEndpointsProtocol=https;EndpointSuffix=core.windows.net;AccountName=staprac14bmvb;AccountKey=m09a9uJXVIw/ggEA3kdk8ZXLGCAT43GDZnUE8u5yGCT6OWRBLXMnGQ4fiJARJOPpFEyAdLCA9qYlb/7R6Wd1xA=="
```

Borrar la cola de almacenamiento

```
az storage queue delete --name newsqueue --connection-string <connection-string>

az storage queue delete --name newqueue --connection-string "DefaultEndpointsProtocol=https;EndpointSuffix=core.windows.net;AccountName=staprac14bmvb;AccountKey=m09a9uJXVIw/ggEA3kdk8ZXLGCAT43GDZnUE8u5yGCT6OWRBLXMnGQ4fiJARJOPpFEyAdLCA9qYlb/7R6Wd1xA=="

```

