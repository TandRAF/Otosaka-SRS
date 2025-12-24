# --- STAGE 1: Build ---
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the project file and restore dependencies first (better for caching)
COPY ["server.csproj", "./"]
RUN dotnet restore "server.csproj"

# Copy the rest of the code
COPY . .

# Publish the application to /app/publish
RUN dotnet publish "server.csproj" -c Release -o /app/publish

# --- STAGE 2: Final Runtime ---
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Copy only the compiled app from the build stage
COPY --from=build /app/publish .

# Set the entry point to run your app
ENTRYPOINT ["dotnet", "server.dll"]