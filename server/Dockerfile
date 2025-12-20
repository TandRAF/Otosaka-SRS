# --- STAGE 1: Build & Generate SQL ---
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy everything from the 'server' folder
COPY . .

# 1. Restore dependencies
RUN dotnet restore "server.csproj"

# 2. Install Entity Framework Tools inside the build container
# We use --tool-path so we know exactly where the 'dotnet-ef' binary is
RUN dotnet tool install --global dotnet-ef --version 8.0.11
ENV PATH="$PATH:/root/.dotnet/tools"

# 3. Generate the SQL script
# This creates the file 'init_db.sql' inside the build container
RUN dotnet ef migrations script -o /app/init_db.sql --project "server.csproj"

# 4. Publish the application
RUN dotnet publish "server.csproj" -c Release -o /app/publish

# --- STAGE 2: Final Runtime ---
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Copy the published app
COPY --from=build /app/publish .

# Copy the generated SQL script into the runtime image 
# (This is useful if you want to verify it or move it later)
COPY --from=build /app/init_db.sql .

ENTRYPOINT ["dotnet", "server.dll"]