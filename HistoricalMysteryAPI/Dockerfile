FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["HistoricalMysteryAPI/HistoricalMysteryAPI.csproj", "HistoricalMysteryAPI/"]
RUN dotnet restore "HistoricalMysteryAPI/HistoricalMysteryAPI.csproj"
COPY . .
WORKDIR "/src/HistoricalMysteryAPI"
RUN dotnet build "HistoricalMysteryAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "HistoricalMysteryAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "HistoricalMysteryAPI.dll"]