#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY *.sln .
COPY ["CleanHouse.Api/CleanHouse.Api.csproj", "CleanHouse.Api/"]
COPY ["CleanHouse.PersistancyLayer/CleanHouse.PersistancyLayer.csproj", "CleanHouse.PersistancyLayer/"]
RUN dotnet restore
COPY ["CleanHouse.Api/.", "./CleanHouse.Api/"]
COPY ["CleanHouse.PersistancyLayer/.", "./CleanHouse.PersistancyLayer/"]
WORKDIR "/src/CleanHouse.Api"
RUN dotnet publish "CleanHouse.Api.csproj" -c Release -o /app /p:UseAppHost=false --no-restore

FROM base AS final
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "CleanHouse.Api.dll"]