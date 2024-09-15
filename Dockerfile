# Usar la imagen base de .NET SDK
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Establecer el directorio de trabajo
WORKDIR /app

# Copiar el archivo de solución y el archivo del proyecto
COPY Linkup_ms.sln ./
COPY Linkup_ms.csproj ./

# Restaurar las dependencias del proyecto
RUN dotnet restore Linkup_ms.csproj

# Copiar el resto del código y construir el proyecto
COPY . ./
RUN dotnet publish Linkup_ms.csproj -c Release -o out

# Crear una imagen de runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

# Establecer el directorio de trabajo
WORKDIR /app

# Copiar los archivos compilados desde la etapa de build
COPY --from=build /app/out ./

# Establecer el punto de entrada de la aplicación
ENTRYPOINT ["dotnet", "Linkup_ms.dll"]
