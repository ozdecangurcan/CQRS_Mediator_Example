#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["CQRS_Mediator_Example/CQRS_Mediator_Example.csproj", "CQRS_Mediator_Example/"]
RUN dotnet restore "CQRS_Mediator_Example/CQRS_Mediator_Example.csproj"
COPY . .
WORKDIR "/src/CQRS_Mediator_Example"
RUN dotnet build "CQRS_Mediator_Example.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CQRS_Mediator_Example.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CQRS_Mediator_Example.dll"]