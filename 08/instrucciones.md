 ```
 https://docs.microsoft.com/es-es/learn/modules/develop-app-that-queries-azure-sql/3-exercise-create-tables-bulk-import-query-data
 
 
 ```



```
https://docs.microsoft.com/en-us/learn/modules/develop-app-that-queries-azure-sql/2-create-tables-bulk-import-query-data
```

```
https://github.com/BillyClassTime/Developing-Azure-Solution-Practice-Week-Jun-2021/blob/master/Developing%20Azure%20Solutions%20Practice%20Week%20Jun%202021.md
```

```
bcp "$DATABASE_NAME.dbo.courses" format nul -c -f courses.fmt -t "," -S "$DATABASE_SERVER.database.windows.net" -U $AZURE_USER -P $AZURE_PASSWORD
```

power shell

```
$DATABASE_NAME="pract07bmvb" 
$DATABASE_SERVER="courserver001.database.windows.net"
$AZURE_USER="azuresql"
$AZURE_PASSWORD="P455w0rd.1234"
```

```
export DATABASE_NAME="pract07bmvb" 
export DATABASE_SERVER="courserver001.database.windows.net"
export AZURE_USER="azuresql"
export AZURE_PASSWORD="P455w0rd.1234"
```





```
bcp "[$DATABASE_NAME].[dbo].[courses]" in courses.csv -f courses.fmt -S "$DATABASE_SERVER.database.windows.net" -U $AZURE_USER -P $AZURE_PASSWORD -F 2
```



Conectando ASP:NET WEB application con AZURE SQL

1 - Libreria *System.Data.SqlClient* (NUGET)

2 - Cadena de conexión

```
Server=tcp:courserver001.database.windows.net,1433;Initial Catalog=pract07bmvb;Persist Security Info=False;User ID=azuresql;Password=P455w0rd.1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;
```

3 - Implementar programaticamente libreria y cadena de conexión

Despliegue de la aplicacion en Azure

1 - Creación de un AppService y App ServicePlan F1

```
WEBAPPNAME=educationapp[name]
az webapp up \
    --resource-group learn-498eff68-57ca-4cc1-9ab2-b3dc4e0acb63 \
    --location centralus \
    --sku F1 \
    --name $WEBAPPNAME
```

```
$WEBAPPNAME="educationappbmvb"
az webapp up `
    --resource-group learn-498eff68-57ca-4cc1-9ab2-b3dc4e0acb63 `
    --location westus `
    --sku F1 `
    --name $WEBAPPNAME
```

































