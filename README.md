# API de Acceso por QR

## Descripción
Esta API está diseñada para integrarse con una aplicación en .NET MAUI que gestiona el acceso a eventos mediante códigos QR. Permite obtener información de los asistentes a través de consultas a una base de datos MySQL.

## Tecnologías Utilizadas
- **.NET Core 8**
- **MySQL**
- **Swagger** (Para documentación de la API)

## Requisitos Previos
Antes de ejecutar la API, asegúrate de contar con lo siguiente:
- **.NET SDK 8** instalado.
- **Servidor MySQL** en ejecución.
- Configuración de conexión en `appsettings.json` con la IP del servidor, usuario y contraseña.

## Instalación y Configuración

1. **Clonar el repositorio**
   ```bash
   git clone https://github.com/tuusuario/nombre-del-repositorio.git
   cd nombre-del-repositorio
   ```

2. **Configurar la conexión a la base de datos**
   Edita el archivo `appsettings.json` y actualiza los siguientes valores:
   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Server=TU_IP;Database=TU_BASE_DE_DATOS;User=TU_USUARIO;Password=TU_CONTRASEÑA;"
   }
   ```

3. **Ejecutar la API**
   ```bash
   dotnet run
   ```

## Endpoints Principales

| Método | Endpoint          | Descripción                        |
|--------|------------------|------------------------------------|
| GET    | `/api/usuarios`  | Obtiene la lista de todos los usuarios |
| GET    | `/api/usuarios/{id}` | Obtiene un usuario por ID basado en el QR |

### Ejemplo de Uso
#### 1. Obtener todos los usuarios
```bash
GET http://localhost:5000/api/usuarios
```
#### 2. Obtener un usuario por ID (Código QR)
```bash
GET http://localhost:5000/api/usuarios/12345
```

Ejemplo de respuesta:
```json
{
  "id": 12345,
  "nombre": "Juan Pérez",
  "evento": "Tech Conference 2025",
  "estatus": "Autorizado"
}
```

## Uso con Swagger
Una vez que la API esté en ejecución, puedes acceder a la documentación interactiva en:
```
http://localhost:5000/swagger
```
Desde ahí puedes probar los endpoints de manera sencilla.

## Posibles Mejoras
- Implementar **JWT** para autenticación.
- Agregar **registro de accesos** para auditoría.
- Optimizar consultas a la base de datos con **Dapper o Entity Framework**.

## Contribuciones
Si deseas contribuir, siéntete libre de hacer un *fork* del proyecto y enviar un *pull request*.

---
💡 *Desarrollado para facilitar el acceso seguro a eventos mediante tecnología QR.* 🚀

