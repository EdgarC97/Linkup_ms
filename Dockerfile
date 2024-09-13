# Etapa de compilación
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /src

# Copiar csproj y restaurar dependencias
COPY *.sln .
COPY Backend_Riwi_LinkUp/*.csproj ./Backend_Riwi_LinkUp/
RUN dotnet restore

# Copiar todo y construir
COPY Backend_Riwi_LinkUp/. ./Backend_Riwi_LinkUp/
WORKDIR /src/Backend_Riwi_LinkUp
RUN dotnet publish -c Release -o /app/publish

# Etapa de ejecución
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/publish .
ENTRYPOINT ["dotnet", "Backend_Riwi_LinkUp.dll"]