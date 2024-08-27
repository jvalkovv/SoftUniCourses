# Use the .NET Core SDK image for building the app
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS builder

# Create a working directory
WORKDIR /Worker

# Copy the .csproj file and restore dependencies
COPY src/Worker/Worker.csproj .
RUN dotnet restore

# Copy all the source files to the image
COPY src/Worker/ .

# Build the project
RUN dotnet publish -c Release -o /out Worker.csproj

# Use the .NET Core runtime image for running the app
FROM mcr.microsoft.com/dotnet/core/runtime:3.1

# Specify working directory for the runtime image
WORKDIR /app

# Specify the command to run when the container starts
ENTRYPOINT ["dotnet", "Worker.dll"]

# Copy the /out directory from the build stage into the runtime image
COPY --from=builder /out .

