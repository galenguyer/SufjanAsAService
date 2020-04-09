#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 10283

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["SufjanAsAService/SufjanAsAService.csproj", "SufjanAsAService/"]
RUN dotnet restore "SufjanAsAService/SufjanAsAService.csproj"
COPY . .
WORKDIR "/src/SufjanAsAService"
RUN dotnet build "SufjanAsAService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SufjanAsAService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SufjanAsAService.dll"]