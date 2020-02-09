#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["MicroServicesRabitMq.Transfer.Api/MicroServicesRabitMq.Transfer.Api.csproj", "MicroServicesRabitMq.Transfer.Api/"]
COPY ["MicroServicesRabitMq.Transfer.Data/MicroServicesRabitMq.Transfer.Data.csproj", "MicroServicesRabitMq.Transfer.Data/"]
COPY ["MicroServicesRabitMq.Transfer.Domain/MicroServicesRabitMq.Transfer.Domain.csproj", "MicroServicesRabitMq.Transfer.Domain/"]
COPY ["MicroServicesRabitMq.Domain.Core/MicroServicesRabitMq.Domain.Core.csproj", "MicroServicesRabitMq.Domain.Core/"]
COPY ["MicroServicesRabitMq.Infra.IoC/MicroServicesRabitMq.Infra.IoC.csproj", "MicroServicesRabitMq.Infra.IoC/"]
COPY ["MicroServicesRabitMq.Banking.Application/MicroServicesRabitMq.Banking.Application.csproj", "MicroServicesRabitMq.Banking.Application/"]
COPY ["MicroServicesRabitMq.Banking.Data/MicroServicesRabitMq.Banking.Data.csproj", "MicroServicesRabitMq.Banking.Data/"]
COPY ["MicroServicesRabitMq.Banking.Domain/MicroServicesRabitMq.Banking.Domain.csproj", "MicroServicesRabitMq.Banking.Domain/"]
COPY ["MicroServicesRabitMq.Infra.Bus/MicroServicesRabitMq.Infra.Bus.csproj", "MicroServicesRabitMq.Infra.Bus/"]
COPY ["MicroServicesRabitMq.Transfer.Application/MicroServicesRabitMq.Transfer.Application.csproj", "MicroServicesRabitMq.Transfer.Application/"]
RUN dotnet restore "MicroServicesRabitMq.Transfer.Api/MicroServicesRabitMq.Transfer.Api.csproj"
COPY . .
WORKDIR "/src/MicroServicesRabitMq.Transfer.Api"
RUN dotnet build "MicroServicesRabitMq.Transfer.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MicroServicesRabitMq.Transfer.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MicroServicesRabitMq.Transfer.Api.dll"]