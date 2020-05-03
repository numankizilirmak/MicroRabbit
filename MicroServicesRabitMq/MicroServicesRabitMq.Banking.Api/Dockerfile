FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["MicroServicesRabitMq/MicroServicesRabitMq.Banking.Api/MicroServicesRabitMq.Banking.Api.csproj", "MicroServicesRabitMq.Banking.Api/"]
RUN dotnet restore "MicroServicesRabitMq.Banking.Api/MicroServicesRabitMq.Banking.Api.csproj"
COPY . .
WORKDIR "/src/MicroServicesRabitMq.Banking.Api"
COPY . .
RUN dotnet build "MicroServicesRabitMq/MicroServicesRabitMq.Banking.Api/MicroServicesRabitMq.Banking.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish MicroServicesRabitMq/MicroServicesRabitMq.Banking.Api -c Release -o MicroServicesRabitMq/MicroServicesRabitMq.Banking.Api/out

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MicroServicesRabitMq.Banking.Api.dll"]