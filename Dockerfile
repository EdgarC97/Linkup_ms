# Use the .NET SDK base image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set the working directory
WORKDIR /app

# Copy the solution file and project file
COPY Linkup_ms.sln ./
COPY Linkup_ms.csproj ./

# Restore the project dependencies
RUN dotnet restore Linkup_ms.csproj

# Copy the rest of the code and build the project
COPY . ./
RUN dotnet publish Linkup_ms.csproj -c Release -o out

# Create a runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

# Set the working directory
WORKDIR /app

# Copy the compiled files from the build stage
COPY --from=build /app/out ./

# Set the entry point for the application
ENTRYPOINT ["dotnet", "Linkup_ms.dll"]
