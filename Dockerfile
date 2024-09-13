FROM mcr.microsoft.com/dotnet/sdk:8.0
WORKDIR /app

COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o out

ENV ASPNETCORE_URLS=http://+:8080

ENTRYPOINT ["dotnet", "out/Backend_Riwi_LinkUp.dll"]