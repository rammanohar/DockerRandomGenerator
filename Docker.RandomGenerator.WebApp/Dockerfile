#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Docker.RandomGenerator.WebApp/Docker.RandomGenerator.WebApp.csproj", "Docker.RandomGenerator.WebApp/"]
RUN dotnet restore "Docker.RandomGenerator.WebApp/Docker.RandomGenerator.WebApp.csproj"
COPY . .
WORKDIR "/src/Docker.RandomGenerator.WebApp"
RUN dotnet build "Docker.RandomGenerator.WebApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Docker.RandomGenerator.WebApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Docker.RandomGenerator.WebApp.dll"]