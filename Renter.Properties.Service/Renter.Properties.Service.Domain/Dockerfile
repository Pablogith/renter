FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Renter.Properties.Service.Abstractions/Renter.Properties.Service.Abstractions.csproj", "Renter.Properties.Service.Abstractions/"]
RUN dotnet restore "Renter.Properties.Service.Abstractions/Renter.Properties.Service.Abstractions.csproj"
COPY . .
WORKDIR "/src/Renter.Properties.Service.Abstractions"
RUN dotnet build "Renter.Properties.Service.Abstractions.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Renter.Properties.Service.Abstractions.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Renter.Properties.Service.Abstractions.dll"]
