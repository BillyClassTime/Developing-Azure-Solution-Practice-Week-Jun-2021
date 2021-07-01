 ### Punto de conexión
 ```
 salesteamappbmvb2021.servicebus.windows.net
 ```

### Clave de acceso

```
roG4Kp6/8CoreOmJudXmbTmB7gKQ7znUW/qboJ3BmcY=
```

### Connectioin String

```
Endpoint=sb://salesteamappbmvb2021.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=roG4Kp6/8CoreOmJudXmbTmB7gKQ7znUW/qboJ3BmcY=
```

```
Endpoint=sb://salesteamappbmvb2021.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=roG4Kp6/8CoreOmJudXmbTmB7gKQ7znUW/qboJ3BmcY=
```



Recuperacion Cadena de conexión Az Cli Bash

```
az servicebus namespace authorization-rule keys list \
    --resource-group prac13RG \
    --name RootManageSharedAccessKey \
    --query primaryConnectionString \
    --output tsv \
    --namespace-name salesteamappbmvb2021
```





Emisor

```csharp
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.ServiceBus;
```

```c#
queueClient = new QueueClient(TextAppConnectionString, "PrivateMessageQueue");
```

```c#
string message = "Sure would like a large pepperoni!";
var encodedMessage = new Message(Encoding.UTF8.GetBytes(message));
await queueClient.SendAsync(encodedMessage);
```



Receptor

```c#
queueClient.RegisterMessageHandler(MessageHandler, messageHandlerOptions);
```



```c#
await queueClient.CompleteAsync(message.SystemProperties.LockToken);
```



```
az servicebus queue show \
    --resource-group prac13RG \
    --name salesmessages \
    --query messageCount \
    --namespace-name salesteamappbmvb2021

```

```
az servicebus queue show `
    --resource-group prac13RG `
    --name salesmessages `
    --query messageCount `
    --namespace-name salesteamappbmvb2021
```

Consulta de Topics

```
az servicebus topic subscription show `
    --resource-group prac13RG  `
    --namespace-name salesteamappbmvb2021 `
    --topic-name salesperformancemessages  `
    --name Americas `
    --query messageCount
```

