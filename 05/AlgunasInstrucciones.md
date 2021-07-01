 ```
 https://productfunctionbmvb2021.azurewebsites.net/api/productdetails
 ```



```
https://productfunction.azure-api.net/products/ProductDetails
```



```
https://productfunction.azure-api.net
```

```
$GATEWAY_URL="https://productfunction.azure-api.net"
$SUB_KEY="16309f63a81e4b4babe11986fecc0c72"
echo "$GATEWAY_URL/products/ProductDetails?id=2"
curl -X GET "$GATEWAY_URL/products/ProductDetails?id=2" -H "Ocp-Apim-Subscription-Key: $SUB_KEY"
```

