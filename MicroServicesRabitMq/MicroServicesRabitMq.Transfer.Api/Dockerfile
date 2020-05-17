FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["MicroServicesRabitMq.Transfer.Api/MicroServicesRabitMq.Transfer.Api.csproj", "MicroServicesRabitMq.Transfer.Api/"]
RUN dotnet restore "MicroServicesRabitMq.Transfer.Api/MicroServicesRabitMq.Transfer.Api.csproj"
COPY . .
WORKDIR "/src/MicroServicesRabitMq.Transfer.Api"
COPY . .
RUN dotnet build "MicroServicesRabitMq.Transfer.Api/MicroServicesRabitMq.Transfer.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish MicroServicesRabitMq.Transfer.Api -c Release -o MicroServicesRabitMq.Transfer.Api/out

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "app/MicroServicesRabitMq.Transfer.Api.dll"]