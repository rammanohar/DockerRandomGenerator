#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Docker.RandomGenerator.Api/Docker.RandomGenerator.Api.csproj", "Docker.RandomGenerator.Api/"]
COPY ["Docker.RandomGenerator.Interface/Docker.RandomGenerator.Interface.csproj", "Docker.RandomGenerator.Interface/"]
COPY ["Docker.RandomGenerator.DataEntities/Docker.RandomGenerator.DataEntities.csproj", "Docker.RandomGenerator.DataEntities/"]
COPY ["Docker.RandomGenerator.Service/Docker.RandomGenerator.Service.csproj", "Docker.RandomGenerator.Service/"]
RUN dotnet restore "Docker.RandomGenerator.Api/Docker.RandomGenerator.Api.csproj"
COPY . .
WORKDIR "/src/Docker.RandomGenerator.Api"
RUN dotnet build "Docker.RandomGenerator.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Docker.RandomGenerator.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Docker.RandomGenerator.Api.dll"]