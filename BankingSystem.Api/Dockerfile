#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["BankingSystem.Api/BankingSystem.Api.csproj", "BankingSystem.Api/"]
COPY ["BankingSystem.Contracts/BankingSystem.Contracts.csproj", "BankingSystem.Contracts/"]
COPY ["BankingSystem.Application/BankingSystem.Application.csproj", "BankingSystem.Application/"]
COPY ["BankingSystem.Domain/BankingSystem.Domain.csproj", "BankingSystem.Domain/"]
COPY ["BankingSystem.Infrastructure/BankingSystem.Infrastructure.csproj", "BankingSystem.Infrastructure/"]
RUN dotnet restore "BankingSystem.Api/BankingSystem.Api.csproj"
COPY . .
WORKDIR "/src/BankingSystem.Api"
RUN dotnet build "BankingSystem.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BankingSystem.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BankingSystem.Api.dll"]