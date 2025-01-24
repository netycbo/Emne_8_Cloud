# Etap budowy
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /source

# Kopiujemy pliki projektu i przywracamy zależności
COPY *.csproj .
RUN dotnet restore

# Kopiujemy pozostałe pliki i budujemy aplikację
COPY . .
RUN dotnet publish -c Release -o /app

# Etap uruchomienia
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "Emne_8_Cloud.dll"]