FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Copiar csproj y restaurar dependencias
COPY Backend_Riwi_LinkUp/*.csproj ./
RUN dotnet restore

# Copiar todo y compilar
COPY Backend_Riwi_LinkUp/. ./
RUN dotnet publish -c Release -o out

# Construir imagen de tiempo de ejecución
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "Backend_Riwi_LinkUp.dll"]