# WEBSITES
***API para obtener websites con .NET Core***

###### By: Fernando Ramirez
###### fernandoram901@gmail.com

### Tecnologías
- **.NET Core 8**


### Ejecución

Por favor utilizar `dotnet run` para ejecutar el proyecto.

### Endpoint

| Método | Endpoint | Descripción |
|--------|----------|-------------|
| **GET**|`/api/websites`| *El endpoint muestra una lista de sitios disponibles para consumir* |


### Respuesta
```json
{
  [
  	{
  		"id": 1,
  		"title": "OpenTec",
  		"url": "https://opentec.com"
  	},
  	{
  		"id": 2,
  		"title": "Google",
  		"url": "https://www.google.com.mx"
  	},
  	{
  		"id": 3,
  		"title": "Wikipedia",
  		"url": "https://www.wikipedia.org"
  	}
  ]
}
```
